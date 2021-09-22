
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
            this.components = new System.ComponentModel.Container();
            this.bttnsearchingalgo = new System.Windows.Forms.Button();
            this.bttnsortingalgo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnBubblesort = new System.Windows.Forms.Button();
            this.bttnSelectionsort = new System.Windows.Forms.Button();
            this.bttnBinarysearch = new System.Windows.Forms.Button();
            this.bttnLinearsearch = new System.Windows.Forms.Button();
            this.bttnclear = new System.Windows.Forms.Button();
            this.bttnanimation = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.lblinstrustion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bttnsearchingalgo
            // 
            this.bttnsearchingalgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearchingalgo.Location = new System.Drawing.Point(51, 345);
            this.bttnsearchingalgo.Name = "bttnsearchingalgo";
            this.bttnsearchingalgo.Size = new System.Drawing.Size(144, 101);
            this.bttnsearchingalgo.TabIndex = 0;
            this.bttnsearchingalgo.Text = "Searching Algorithms";
            this.bttnsearchingalgo.UseVisualStyleBackColor = false;
            this.bttnsearchingalgo.Click += new System.EventHandler(this.bttnsearchingalgo_Click);
            // 
            // bttnsortingalgo
            // 
            this.bttnsortingalgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsortingalgo.Location = new System.Drawing.Point(51, 180);
            this.bttnsortingalgo.Name = "bttnsortingalgo";
            this.bttnsortingalgo.Size = new System.Drawing.Size(144, 101);
            this.bttnsortingalgo.TabIndex = 1;
            this.bttnsortingalgo.Text = "Sorting Algorithms";
            this.bttnsortingalgo.UseVisualStyleBackColor = false;
            this.bttnsortingalgo.Click += new System.EventHandler(this.bttnsortingalgo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello, we are going to be learning about algorithms!";
            // 
            // bttnBubblesort
            // 
            this.bttnBubblesort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnBubblesort.Location = new System.Drawing.Point(286, 169);
            this.bttnBubblesort.Name = "bttnBubblesort";
            this.bttnBubblesort.Size = new System.Drawing.Size(159, 57);
            this.bttnBubblesort.TabIndex = 4;
            this.bttnBubblesort.Text = "Bubble sort";
            this.bttnBubblesort.UseVisualStyleBackColor = false;
            this.bttnBubblesort.Click += new System.EventHandler(this.bttnBubblesort_Click);
            // 
            // bttnSelectionsort
            // 
            this.bttnSelectionsort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSelectionsort.Location = new System.Drawing.Point(286, 244);
            this.bttnSelectionsort.Name = "bttnSelectionsort";
            this.bttnSelectionsort.Size = new System.Drawing.Size(159, 57);
            this.bttnSelectionsort.TabIndex = 5;
            this.bttnSelectionsort.Text = "Selection Sort";
            this.bttnSelectionsort.UseVisualStyleBackColor = false;
            this.bttnSelectionsort.Click += new System.EventHandler(this.bttnSelectionsort_Click);
            // 
            // bttnBinarysearch
            // 
            this.bttnBinarysearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnBinarysearch.Location = new System.Drawing.Point(286, 421);
            this.bttnBinarysearch.Name = "bttnBinarysearch";
            this.bttnBinarysearch.Size = new System.Drawing.Size(159, 57);
            this.bttnBinarysearch.TabIndex = 6;
            this.bttnBinarysearch.Text = "Binary Search";
            this.bttnBinarysearch.UseVisualStyleBackColor = false;
            this.bttnBinarysearch.Click += new System.EventHandler(this.bttnBinarysearch_Click);
            // 
            // bttnLinearsearch
            // 
            this.bttnLinearsearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnLinearsearch.Location = new System.Drawing.Point(286, 328);
            this.bttnLinearsearch.Name = "bttnLinearsearch";
            this.bttnLinearsearch.Size = new System.Drawing.Size(159, 57);
            this.bttnLinearsearch.TabIndex = 7;
            this.bttnLinearsearch.Text = "Linear Search ";
            this.bttnLinearsearch.UseVisualStyleBackColor = false;
            this.bttnLinearsearch.Click += new System.EventHandler(this.bttnLinearsearch_Click);
            // 
            // bttnclear
            // 
            this.bttnclear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bttnclear.Location = new System.Drawing.Point(655, 273);
            this.bttnclear.Name = "bttnclear";
            this.bttnclear.Size = new System.Drawing.Size(111, 77);
            this.bttnclear.TabIndex = 9;
            this.bttnclear.Text = "Clear";
            this.bttnclear.UseVisualStyleBackColor = false;
            this.bttnclear.Click += new System.EventHandler(this.bttnclear_Click);
            // 
            // bttnanimation
            // 
            this.bttnanimation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttnanimation.Location = new System.Drawing.Point(497, 421);
            this.bttnanimation.Name = "bttnanimation";
            this.bttnanimation.Size = new System.Drawing.Size(191, 47);
            this.bttnanimation.TabIndex = 10;
            this.bttnanimation.Text = "Please click for animation";
            this.bttnanimation.UseVisualStyleBackColor = false;
            this.bttnanimation.Click += new System.EventHandler(this.bttnanimation_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(724, 421);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(135, 47);
            this.bttnExit.TabIndex = 12;
            this.bttnExit.Text = "Exit Application";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // lblinstrustion
            // 
            this.lblinstrustion.AutoSize = true;
            this.lblinstrustion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblinstrustion.Location = new System.Drawing.Point(65, 90);
            this.lblinstrustion.Name = "lblinstrustion";
            this.lblinstrustion.Size = new System.Drawing.Size(701, 25);
            this.lblinstrustion.TabIndex = 13;
            this.lblinstrustion.Text = "Click the Algorithm you want to start with and follow the prompts to get started." +
    "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 480);
            this.Controls.Add(this.lblinstrustion);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnanimation);
            this.Controls.Add(this.bttnclear);
            this.Controls.Add(this.bttnLinearsearch);
            this.Controls.Add(this.bttnBinarysearch);
            this.Controls.Add(this.bttnSelectionsort);
            this.Controls.Add(this.bttnBubblesort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnsortingalgo);
            this.Controls.Add(this.bttnsearchingalgo);
            this.Name = "Form1";
            this.Text = "Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnsearchingalgo;
        private System.Windows.Forms.Button bttnsortingalgo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnBubblesort;
        private System.Windows.Forms.Button bttnSelectionsort;
        private System.Windows.Forms.Button bttnBinarysearch;
        private System.Windows.Forms.Button bttnLinearsearch;
        private System.Windows.Forms.Button bttnclear;
        private System.Windows.Forms.Button bttnanimation;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label lblinstrustion;
        private System.Windows.Forms.Timer timer1;
    }
}

