namespace DataBaseLoginSystemDemo
{
    partial class CreateAccountDemo
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nick = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.OperationInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstName.Location = new System.Drawing.Point(20, 20);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(544, 29);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastName.Location = new System.Drawing.Point(20, 69);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(544, 29);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.Location = new System.Drawing.Point(20, 118);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(544, 29);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Nick
            // 
            this.Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nick.Location = new System.Drawing.Point(20, 167);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(544, 29);
            this.Nick.TabIndex = 3;
            this.Nick.Text = "Nick";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password.Location = new System.Drawing.Point(20, 216);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(544, 29);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // repeatPassword
            // 
            this.repeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repeatPassword.Location = new System.Drawing.Point(20, 265);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(544, 29);
            this.repeatPassword.TabIndex = 5;
            this.repeatPassword.Text = "Repeat Password";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back.Location = new System.Drawing.Point(20, 314);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(262, 80);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccount.Location = new System.Drawing.Point(302, 314);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(262, 80);
            this.CreateAccount.TabIndex = 7;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // OperationInfo
            // 
            this.OperationInfo.AutoSize = true;
            this.OperationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OperationInfo.ForeColor = System.Drawing.Color.Lime;
            this.OperationInfo.Location = new System.Drawing.Point(20, 414);
            this.OperationInfo.Name = "OperationInfo";
            this.OperationInfo.Size = new System.Drawing.Size(221, 20);
            this.OperationInfo.TabIndex = 8;
            this.OperationInfo.Text = "Account Created Successfully";
            this.OperationInfo.Visible = false;
            // 
            // CreateAccountDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.OperationInfo);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 489);
            this.Name = "CreateAccountDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccountDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Label OperationInfo;
    }
}