namespace DataBaseLoginSystemDemo
{
    partial class LogInSystemDemo
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
            this.CreateAccount = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAccount
            // 
            this.CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccount.Location = new System.Drawing.Point(20, 20);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(262, 80);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // LogIn
            // 
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogIn.Location = new System.Drawing.Point(302, 20);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(262, 80);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // LogInSystemDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 120);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.CreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 159);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 159);
            this.Name = "LogInSystemDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInSystemDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button LogIn;
    }
}

