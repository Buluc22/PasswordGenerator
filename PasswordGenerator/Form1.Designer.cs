namespace PasswordGenerator
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
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPasswordLength = new TextBox();
            chkIncludeUppercase = new CheckBox();
            chkIncludeLowerCase = new CheckBox();
            chkIncludeNumbers = new CheckBox();
            chkInlcudeSymbols = new CheckBox();
            btnGeneratePassword = new Button();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(60, 102);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(420, 83);
            txtNewPassword.TabIndex = 0;
            txtNewPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(97, 52);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 1;
            label1.Text = "PASSWORD GENERATOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 214);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 2;
            label2.Text = "Password length";
            // 
            // txtPasswordLength
            // 
            txtPasswordLength.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordLength.Location = new Point(260, 206);
            txtPasswordLength.Name = "txtPasswordLength";
            txtPasswordLength.Size = new Size(220, 29);
            txtPasswordLength.TabIndex = 3;
            txtPasswordLength.KeyPress += txtPasswordLength_KeyPress;
            // 
            // chkIncludeUppercase
            // 
            chkIncludeUppercase.AutoSize = true;
            chkIncludeUppercase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeUppercase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludeUppercase.Location = new Point(60, 289);
            chkIncludeUppercase.Name = "chkIncludeUppercase";
            chkIncludeUppercase.Size = new Size(154, 25);
            chkIncludeUppercase.TabIndex = 4;
            chkIncludeUppercase.Text = "Include uppercase";
            chkIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeLowerCase
            // 
            chkIncludeLowerCase.AutoSize = true;
            chkIncludeLowerCase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeLowerCase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludeLowerCase.Location = new Point(60, 341);
            chkIncludeLowerCase.Name = "chkIncludeLowerCase";
            chkIncludeLowerCase.Size = new Size(152, 25);
            chkIncludeLowerCase.TabIndex = 5;
            chkIncludeLowerCase.Text = "Include lowercase";
            chkIncludeLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeNumbers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludeNumbers.Location = new Point(60, 393);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(153, 25);
            chkIncludeNumbers.TabIndex = 6;
            chkIncludeNumbers.Text = "Include numbers  ";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // chkInlcudeSymbols
            // 
            chkInlcudeSymbols.AutoSize = true;
            chkInlcudeSymbols.CheckAlign = ContentAlignment.MiddleRight;
            chkInlcudeSymbols.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkInlcudeSymbols.Location = new Point(60, 445);
            chkInlcudeSymbols.Name = "chkInlcudeSymbols";
            chkInlcudeSymbols.Size = new Size(153, 25);
            chkInlcudeSymbols.TabIndex = 7;
            chkInlcudeSymbols.Text = "Include symbols   ";
            chkInlcudeSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.BackColor = Color.Coral;
            btnGeneratePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneratePassword.ForeColor = Color.White;
            btnGeneratePassword.Location = new Point(302, 314);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(121, 104);
            btnGeneratePassword.TabIndex = 8;
            btnGeneratePassword.Text = "Generate";
            btnGeneratePassword.UseVisualStyleBackColor = false;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(528, 522);
            Controls.Add(btnGeneratePassword);
            Controls.Add(chkInlcudeSymbols);
            Controls.Add(chkIncludeNumbers);
            Controls.Add(chkIncludeLowerCase);
            Controls.Add(chkIncludeUppercase);
            Controls.Add(txtPasswordLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private TextBox txtPasswordLength;
        private CheckBox chkIncludeUppercase;
        private CheckBox chkIncludeLowerCase;
        private CheckBox chkIncludeNumbers;
        private CheckBox chkInlcudeSymbols;
        private Button btnGeneratePassword;
    }
}