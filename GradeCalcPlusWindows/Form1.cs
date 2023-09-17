using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalcPlusWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            neededGrades_lbl.Text = "";
        }
     
        private List<int> currentGrades = new List<int>();
        int sum = 0;
        int gradeCount = 0;
        float targetAverage;
        private void calculate_bttn_Click(object sender, EventArgs e)
        {
            //error handling:
            if (!validInput(currentGrades_box.Text))
            {
                MessageBox.Show("Please input valid grades (1-10)!");
            }
            else if (currentGrades_box.Text == "")
            {
                MessageBox.Show("Please input some grades (1-10)!");
            }
            else if (targetAverage_box.Text == "")
            {
                MessageBox.Show("Please input a target average (1-10)!");
            }
            else if (targetAverage_box.Text.Contains('.') || targetAverage_box.Text.Contains(','))
            {
                MessageBox.Show("Please input a valid target average (integer (1-10))!");
            }
            else //valid input
            {
                getData(currentGrades_box.Text);

                targetAverage = float.Parse(targetAverage_box.Text);
                if ((int) targetAverage == Math.Round((float) sum/gradeCount))
                {
                    MessageBox.Show($"Your average is already {targetAverage}!");
                }
                else if (targetAverage < (float) sum/gradeCount)
                {
                    MessageBox.Show($"Your average is already greater than {targetAverage}!");
                }
                else
                {
                    targetAverage -= 0.5f;
                    neededGrades.Clear();

                    getGrades(targetAverage, minGrade, sum, gradeCount);

                    outputGrades();
                }
            }
        }

        private void currentGrades_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool validInput(string input)
        {
            foreach (char c in input)
                if (!Char.IsDigit(c) && c != ' ')
                    return false;

            return true;
        }

        private void getData(string currentGradesText)
        {
            string[] grades = currentGradesText.Split(',', ' ');
            foreach (string grade in grades) 
            {
                int gradeInt = int.Parse(grade);
                currentGrades.Add(gradeInt);

                sum += gradeInt;
                gradeCount++;
            }
        }

        List<int> neededGrades = new List<int>();
        int minGrade = 4;
        void getGrades(float targetAverage, int grade, int newSum, int newGradeCount)
        {
            float average = (float)newSum / newGradeCount;
            if (average >= targetAverage)
            {
                neededGrades.Add(grade - 1);
                return;
            }
            else
            {
                if (grade <= 10)
                {
                    getGrades(targetAverage, grade + 1, sum + grade, gradeCount + 1);
                }
                else
                {
                    neededGrades.Add(10);
                    sum += 10;
                    gradeCount++;
                    getGrades(targetAverage, minGrade, sum, gradeCount);
                }
            }
            return;
        }

        int maxGradeAmount = 6;
        void outputGrades()
        {
            int neededGradesCount = neededGrades.Count;
            if (neededGradesCount > maxGradeAmount)
            {
                MessageBox.Show($"You would need {neededGradesCount} grades. You cannot get that many this year.\n Better luck next time!");
            }
            else
            {
                string tmp = "";
                foreach (int grade in neededGrades)
                {
                    tmp += grade.ToString() + " ";
                }
                neededGrades_lbl.Text = tmp;
            }
        }

        private void targetAverage_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
