namespace Name_Search
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
            this.labelBoys = new System.Windows.Forms.Label();
            this.labelGirls = new System.Windows.Forms.Label();
            this.MostPopularBoyLabel = new System.Windows.Forms.Label();
            this.MostPopularGirlLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkNames = new System.Windows.Forms.Button();
            this.textBoxBoyName = new System.Windows.Forms.TextBox();
            this.textBoxGirlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBoys = new System.Windows.Forms.ListBox();
            this.listBoxGirls = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBoys
            // 
            this.labelBoys.AutoSize = true;
            this.labelBoys.Location = new System.Drawing.Point(12, 102);
            this.labelBoys.Name = "labelBoys";
            this.labelBoys.Size = new System.Drawing.Size(131, 13);
            this.labelBoys.TabIndex = 2;
            this.labelBoys.Text = "Please enter a name (Boy)";
            // 
            // labelGirls
            // 
            this.labelGirls.AutoSize = true;
            this.labelGirls.Location = new System.Drawing.Point(173, 102);
            this.labelGirls.Name = "labelGirls";
            this.labelGirls.Size = new System.Drawing.Size(128, 13);
            this.labelGirls.TabIndex = 3;
            this.labelGirls.Text = "Please enter a name (Girl)";
            // 
            // MostPopularBoyLabel
            // 
            this.MostPopularBoyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MostPopularBoyLabel.Location = new System.Drawing.Point(42, 173);
            this.MostPopularBoyLabel.Name = "MostPopularBoyLabel";
            this.MostPopularBoyLabel.Size = new System.Drawing.Size(61, 23);
            this.MostPopularBoyLabel.TabIndex = 4;
            this.MostPopularBoyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MostPopularGirlLabel
            // 
            this.MostPopularGirlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MostPopularGirlLabel.Location = new System.Drawing.Point(40, 172);
            this.MostPopularGirlLabel.Name = "MostPopularGirlLabel";
            this.MostPopularGirlLabel.Size = new System.Drawing.Size(66, 23);
            this.MostPopularGirlLabel.TabIndex = 5;
            this.MostPopularGirlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(106, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkNames
            // 
            this.checkNames.Location = new System.Drawing.Point(106, 205);
            this.checkNames.Name = "checkNames";
            this.checkNames.Size = new System.Drawing.Size(110, 49);
            this.checkNames.TabIndex = 7;
            this.checkNames.Text = "Compare Names And Display";
            this.checkNames.UseVisualStyleBackColor = true;
            this.checkNames.Click += new System.EventHandler(this.checkNames_Click);
            // 
            // textBoxBoyName
            // 
            this.textBoxBoyName.Location = new System.Drawing.Point(23, 120);
            this.textBoxBoyName.Name = "textBoxBoyName";
            this.textBoxBoyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBoyName.TabIndex = 8;
            // 
            // textBoxGirlName
            // 
            this.textBoxGirlName.Location = new System.Drawing.Point(25, 117);
            this.textBoxGirlName.Name = "textBoxGirlName";
            this.textBoxGirlName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGirlName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Is your name popular?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Is your name popular?";
            // 
            // listBoxBoys
            // 
            this.listBoxBoys.FormattingEnabled = true;
            this.listBoxBoys.Location = new System.Drawing.Point(15, 19);
            this.listBoxBoys.Name = "listBoxBoys";
            this.listBoxBoys.Size = new System.Drawing.Size(120, 69);
            this.listBoxBoys.TabIndex = 12;
            // 
            // listBoxGirls
            // 
            this.listBoxGirls.FormattingEnabled = true;
            this.listBoxGirls.Location = new System.Drawing.Point(17, 19);
            this.listBoxGirls.Name = "listBoxGirls";
            this.listBoxGirls.Size = new System.Drawing.Size(120, 69);
            this.listBoxGirls.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxBoys);
            this.groupBox1.Controls.Add(this.textBoxBoyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MostPopularBoyLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 199);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boy Names";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBoxGirls);
            this.groupBox2.Controls.Add(this.textBoxGirlName);
            this.groupBox2.Controls.Add(this.MostPopularGirlLabel);
            this.groupBox2.Location = new System.Drawing.Point(166, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 198);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Girl Names";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 312);
            this.Controls.Add(this.checkNames);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelGirls);
            this.Controls.Add(this.labelBoys);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBoys;
        private System.Windows.Forms.Label labelGirls;
        private System.Windows.Forms.Label MostPopularBoyLabel;
        private System.Windows.Forms.Label MostPopularGirlLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkNames;
        private System.Windows.Forms.TextBox textBoxBoyName;
        private System.Windows.Forms.TextBox textBoxGirlName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBoys;
        private System.Windows.Forms.ListBox listBoxGirls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

