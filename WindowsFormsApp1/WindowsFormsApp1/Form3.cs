using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            string[] arrAns = new string[] { "Question1: What is 1+2?   Correct Answer = 3", "Question2: What is 2+3?   Correct Answer = 5", "Question3: Is cat an animal?   Correct Answer = True", "Question4: What is 9-5?   Correct Answer = 4", "Question5: What is 5*2?   Correct Answer = 10" };

            lblID_3.Text = "ID: "+ Form2.id;
            lblName_3.Text = "Name: " + Form2.name;
            lblScore.Text = "Score: " + (Form1.totalMark * 20) + "  (max:100)";

            string[] newArr = Form1.arr;

            for(int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == "false")
                {
                    lblWrongQNum.Text += (i+1)+"  ";
                    TextBoxResult.Text += arrAns[i] + newLine;
                }
            }




            StreamWriter wfile;
            try
            {
                wfile = File.AppendText("test.txt");
                wfile.WriteLine(lblID_3.Text);
                wfile.WriteLine(lblName_3.Text);
                wfile.WriteLine(lblScore.Text);
                wfile.Close();
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("File is not found: "+exc);
            }
           
        }

    }
}
