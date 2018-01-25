namespace GreenvilleRevenueGUI
{
    partial class greenvilleRevenueGUI
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
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.lastYearInputTextBox = new System.Windows.Forms.TextBox();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.thisYearInputTextBox = new System.Windows.Forms.TextBox();
            this.RevenueOuput = new System.Windows.Forms.Label();
            this.thisVsLastOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.Location = new System.Drawing.Point(12, 54);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(307, 13);
            this.lastYearLabel.TabIndex = 0;
            this.lastYearLabel.Text = "Enter the number of people that entered in last year\'s competion";
            this.lastYearLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastYearInputTextBox
            // 
            this.lastYearInputTextBox.Location = new System.Drawing.Point(325, 51);
            this.lastYearInputTextBox.Name = "lastYearInputTextBox";
            this.lastYearInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearInputTextBox.TabIndex = 1;
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.Location = new System.Drawing.Point(12, 88);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(307, 13);
            this.thisYearLabel.TabIndex = 2;
            this.thisYearLabel.Text = "Enter the number of people that entered in this year\'s competion";
            // 
            // thisYearInputTextBox
            // 
            this.thisYearInputTextBox.Location = new System.Drawing.Point(326, 88);
            this.thisYearInputTextBox.Name = "thisYearInputTextBox";
            this.thisYearInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearInputTextBox.TabIndex = 3;
            // 
            // RevenueOuput
            // 
            this.RevenueOuput.AutoSize = true;
            this.RevenueOuput.Location = new System.Drawing.Point(84, 194);
            this.RevenueOuput.Name = "RevenueOuput";
            this.RevenueOuput.Size = new System.Drawing.Size(86, 13);
            this.RevenueOuput.TabIndex = 4;
            this.RevenueOuput.Text = "Revenue Output";
            // 
            // thisVsLastOutput
            // 
            this.thisVsLastOutput.AutoSize = true;
            this.thisVsLastOutput.Location = new System.Drawing.Point(307, 194);
            this.thisVsLastOutput.Name = "thisVsLastOutput";
            this.thisVsLastOutput.Size = new System.Drawing.Size(175, 13);
            this.thisVsLastOutput.TabIndex = 5;
            this.thisVsLastOutput.Text = "this year or last year revenue output";
            this.thisVsLastOutput.Visible = false;
            // 
            // greenvilleRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 365);
            this.Controls.Add(this.thisVsLastOutput);
            this.Controls.Add(this.RevenueOuput);
            this.Controls.Add(this.thisYearInputTextBox);
            this.Controls.Add(this.thisYearLabel);
            this.Controls.Add(this.lastYearInputTextBox);
            this.Controls.Add(this.lastYearLabel);
            this.Name = "greenvilleRevenueGUI";
            this.Text = "Greenville Revenue GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastYearLabel;
        private System.Windows.Forms.TextBox lastYearInputTextBox;
        private System.Windows.Forms.Label thisYearLabel;
        private System.Windows.Forms.TextBox thisYearInputTextBox;
        private System.Windows.Forms.Label RevenueOuput;
        private System.Windows.Forms.Label thisVsLastOutput;
    }
}

