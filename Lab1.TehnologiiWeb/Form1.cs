using System;
using System.Windows.Forms;

namespace Lab1.TehnologiiWeb
{
    public partial class Form1 : Form
    {
        // Add a field to store the randomly generated array
        private RandomArrayGenerator<int> randomIntArrayGenerator;
        private RandomArrayGenerator<double> randomDoubleArrayGenerator;
        private bool isIntChecked = true;

        public Form1()
        {
            InitializeComponent();
            randomIntArrayGenerator = new RandomArrayGenerator<int>();
            randomDoubleArrayGenerator = new RandomArrayGenerator<double>();
        }

        private void genRandomValBTN_Click(object sender, EventArgs e)
        {
            // Set the size of the array and the limits of the random values
            int arraySize = 10; // Choose the desired size
            int minValue = 1; // The minimum value of the elements
            int maxValue = 100; // The maximum value of the elements
            isIntChecked = this.integerNumberRadio.Checked;
            // Generate the random array
            if (isIntChecked)
            {
                randomIntArrayGenerator.GenerateArray(arraySize, minValue, maxValue);
            }
            else
            {
                randomDoubleArrayGenerator.GenerateArray(arraySize, minValue, maxValue);
            }

            DisplayArray();
        }

        private void DisplayArray()
        {
            this.textBox1.Clear(); // Clear the content of textBox1 before displaying the array
            bool isIntChecked = this.integerNumberRadio.Checked;

            if (isIntChecked)
            {
                if (randomIntArrayGenerator.Array == null)
                {
                    this.textBox1.Text = "Array-ul nu a fost initializat";
                }
                for (int i = 0; i < randomIntArrayGenerator.Array.Length; i++)
                {
                    this.textBox1.AppendText(randomIntArrayGenerator.Array[i].ToString()); // Add the current element in textBox1

                    if (i < randomIntArrayGenerator.Array.Length - 1)
                    {
                        this.textBox1.AppendText(", "); // Add a comma and a space between elements, except for the last element
                    }
                }
            }
            else
            {

                if (randomDoubleArrayGenerator.Array == null)
                {
                    this.textBox1.Text = "Array-ul nu a fost initializat";
                }
                for (int i = 0; i < randomDoubleArrayGenerator.Array.Length; i++)
                {
                    this.textBox1.AppendText(randomDoubleArrayGenerator.Array[i].ToString()); // Add the current element in textBox1

                    if (i < randomDoubleArrayGenerator.Array.Length - 1)
                    {
                        this.textBox1.AppendText(", "); // Add a comma and a space between elements, except for the last element
                    }
                }
            }
        }

        private void Sorteaza_Click(object sender, EventArgs e)
        {
            string selectedSortMethod = (string)sortMethodComboBox.SelectedItem;
            string selectedSortOrder = (string)sortOrderComboBox.SelectedItem;

            GenericSort<int>.Comparare intComparison;
            GenericSort<double>.Comparare doubleComparison;

            if (selectedSortOrder == "Crescator")
            {
                intComparison = (x, y) => x.CompareTo(y);
                doubleComparison = (x, y) => x.CompareTo(y);
            }
            else // DESC
            {
                intComparison = (x, y) => y.CompareTo(x);
                doubleComparison = (x, y) => y.CompareTo(x);
            }

            if (isIntChecked)
            {
                GenericSort<int> intSorter = new GenericSort<int>();

                switch (selectedSortMethod)
                {
                    case "Bubble":
                        intSorter.BubbleSort(randomIntArrayGenerator.Array, intComparison);
                        break;
                    case "Insertion":
                        intSorter.InsertionSort(randomIntArrayGenerator.Array, intComparison);
                        break;
                    case "Quick":
                        intSorter.QuickSort(randomIntArrayGenerator.Array, intComparison);
                        break;
                }
            }
            else
            {
                GenericSort<double> doubleSorter = new GenericSort<double>();

                switch (selectedSortMethod)
                {
                    case "Bubble":
                        doubleSorter.BubbleSort(randomDoubleArrayGenerator.Array, doubleComparison);
                        break;
                    case "Insertion":
                        doubleSorter.InsertionSort(randomDoubleArrayGenerator.Array, doubleComparison);
                        break;
                    case "Quick":
                        doubleSorter.QuickSort(randomDoubleArrayGenerator.Array, doubleComparison);
                        break;
                }
            }

            DisplaySorterArray();
        }

        private void DisplaySorterArray()
        {
            dataGridView1.Rows.Clear(); // Clear the content of dataGridView1 before displaying the array
            dataGridView1.ColumnCount = 1; // Set the number of columns to 1

            bool isIntChecked = this.integerNumberRadio.Checked;

            if (isIntChecked)
            {
                if (randomIntArrayGenerator.Array == null) return;
                for (int i = 0; i < randomIntArrayGenerator.Array.Length; i++)
                {
                    dataGridView1.Rows.Add(randomIntArrayGenerator.Array[i].ToString()); // Add the current element in dataGridView1
                }
            }
            else
            {
                if (randomDoubleArrayGenerator.Array == null) return;

                for (int i = 0; i < randomDoubleArrayGenerator.Array.Length; i++)
                {
                    dataGridView1.Rows.Add(randomDoubleArrayGenerator.Array[i].ToString()); // Add the current element in dataGridView1
                }
            }
        }


    }

    public class RandomArrayGenerator<T>
    {
        private T[] array;
        private static readonly Random random = new Random();

        public T[] Array
        {
            get { return array; }
        }

        public void GenerateArray(int size, double minValue, double maxValue)
        {
            array = new T[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = GenerateRandomValue(minValue, maxValue);
            }
        }

        private T GenerateRandomValue(double minValue, double maxValue)
        {
            if (typeof(T) == typeof(int))
            {
                int randomValue = random.Next((int)minValue, (int)maxValue + 1);
                return (T)Convert.ChangeType(randomValue, typeof(T));
            }
            else if (typeof(T) == typeof(double))
            {
                double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
                return (T)Convert.ChangeType(randomValue, typeof(T));
            }
            else
            {
                throw new InvalidOperationException("Invalid type. This class supports only int and double types.");
            }
        }
    }
}