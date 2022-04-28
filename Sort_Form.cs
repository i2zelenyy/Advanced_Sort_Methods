using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Advanced_Sortring_Methods
{
    public partial class Sort_Form : Form
    {
        public Sort_Form()
        {
            InitializeComponent();
        }
        double comp1, comp2, comp3, comp4;
        int Length, view_length;
        int swaps, comparisons;
        Stopwatch timer = new Stopwatch();
        Random rnd = new Random();
        int[] array_origin, array_sorted;

        private void Sort_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main_Form Back = new Main_Form();
            Back.Show();
            this.Hide();
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            Sort_button.Enabled = true;

            array_origin = new int[Length];
            array_sorted = new int[Length];

            if (Length == 10)
                view_length = Length;
            else
                view_length = 50;

            for (int i = 0; i < Length; i++)
            {
                int temp = Convert.ToInt32(rnd.Next(0, 1000));
                array_origin[i] = temp;
            }
            for (int i = 0; i < view_length; i++)
                Origin_Array_View.Rows[0].Cells[i].Value = array_origin[i];
        }

        private void Ten_Length_button_Click(object sender, EventArgs e) // 10
        {
            Generate_button.Enabled = true;
            Sort_button.Enabled = false;

            Length = 10;
            view_length = 10;
            Utility();
        }
        private void Hundred_Length_button_Click(object sender, EventArgs e) // 100
        {
            Generate_button.Enabled = true;
            Sort_button.Enabled = false;

            Length = 100;
            view_length = 50;
            Utility();
        }
        private void Thousand_Length_button_Click(object sender, EventArgs e) // 1000
        {
            Generate_button.Enabled = true;
            Sort_button.Enabled = false;

            Length = 1000;
            view_length = 50;
            Utility();
        }
        private void Ten_Thousand_Length_button_Click(object sender, EventArgs e) // 10000
        {
            Generate_button.Enabled = true;
            Sort_button.Enabled = false;

            Length = 10000;
            view_length = 50;
            Utility();
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            Bubbles_Sort();
            Insertion_Sort();
            Quick_Sort();
            Shell_Sort();

            for (int i = 0; i < view_length; i++)
                Sorted_Array_View.Rows[0].Cells[i].Value = array_sorted[i];
        }

        void Utility()
        {
            Length_label.Text = "Current Length: " + Length;

            Origin_Array_View.ColumnCount = view_length;
            Origin_Array_View.RowCount = 1;
            Sorted_Array_View.ColumnCount = view_length;
            Sorted_Array_View.RowCount = 1;

            comp1 = Math.Round(Length * Math.Log(Length, 2));
            comp2 = Math.Round(Length * Math.Pow(Math.Log(Length, 2), 2));           
            comp3 = Math.Pow(Length, 2);
            comp4 = Math.Pow(Length, 2);

            // 1-Shellsort | 2-Quicksort | 3-Bubble sort | 4- Insertion Sort
            Complexity_label_1.Text = "Complexity: " + string.Format("{0:0:000:000}", comp1);
            Complexity_label_2.Text = "Complexity: " + string.Format("{0:0:000:000}", comp2);           
            Complexity_label_3.Text = "Complexity: " + string.Format("{0:0:000:000}", comp3);
            Complexity_label_4.Text = "Complexity: " + string.Format("{0:0:000:000}", comp4);
        }

        void Bubbles_Sort()
        {
            swaps = 0;
            comparisons = 0;
            int[] bubble_array = new int[Length];
            array_origin.CopyTo(bubble_array, 0);

            timer.Restart();
            timer.Start();

            for (int i = 1; i < Length; i++)
            {
                int temp;
                for (int j = 1; j < Length; j++)
                {
                    comparisons += 1;
                    if (bubble_array[j] < bubble_array[j - 1])
                    {
                        swaps += 1;
                        temp = bubble_array[j - 1];
                        bubble_array[j - 1] = bubble_array[j];
                        bubble_array[j] = temp;
                    }
                }
            } // Sorting Algorithm

            timer.Stop();

            TimeSpan time = timer.Elapsed;
            long microseconds = timer.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            Time_label_3.Text = "Time: " + string.Format("{0:0:000:000}", microseconds);
            Swaps_label_3.Text = "Swaps: " + string.Format("{0:0:000:000} ({1:00%})", swaps, (float)swaps / comparisons);
            Comparisons_label_3.Text = "Comparisons: " + string.Format("{0:0:000:000}", comparisons);
        }

        void Insertion_Sort()
        {
            swaps = 0;
            comparisons = 0;
            int[] insertion_array = new int[Length];
            array_origin.CopyTo(insertion_array, 0);

            timer.Restart();
            timer.Start();

            for (int i = 1; i < Length; i++)
            {
                int number = insertion_array[i];
                int index;
                
                for (index = i-1; index >= 0; index -= 1)
                {
                    comparisons += 1;
                    if (insertion_array[index] < number)
                        break;

                    insertion_array[index+1] = insertion_array[index];
                    swaps += 1;
                }               
                insertion_array[index+1] = number;
            }

            timer.Stop();

            TimeSpan time = timer.Elapsed;
            long microseconds = timer.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            Time_label_4.Text = "Time: " + string.Format("{0:0:000:000}", microseconds);
            Swaps_label_4.Text = "Swaps: " + string.Format("{0:0:000:000} ({1:00%})", swaps, (float)swaps / comparisons);
            Comparisons_label_4.Text = "Comparisons: " + string.Format("{0:0:000:000}", comparisons);           
        }

        void Quick_Sort()
        {
            swaps = 0;
            comparisons = 0;
            int[] quick_array = new int[Length];
            array_origin.CopyTo(quick_array, 0);

            timer.Restart();
            timer.Start();

            Quick_Sorting(quick_array, 0, Length-1);

            timer.Stop();

            TimeSpan time = timer.Elapsed;
            long microseconds = timer.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            Time_label_1.Text = "Time: " + string.Format("{0:0:000:000}", microseconds);
            Swaps_label_1.Text = "Swaps: " + string.Format("{0:0:000:000} ({1:00%})", swaps, (float)swaps / comparisons);
            Comparisons_label_1.Text = "Comparisons: " + string.Format("{0:0:000:000}", comparisons);           
        }

        void Shell_Sort()

        {
            swaps = 0;
            comparisons = 0;
            int[] shell_array = new int[Length];
            array_origin.CopyTo(shell_array, 0);
            int step = Length / 2;

            timer.Restart();
            timer.Start();
           
            while (step > 0)
            {
                int i, j;
                for (i = step; i < Length; i++)
                {
                    int temp = shell_array[i];

                    comparisons += 1;
                    for (j = i-step; (j >= 0) && (shell_array[j] > temp); j -= step)
                    {                
                        swaps += 1;
                        shell_array[j+step] = shell_array[j]; // compares elements according to the "step"
                        comparisons += 1;
                    }
                    comparisons += 1;
                    swaps += 1;
                    shell_array[j+step] = temp;

                }
                step = step / 2;
            }

            timer.Stop();

            TimeSpan time = timer.Elapsed;
            long microseconds = timer.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            Time_label_2.Text = "Time: " + string.Format("{0:0:000:000}", microseconds);
            Swaps_label_2.Text = "Swaps: " + string.Format("{0:0:000:000} ({1:00%})", swaps, (float)swaps / comparisons);
            Comparisons_label_2.Text = "Comparisons: " + string.Format("{0:0:000:000}", comparisons);

            shell_array.CopyTo(array_sorted, 0);
        }

        void Quick_Sorting(int[] quick_array, int first_point, int last_point)
        {
            if (first_point >= last_point)
                return;

            int pivot = partition(quick_array, first_point, last_point);
            Quick_Sorting(quick_array, first_point, pivot-1);
            Quick_Sorting(quick_array, pivot+1, last_point);
        }

        int partition(int[] quick_array, int first_point, int last_point)
        {
            int temp;
            int first = first_point;
            for (int i = first_point; i <= last_point; i++) // goes from the left edge to the right
            {
                comparisons += 1;
                if (quick_array[i] < quick_array[last_point]) // if "pointer" is less than the right edge element
                {
                    swaps += 1;
                    temp = quick_array[first];
                    quick_array[first] = quick_array[i]; // left edge swaps with the "pointer"
                    quick_array[i] = temp;
                    first += 1; // left edge moves right
                }
            }

            temp = quick_array[first];
            quick_array[first] = quick_array[last_point]; // swaps the emelents of the edges
            quick_array[last_point] = temp;
            swaps += 1;
            return first; // pointer of the left edge
        }
    }
}
