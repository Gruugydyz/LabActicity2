namespace LabActicity2
{
    partial class CustomerView
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblcustomerView = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(135, 27);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblcustomerView
            // 
            lblcustomerView.AutoSize = true;
            lblcustomerView.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcustomerView.Location = new Point(119, 91);
            lblcustomerView.Name = "lblcustomerView";
            lblcustomerView.Size = new Size(162, 49);
            lblcustomerView.TabIndex = 1;
            lblcustomerView.Text = "P-?????";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(396, 215);
            Controls.Add(lblcustomerView);
            Controls.Add(label1);
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblcustomerView;
        private System.Windows.Forms.Timer timer1;
    }
}