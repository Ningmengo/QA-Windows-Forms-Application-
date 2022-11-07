namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Location = new System.Drawing.Point(200, 21);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(144, 30);
            this.lblQuestionNum.TabIndex = 0;
            this.lblQuestionNum.Text = "Question #1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.lbl2.Location = new System.Drawing.Point(35, 67);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 23);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "What is 1+2?";
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(89, 127);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(44, 34);
            this.ans1.TabIndex = 2;
            this.ans1.Text = "3";
            this.ans1.UseVisualStyleBackColor = true;
            //this.ans1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(309, 127);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(44, 34);
            this.ans2.TabIndex = 3;
            this.ans2.Text = "4";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(89, 194);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(44, 34);
            this.ans3.TabIndex = 4;
            this.ans3.Text = "5";
            this.ans3.UseVisualStyleBackColor = true;
           // this.ans3.CheckedChanged += new System.EventHandler(this.ans3_CheckedChanged);
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(309, 286);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(146, 37);
            this.ProgBar.TabIndex = 5;
            // 
            // lblProgressRate
            // 
            this.lblProgressRate.AutoSize = true;
            this.lblProgressRate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.lblProgressRate.Location = new System.Drawing.Point(328, 256);
            this.lblProgressRate.Name = "lblProgressRate";
            this.lblProgressRate.Size = new System.Drawing.Size(98, 18);
            this.lblProgressRate.TabIndex = 6;
            this.lblProgressRate.Text = "0% Completed";
           // this.lblProgressRate.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.label4.Location = new System.Drawing.Point(35, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Left =>           seconds";
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(89, 347);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(118, 35);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "SUBMIT";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(309, 347);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(129, 35);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "NEXT";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // t
            // 
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.lbl_Timer.Location = new System.Drawing.Point(149, 286);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(30, 23);
            this.lbl_Timer.TabIndex = 10;
            this.lbl_Timer.Text = "10";
           // this.lbl_Timer.Click += new System.EventHandler(this.lbl_Timer_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(532, 416);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProgressRate);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblQuestionNum);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton ans1;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.Windows.Forms.Label lblProgressRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Label lbl_Timer;
    }
}

