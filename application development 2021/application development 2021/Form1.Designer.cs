
namespace application_development_2021
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsortingalgo = new System.Windows.Forms.Button();
            this.bttnsearchingalgo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsortingalgo
            // 
            this.btnsortingalgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsortingalgo.Location = new System.Drawing.Point(70, 194);
            this.btnsortingalgo.Name = "btnsortingalgo";
            this.btnsortingalgo.Size = new System.Drawing.Size(141, 88);
            this.btnsortingalgo.TabIndex = 0;
            this.btnsortingalgo.Text = "Sorting Algorithms";
            this.btnsortingalgo.UseVisualStyleBackColor = false;
            // 
            // bttnsearchingalgo
            // 
            this.bttnsearchingalgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearchingalgo.Location = new System.Drawing.Point(70, 349);
            this.bttnsearchingalgo.Name = "bttnsearchingalgo";
            this.bttnsearchingalgo.Size = new System.Drawing.Size(141, 88);
            this.bttnsearchingalgo.TabIndex = 1;
            this.bttnsearchingalgo.Text = "Searching Algorithms";
            this.bttnsearchingalgo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, we are going to be learning about algorithms!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Please click the button you would like to start with.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(286, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bubble sort";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(286, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Selection Sort";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(286, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 57);
            this.button3.TabIndex = 6;
            this.button3.Text = "Binary Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(286, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 57);
            this.button4.TabIndex = 7;
            this.button4.Text = "Linear Search ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Location = new System.Drawing.Point(479, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 77);
            this.button5.TabIndex = 8;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Location = new System.Drawing.Point(694, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 77);
            this.button6.TabIndex = 9;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 480);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnsearchingalgo);
            this.Controls.Add(this.btnsortingalgo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsortingalgo;
        private System.Windows.Forms.Button bttnsearchingalgo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

