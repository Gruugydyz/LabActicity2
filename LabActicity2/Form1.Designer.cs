﻿namespace LabActicity2
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ActiveCaptionText;
            btnCashier.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashier.ForeColor = SystemColors.Control;
            btnCashier.Location = new Point(12, 38);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(191, 160);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(328, 108);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(113, 35);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P-?????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 201);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 2;
            label1.Text = "*Click to get a number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 53);
            label2.Name = "label2";
            label2.Size = new Size(241, 40);
            label2.TabIndex = 3;
            label2.Text = "Postion in Queue";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(543, 264);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label1;
        private Label label2;
    }
}