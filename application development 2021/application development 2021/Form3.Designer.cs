
namespace application_development_2021
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
            this.components = new System.ComponentModel.Container();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnHomepage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnSort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(581, 7);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(87, 28);
            this.bttnExit.TabIndex = 0;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnHomepage
            // 
            this.bttnHomepage.Location = new System.Drawing.Point(462, 7);
            this.bttnHomepage.Name = "bttnHomepage";
            this.bttnHomepage.Size = new System.Drawing.Size(113, 28);
            this.bttnHomepage.TabIndex = 1;
            this.bttnHomepage.Text = "Homepage";
            this.bttnHomepage.UseVisualStyleBackColor = true;
            this.bttnHomepage.Click += new System.EventHandler(this.bttnHomepage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bubble Sort"});
            this.comboBox1.Location = new System.Drawing.Point(94, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(262, 5);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(94, 29);
            this.bttnReset.TabIndex = 4;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 409);
            this.panel1.TabIndex = 5;
            // 
            // bttnSort
            // 
            this.bttnSort.Location = new System.Drawing.Point(362, 6);
            this.bttnSort.Name = "bttnSort";
            this.bttnSort.Size = new System.Drawing.Size(94, 29);
            this.bttnSort.TabIndex = 6;
            this.bttnSort.Text = "Sort";
            this.bttnSort.UseVisualStyleBackColor = true;
            this.bttnSort.Click += new System.EventHandler(this.bttnSort_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnSort);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnHomepage);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnHomepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnSort;
        private System.Windows.Forms.Timer timer1;
    }
}