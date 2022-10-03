namespace WindowsFormsApp2
{
    partial class FormCalculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.btnDeleteLastDigit = new System.Windows.Forms.Button();
            this.btnOfRoot = new System.Windows.Forms.Button();
            this.btnToOpposite = new System.Windows.Forms.Button();
            this.btnDeleteAllDigit = new System.Windows.Forms.Button();
            this.btnDeleteLastNum = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditStrip,
            this.HelpStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditStrip
            // 
            this.EditStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyStrip,
            this.PasteStrip});
            this.EditStrip.Name = "EditStrip";
            this.EditStrip.Size = new System.Drawing.Size(49, 24);
            this.EditStrip.Text = "Edit";
            
            // 
            // CopyStrip
            // 
            this.CopyStrip.Name = "CopyStrip";
            this.CopyStrip.Size = new System.Drawing.Size(224, 26);
            this.CopyStrip.Text = "Copy";
            this.CopyStrip.Click += new System.EventHandler(this.CopyStrip_Click);
            // 
            // PasteStrip
            // 
            this.PasteStrip.Name = "PasteStrip";
            this.PasteStrip.Size = new System.Drawing.Size(224, 26);
            this.PasteStrip.Text = "Paste";
            this.PasteStrip.Click += new System.EventHandler(this.PasteStrip_Click);
            // 
            // HelpStrip
            // 
            this.HelpStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStrip});
            this.HelpStrip.Name = "HelpStrip";
            this.HelpStrip.Size = new System.Drawing.Size(55, 24);
            this.HelpStrip.Text = "Help";
           
            // 
            // AboutStrip
            // 
            this.AboutStrip.Name = "AboutStrip";
            this.AboutStrip.Size = new System.Drawing.Size(224, 26);
            this.AboutStrip.Text = "About";
            this.AboutStrip.Click += new System.EventHandler(this.AboutStrip_Click);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TextBox.Location = new System.Drawing.Point(37, 48);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox.MaximumSize = new System.Drawing.Size(321, 110);
            this.TextBox.MinimumSize = new System.Drawing.Size(321, 110);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(321, 110);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
           
            // 
            // btnDeleteLastDigit
            // 
            this.btnDeleteLastDigit.Location = new System.Drawing.Point(16, 203);
            this.btnDeleteLastDigit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteLastDigit.Name = "btnDeleteLastDigit";
            this.btnDeleteLastDigit.Size = new System.Drawing.Size(55, 49);
            this.btnDeleteLastDigit.TabIndex = 2;
            this.btnDeleteLastDigit.Text = "<=";
            this.btnDeleteLastDigit.UseVisualStyleBackColor = true;
            this.btnDeleteLastDigit.Click += new System.EventHandler(this.btnDeleteLastDigit_Click);
            // 
            // btnOfRoot
            // 
            this.btnOfRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOfRoot.Location = new System.Drawing.Point(333, 202);
            this.btnOfRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOfRoot.Name = "btnOfRoot";
            this.btnOfRoot.Size = new System.Drawing.Size(55, 49);
            this.btnOfRoot.TabIndex = 3;
            this.btnOfRoot.Text = "√";
            this.btnOfRoot.UseVisualStyleBackColor = true;
            this.btnOfRoot.Click += new System.EventHandler(this.btnOfRoot_Click);
            // 
            // btnToOpposite
            // 
            this.btnToOpposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToOpposite.Location = new System.Drawing.Point(252, 203);
            this.btnToOpposite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToOpposite.Name = "btnToOpposite";
            this.btnToOpposite.Size = new System.Drawing.Size(55, 49);
            this.btnToOpposite.TabIndex = 4;
            this.btnToOpposite.Text = "+/-";
            this.btnToOpposite.UseVisualStyleBackColor = true;
            this.btnToOpposite.Click += new System.EventHandler(this.btnToOpposite_Click);
            // 
            // btnDeleteAllDigit
            // 
            this.btnDeleteAllDigit.Location = new System.Drawing.Point(175, 203);
            this.btnDeleteAllDigit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAllDigit.Name = "btnDeleteAllDigit";
            this.btnDeleteAllDigit.Size = new System.Drawing.Size(55, 49);
            this.btnDeleteAllDigit.TabIndex = 5;
            this.btnDeleteAllDigit.Text = "C";
            this.btnDeleteAllDigit.UseVisualStyleBackColor = true;
            this.btnDeleteAllDigit.Click += new System.EventHandler(this.btnDeleteAllDigit_Click);
            // 
            // btnDeleteLastNum
            // 
            this.btnDeleteLastNum.Location = new System.Drawing.Point(97, 203);
            this.btnDeleteLastNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteLastNum.Name = "btnDeleteLastNum";
            this.btnDeleteLastNum.Size = new System.Drawing.Size(55, 49);
            this.btnDeleteLastNum.TabIndex = 6;
            this.btnDeleteLastNum.Text = "CE";
            this.btnDeleteLastNum.UseVisualStyleBackColor = true;
            this.btnDeleteLastNum.Click += new System.EventHandler(this.btnDeleteLastNum_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 276);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 49);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDivide.Location = new System.Drawing.Point(252, 276);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 49);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(175, 276);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 49);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 346);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 49);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(97, 276);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 49);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSquare.Location = new System.Drawing.Point(331, 276);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(55, 49);
            this.btnSquare.TabIndex = 12;
            this.btnSquare.Text = "x*x";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(175, 346);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 49);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(97, 346);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 49);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFraction.Location = new System.Drawing.Point(331, 346);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(55, 49);
            this.btnFraction.TabIndex = 15;
            this.btnFraction.Text = "1/x";
            this.btnFraction.UseVisualStyleBackColor = true;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnTimes.Location = new System.Drawing.Point(252, 346);
            this.btnTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(55, 49);
            this.btnTimes.TabIndex = 16;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 416);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 49);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDot.Location = new System.Drawing.Point(175, 487);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(55, 49);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMinus.Location = new System.Drawing.Point(252, 416);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(55, 49);
            this.btnMinus.TabIndex = 19;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(175, 416);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 49);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 416);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 49);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPlus.Location = new System.Drawing.Point(252, 487);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(55, 49);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 487);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 49);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEqual.Location = new System.Drawing.Point(331, 416);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(55, 121);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 578);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDeleteLastNum);
            this.Controls.Add(this.btnDeleteAllDigit);
            this.Controls.Add(this.btnToOpposite);
            this.Controls.Add(this.btnOfRoot);
            this.Controls.Add(this.btnDeleteLastDigit);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyStrip;
        private System.Windows.Forms.ToolStripMenuItem PasteStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutStrip;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button btnDeleteLastDigit;
        private System.Windows.Forms.Button btnOfRoot;
        private System.Windows.Forms.Button btnToOpposite;
        private System.Windows.Forms.Button btnDeleteAllDigit;
        private System.Windows.Forms.Button btnDeleteLastNum;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
    }
}

