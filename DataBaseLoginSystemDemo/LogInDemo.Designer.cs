namespace DataBaseLoginSystemDemo
{
    partial class LogInDemo
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
            System.Windows.Forms.Button LogIn;
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OperationInfo = new System.Windows.Forms.Label();
            LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            LogIn.Location = new System.Drawing.Point(302, 117);
            LogIn.Name = "LogIn";
            LogIn.Size = new System.Drawing.Size(262, 80);
            LogIn.TabIndex = 3;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // NickTextBox
            // 
            this.NickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NickTextBox.Location = new System.Drawing.Point(20, 20);
            this.NickTextBox.MaxLength = 255;
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(544, 29);
            this.NickTextBox.TabIndex = 0;
            this.NickTextBox.Text = "Nick";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(20, 69);
            this.PasswordTextBox.MaxLength = 255;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(544, 29);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "Password";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cancel.Location = new System.Drawing.Point(20, 117);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(262, 80);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OperationInfo
            // 
            this.OperationInfo.AutoSize = true;
            this.OperationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OperationInfo.ForeColor = System.Drawing.Color.Lime;
            this.OperationInfo.Location = new System.Drawing.Point(20, 217);
            this.OperationInfo.Name = "OperationInfo";
            this.OperationInfo.Size = new System.Drawing.Size(173, 20);
            this.OperationInfo.TabIndex = 4;
            this.OperationInfo.Text = "Logged In Successfully";
            this.OperationInfo.Visible = false;
            // 
            // LogInDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.OperationInfo);
            this.Controls.Add(LogIn);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NickTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 296);
            this.Name = "LogInDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label OperationInfo;
    }
}