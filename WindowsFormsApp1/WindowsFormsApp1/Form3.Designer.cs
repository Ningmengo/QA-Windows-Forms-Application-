namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblName_3 = new System.Windows.Forms.Label();
            this.lblID_3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWrongQNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName_3
            // 
            this.lblName_3.AutoSize = true;
            this.lblName_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_3.Location = new System.Drawing.Point(27, 60);
            this.lblName_3.Name = "lblName_3";
            this.lblName_3.Size = new System.Drawing.Size(51, 20);
            this.lblName_3.TabIndex = 0;
            this.lblName_3.Text = "Name";
            // 
            // lblID_3
            // 
            this.lblID_3.AutoSize = true;
            this.lblID_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_3.Location = new System.Drawing.Point(509, 60);
            this.lblID_3.Name = "lblID_3";
            this.lblID_3.Size = new System.Drawing.Size(26, 20);
            this.lblID_3.TabIndex = 1;
            this.lblID_3.Text = "ID";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(954, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResult.Location = new System.Drawing.Point(85, 200);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(1057, 259);
            this.TextBoxResult.TabIndex = 3;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your wrong questions are: ";
            // 
            // lblWrongQNum
            // 
            this.lblWrongQNum.AutoSize = true;
            this.lblWrongQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongQNum.Location = new System.Drawing.Point(404, 142);
            this.lblWrongQNum.Name = "lblWrongQNum";
            this.lblWrongQNum.Size = new System.Drawing.Size(0, 20);
            this.lblWrongQNum.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1229, 497);
            this.Controls.Add(this.lblWrongQNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblID_3);
            this.Controls.Add(this.lblName_3);
            this.Name = "Form3";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName_3;
        private System.Windows.Forms.Label lblID_3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWrongQNum;
    }
}