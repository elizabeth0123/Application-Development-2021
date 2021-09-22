
namespace application_development_2021
{
    partial class Form2
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
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lblTimetaken = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnanimation2 = new System.Windows.Forms.Button();
            this.bbtnHomepage = new System.Windows.Forms.Button();
            this.bttnExit2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(6, 103);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(200, 38);
            this.lblRandom.TabIndex = 0;
            this.lblRandom.Text = "Random Array:";
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Location = new System.Drawing.Point(6, 234);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(178, 38);
            this.lblSorted.TabIndex = 1;
            this.lblSorted.Text = "Sorted Array:";
            // 
            // lblTimetaken
            // 
            this.lblTimetaken.AutoSize = true;
            this.lblTimetaken.Location = new System.Drawing.Point(6, 391);
            this.lblTimetaken.Name = "lblTimetaken";
            this.lblTimetaken.Size = new System.Drawing.Size(160, 38);
            this.lblTimetaken.TabIndex = 2;
            this.lblTimetaken.Text = "Time taken:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.bttnanimation2);
            this.groupBox1.Controls.Add(this.bbtnHomepage);
            this.groupBox1.Controls.Add(this.bttnExit2);
            this.groupBox1.Controls.Add(this.lblTimetaken);
            this.groupBox1.Controls.Add(this.lblRandom);
            this.groupBox1.Controls.Add(this.lblSorted);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(-4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm Results";
            // 
            // bttnanimation2
            // 
            this.bttnanimation2.BackColor = System.Drawing.Color.Turquoise;
            this.bttnanimation2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnanimation2.Location = new System.Drawing.Point(522, 477);
            this.bttnanimation2.Name = "bttnanimation2";
            this.bttnanimation2.Size = new System.Drawing.Size(288, 47);
            this.bttnanimation2.TabIndex = 5;
            this.bttnanimation2.Text = "Click For Animation";
            this.bttnanimation2.UseVisualStyleBackColor = false;
            this.bttnanimation2.Click += new System.EventHandler(this.bttnanimation2_Click);
            // 
            // bbtnHomepage
            // 
            this.bbtnHomepage.BackColor = System.Drawing.Color.Turquoise;
            this.bbtnHomepage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bbtnHomepage.Location = new System.Drawing.Point(337, 477);
            this.bbtnHomepage.Name = "bbtnHomepage";
            this.bbtnHomepage.Size = new System.Drawing.Size(164, 46);
            this.bbtnHomepage.TabIndex = 4;
            this.bbtnHomepage.Text = "Homepage";
            this.bbtnHomepage.UseVisualStyleBackColor = false;
            this.bbtnHomepage.Click += new System.EventHandler(this.bbtnHomepage_Click);
            // 
            // bttnExit2
            // 
            this.bttnExit2.BackColor = System.Drawing.Color.Crimson;
            this.bttnExit2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnExit2.Location = new System.Drawing.Point(677, 0);
            this.bttnExit2.Name = "bttnExit2";
            this.bttnExit2.Size = new System.Drawing.Size(120, 46);
            this.bttnExit2.TabIndex = 3;
            this.bttnExit2.Text = "Exit";
            this.bttnExit2.UseVisualStyleBackColor = false;
            this.bttnExit2.Click += new System.EventHandler(this.bttnExit2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 534);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Label lblTimetaken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnExit2;
        private System.Windows.Forms.Button bttnanimation2;
        private System.Windows.Forms.Button bbtnHomepage;
        private System.Windows.Forms.Timer timer1;
    }
}