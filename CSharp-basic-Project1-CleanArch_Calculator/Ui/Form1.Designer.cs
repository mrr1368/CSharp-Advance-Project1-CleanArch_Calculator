namespace CSharp_basic_Project1_CleanArch_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInput = new TextBox();
            txtResult = new TextBox();
            btn0 = new Button();
            btn00 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDel = new Button();
            btnRemove = new Button();
            btnEqual = new Button();
            btnSum = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Gray;
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Enabled = false;
            txtInput.Font = new Font("Tahoma", 20F);
            txtInput.Location = new Point(12, 14);
            txtInput.MaxLength = 15;
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(378, 57);
            txtInput.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Gray;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Tahoma", 20F);
            txtResult.Location = new Point(12, 71);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(378, 57);
            txtResult.TabIndex = 1;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gray;
            btn0.FlatAppearance.BorderColor = Color.DimGray;
            btn0.FlatAppearance.BorderSize = 2;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Tahoma", 12F);
            btn0.Location = new Point(12, 457);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 71);
            btn0.TabIndex = 3;
            btn0.TabStop = false;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            btn00.BackColor = Color.Gray;
            btn00.FlatAppearance.BorderColor = Color.DimGray;
            btn00.FlatAppearance.BorderSize = 2;
            btn00.FlatStyle = FlatStyle.Flat;
            btn00.Font = new Font("Tahoma", 12F);
            btn00.Location = new Point(108, 457);
            btn00.Name = "btn00";
            btn00.Size = new Size(90, 71);
            btn00.TabIndex = 4;
            btn00.TabStop = false;
            btn00.Tag = "00";
            btn00.Text = "00";
            btn00.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Gray;
            btnMinus.FlatAppearance.BorderColor = Color.DimGray;
            btnMinus.FlatAppearance.BorderSize = 2;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Tahoma", 12F);
            btnMinus.Location = new Point(204, 457);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 71);
            btnMinus.TabIndex = 5;
            btnMinus.TabStop = false;
            btnMinus.Tag = ".";
            btnMinus.Text = ".";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatAppearance.BorderColor = Color.DimGray;
            btn1.FlatAppearance.BorderSize = 2;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Tahoma", 12F);
            btn1.Location = new Point(12, 380);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 71);
            btn1.TabIndex = 6;
            btn1.TabStop = false;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatAppearance.BorderColor = Color.DimGray;
            btn2.FlatAppearance.BorderSize = 2;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Tahoma", 12F);
            btn2.Location = new Point(108, 380);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 71);
            btn2.TabIndex = 7;
            btn2.TabStop = false;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.FlatAppearance.BorderColor = Color.DimGray;
            btn3.FlatAppearance.BorderSize = 2;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Tahoma", 12F);
            btn3.Location = new Point(204, 380);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 71);
            btn3.TabIndex = 8;
            btn3.TabStop = false;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.FlatAppearance.BorderColor = Color.DimGray;
            btn4.FlatAppearance.BorderSize = 2;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Tahoma", 12F);
            btn4.Location = new Point(12, 303);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 71);
            btn4.TabIndex = 9;
            btn4.TabStop = false;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.FlatAppearance.BorderColor = Color.DimGray;
            btn5.FlatAppearance.BorderSize = 2;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Tahoma", 12F);
            btn5.Location = new Point(108, 303);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 71);
            btn5.TabIndex = 10;
            btn5.TabStop = false;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.FlatAppearance.BorderColor = Color.DimGray;
            btn6.FlatAppearance.BorderSize = 2;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Tahoma", 12F);
            btn6.Location = new Point(204, 303);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 71);
            btn6.TabIndex = 11;
            btn6.TabStop = false;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.FlatAppearance.BorderColor = Color.DimGray;
            btn7.FlatAppearance.BorderSize = 2;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Tahoma", 12F);
            btn7.Location = new Point(12, 226);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 71);
            btn7.TabIndex = 12;
            btn7.TabStop = false;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.FlatAppearance.BorderColor = Color.DimGray;
            btn8.FlatAppearance.BorderSize = 2;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Tahoma", 12F);
            btn8.Location = new Point(108, 226);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 71);
            btn8.TabIndex = 13;
            btn8.TabStop = false;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.FlatAppearance.BorderColor = Color.DimGray;
            btn9.FlatAppearance.BorderSize = 2;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Tahoma", 12F);
            btn9.Location = new Point(204, 226);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 71);
            btn9.TabIndex = 14;
            btn9.TabStop = false;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.DimGray;
            btnDel.FlatAppearance.BorderColor = Color.Black;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Tahoma", 12F);
            btnDel.Location = new Point(204, 149);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(90, 71);
            btnDel.TabIndex = 16;
            btnDel.TabStop = false;
            btnDel.Tag = "DEL";
            btnDel.Text = "C";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DimGray;
            btnRemove.FlatAppearance.BorderColor = Color.Black;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Tahoma", 18F);
            btnRemove.Location = new Point(12, 149);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(186, 71);
            btnRemove.TabIndex = 17;
            btnRemove.TabStop = false;
            btnRemove.Tag = "BACK";
            btnRemove.Text = "⌫";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.DimGray;
            btnEqual.FlatAppearance.BorderColor = Color.Black;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Tahoma", 12F);
            btnEqual.Location = new Point(300, 457);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 71);
            btnEqual.TabIndex = 18;
            btnEqual.TabStop = false;
            btnEqual.Tag = "ENTER";
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.DimGray;
            btnSum.FlatAppearance.BorderColor = Color.Black;
            btnSum.FlatStyle = FlatStyle.Flat;
            btnSum.Font = new Font("Tahoma", 12F);
            btnSum.Location = new Point(300, 380);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(90, 71);
            btnSum.TabIndex = 19;
            btnSum.TabStop = false;
            btnSum.Tag = "+";
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.DimGray;
            btnSub.FlatAppearance.BorderColor = Color.Black;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Tahoma", 12F);
            btnSub.Location = new Point(300, 303);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(90, 71);
            btnSub.TabIndex = 20;
            btnSub.TabStop = false;
            btnSub.Tag = "-";
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.DimGray;
            btnMul.FlatAppearance.BorderColor = Color.Black;
            btnMul.FlatStyle = FlatStyle.Flat;
            btnMul.Font = new Font("Tahoma", 12F);
            btnMul.Location = new Point(300, 226);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(90, 71);
            btnMul.TabIndex = 21;
            btnMul.TabStop = false;
            btnMul.Tag = "*";
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.DimGray;
            btnDiv.FlatAppearance.BorderColor = Color.Black;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Tahoma", 12F);
            btnDiv.Location = new Point(300, 149);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 71);
            btnDiv.TabIndex = 22;
            btnDiv.TabStop = false;
            btnDiv.Tag = "/";
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(403, 539);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnSum);
            Controls.Add(btnEqual);
            Controls.Add(btnRemove);
            Controls.Add(btnDel);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn00);
            Controls.Add(btn0);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CleanArch_Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtResult;
        private Button btn0;
        private Button btn00;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDel;
        private Button btnRemove;
        private Button btnEqual;
        private Button btnSum;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}
