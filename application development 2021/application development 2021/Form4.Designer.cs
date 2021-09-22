
namespace application_development_2021
{
    partial class Form4
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
            this.lblLinearSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtFoundorNot = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.ListBox();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnanimation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLinearSearch
            // 
            this.lblLinearSearch.AutoSize = true;
            this.lblLinearSearch.Location = new System.Drawing.Point(401, 70);
            this.lblLinearSearch.Name = "lblLinearSearch";
            this.lblLinearSearch.Size = new System.Drawing.Size(50, 20);
            this.lblLinearSearch.TabIndex = 0;
            this.lblLinearSearch.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bttnSearch);
            this.panel1.Controls.Add(this.txtFoundorNot);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bttnFill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Location = new System.Drawing.Point(25, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 368);
            this.panel1.TabIndex = 1;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnSearch.Location = new System.Drawing.Point(361, 321);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(151, 40);
            this.bttnSearch.TabIndex = 5;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtFoundorNot
            // 
            this.txtFoundorNot.Location = new System.Drawing.Point(231, 182);
            this.txtFoundorNot.Name = "txtFoundorNot";
            this.txtFoundorNot.Size = new System.Drawing.Size(281, 27);
            this.txtFoundorNot.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(231, 89);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(281, 27);
            this.txtNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Found or Not Found";
            // 
            // bttnFill
            // 
            this.bttnFill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnFill.Location = new System.Drawing.Point(179, 321);
            this.bttnFill.Name = "bttnFill";
            this.bttnFill.Size = new System.Drawing.Size(151, 40);
            this.bttnFill.TabIndex = 2;
            this.bttnFill.Text = "Fill Numbers";
            this.bttnFill.UseVisualStyleBackColor = true;
            this.bttnFill.Click += new System.EventHandler(this.bttnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "What number are you looking for?";
            // 
            // lblRandom
            // 
            this.lblRandom.FormattingEnabled = true;
            this.lblRandom.ItemHeight = 20;
            this.lblRandom.Location = new System.Drawing.Point(3, 12);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(125, 324);
            this.lblRandom.TabIndex = 0;
            // 
            // bttnHome
            // 
            this.bttnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnHome.Location = new System.Drawing.Point(244, 12);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(145, 40);
            this.bttnHome.TabIndex = 3;
            this.bttnHome.Text = "Homepage";
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnExit.Location = new System.Drawing.Point(617, 15);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(146, 40);
            this.bttnExit.TabIndex = 5;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Linear Search";
            // 
            // bttnanimation
            // 
            this.bttnanimation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnanimation.Location = new System.Drawing.Point(452, 15);
            this.bttnanimation.Name = "bttnanimation";
            this.bttnanimation.Size = new System.Drawing.Size(123, 40);
            this.bttnanimation.TabIndex = 7;
            this.bttnanimation.Text = "Animation";
            this.bttnanimation.UseVisualStyleBackColor = true;
            this.bttnanimation.Click += new System.EventHandler(this.bttnanimation_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnanimation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.lblLinearSearch);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinearSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFoundorNot;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lblRandom;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Button bttnanimation;
    }
}