namespace InsuranceRatingUI
{
    partial class MainForm
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
            btnRate = new Button();
            txtPolicy = new RichTextBox();
            lblRating = new Label();
            lblValue = new Label();
            SuspendLayout();
            // 
            // btnRate
            // 
            btnRate.Location = new Point(60, 12);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(75, 23);
            btnRate.TabIndex = 0;
            btnRate.Text = "Rate!";
            btnRate.UseVisualStyleBackColor = true;
            btnRate.Click += btnRate_Click;
            // 
            // richTextBox1
            // 
            txtPolicy.Location = new Point(12, 55);
            txtPolicy.Name = "richTextBox1";
            txtPolicy.Size = new Size(172, 286);
            txtPolicy.TabIndex = 1;
            txtPolicy.Text = "";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(16, 365);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(71, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "Your rating: ";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(93, 365);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(0, 15);
            lblValue.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 506);
            Controls.Add(lblValue);
            Controls.Add(lblRating);
            Controls.Add(txtPolicy);
            Controls.Add(btnRate);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRate;
        private RichTextBox txtPolicy;
        private Label lblRating;
        private Label lblValue;
    }
}
