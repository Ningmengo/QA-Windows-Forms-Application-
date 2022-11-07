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
    public partial class Form1 : Form
    {

        
        
        int submitTimes = 0;
     
        int currentQN = 1;
        public static int totalMark = 0;
        public static string [] arr= new string[] { "true", "true", "true", "true", "true" };
        int counter = 11;
            
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_sub_Click(object sender, EventArgs e)
        {
            t.Stop();
            submitTimes++;
            ans1.Enabled = false;
            ans2.Enabled = false;
            ans3.Enabled = false;

            if (submitTimes == 1)
            {
                ProgBar.Value += 20;
                lblProgressRate.Text = ProgBar.Value + "% Completed";
            }
            if(currentQN == 5)
            {
                btn_Next.Text = "Finish";
               
            }

            switch (currentQN)
            {
                case 1:
                    if (ans1.Checked == true)
                    {                      
                        totalMark += 1;
                        
                    }
                    else
                    {
                        arr[0] = "false";
                    }

                    
                    break;
                case 2:
                    if (ans2.Checked == true)
                    {
                     
                        totalMark += 1;
                    }
                    else
                    {
                        arr[1] = "false";
                    }
                    break;
                case 3:
                    if (ans1.Checked == true)
                    {

                        totalMark += 1;
                    }
                    else
                    {
                        arr[2] = "false";
                    }
                    break;
                case 4:
                    if (ans2.Checked == true)
                    {

                        totalMark += 1;
                    }
                    else
                    {
                        arr[3] = "false";
                    }
                    break;
                case 5:
                    if (ans3.Checked == true)
                    {

                        totalMark += 1;
                    }
                    else
                    {
                        arr[4] = "false";
                    }
                    break;


            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;

            this.t.Start();
            t.Tick += new EventHandler(t_Tick);


        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            counter = 11;
            t.Start();
            ans1.Enabled = true;
            ans2.Enabled = true;
            ans3.Enabled = true;
            btn_sub.Enabled = true;
            

            if (currentQN != 5)
                {
                    lblQuestionNum.Text = "Question #" + (currentQN + 1);
                   
                }
               
               
                submitTimes = 0;
                currentQN++;
                if (currentQN == 2)
                {
                    lbl2.Text = "What is 2+3?";
                    ans1.Text = "1";
                    ans2.Text = "5";
                    ans3.Text = "6";
                }
                else if (currentQN == 3)
                {
                    lbl2.Text = "Is cat an animal?";
                    ans1.Text = "True";
                    ans2.Text = "False";
                    ans3.Hide();

                }
                else if (currentQN == 4)
                {
                    ans3.Show();
                    lbl2.Text = "What is 9-5?";
                    ans1.Text = "1";
                    ans2.Text = "4";
                    ans3.Text = "6";
                }
                else if (currentQN == 5)
                {
                    lbl2.Text = "What is 5*2?";
                    ans1.Text = "1";
                    ans2.Text = "7";
                    ans3.Text = "10";
                    
                }
                else if(currentQN == 6)
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                 
                }
            
        }
    

    
        private void t_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                this.t.Stop();
                t.Enabled = false;
                lbl_Timer.Text = counter.ToString();
                ans1.Enabled = false;
                ans2.Enabled = false;
                ans3.Enabled = false;
                btn_sub.Enabled = false;
            }
            else
            {
                lbl_Timer.Text = counter.ToString();
            }
               
        }
    }
}
