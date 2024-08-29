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
            btnHelp = new Button();
            btnImport = new Button();
            SuspendLayout();
            // 
            // btnRate
            // 
            btnRate.Location = new Point(158, 12);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(75, 23);
            btnRate.TabIndex = 0;
            btnRate.Text = "Rate!";
            btnRate.UseVisualStyleBackColor = true;
            btnRate.Click += btnRate_Click;
            // 
            // txtPolicy
            // 
            txtPolicy.Location = new Point(12, 55);
            txtPolicy.Name = "txtPolicy";
            txtPolicy.Size = new Size(373, 307);
            txtPolicy.TabIndex = 1;
            txtPolicy.Text = "";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(12, 381);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(71, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "Your rating: ";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(89, 381);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(35, 15);
            lblValue.TabIndex = 3;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(310, 480);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Need help?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(12, 480);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 5;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 506);
            Controls.Add(btnImport);
            Controls.Add(btnHelp);
            Controls.Add(lblValue);
            Controls.Add(lblRating);
            Controls.Add(txtPolicy);
            Controls.Add(btnRate);
            Name = "MainForm";
            Text = "Welcome to my rating engine!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRate;
        private RichTextBox txtPolicy;
        private Label lblRating;
        private Label lblValue;
        private Button btnHelp;
        private Button btnImport;
    }
}
