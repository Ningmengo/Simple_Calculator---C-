
namespace WindowsFormsApp2
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
            this.LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBL.Location = new System.Drawing.Point(43, 117);
            this.LBL.MaximumSize = new System.Drawing.Size(500, 300);
            this.LBL.MinimumSize = new System.Drawing.Size(200, 100);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(492, 100);
            this.LBL.TabIndex = 0;
            this.LBL.Text = "This calculator can be operated as a normal caculartor, the only limitation of th" +
    "at is it can only handle 2 values at the same time.";
            this.LBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //this.LBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 351);
            this.Controls.Add(this.LBL);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL;
    }
}