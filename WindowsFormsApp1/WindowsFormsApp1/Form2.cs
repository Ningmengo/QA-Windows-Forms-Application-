using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int tryTimes = 0;
        public static string id = "";
        public static string name = "";
        public Form2()
        {
            InitializeComponent();
        }

      
    

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (TxtPSD.Text != "4seneca")
            {
                tryTimes++;
                lblHint.ForeColor = Color.Red;
                TxtPSD.Text = "";
                lblHint.Text = "You have " + (3 - tryTimes) + " times of trying !";

                if (tryTimes == 3)
                {
                    MessageBox.Show("Enter wrong three times in a row, Program is about to close","Close");
                    this.Close();
                }
            }
            else
            {
                id = TxtBoxID.Text;
                name = TxtBoxName.Text;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                

            }
        }
    }
}
