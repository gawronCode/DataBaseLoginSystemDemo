using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLoginSystemDemo
{
    public partial class LogInDemo : Form
    {

        private readonly DataBaseClient _dataBaseClient = new DataBaseClient();

        public LogInDemo()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var logInSystemDemo = new LogInSystemDemo();
            logInSystemDemo.StartPosition = FormStartPosition.CenterScreen;
            logInSystemDemo.FormClosing += delegate { this.Close(); };
            logInSystemDemo.Show();
            this.Hide();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {

            if (_dataBaseClient.LogIn(this.NickTextBox.Text, this.PasswordTextBox.Text, out string message))
            {
                this.OperationInfo.Text = message;
                this.OperationInfo.ForeColor = Color.Lime;
            }
            else
            {
                this.OperationInfo.Text = message;
                this.OperationInfo.ForeColor = Color.Tomato;
            }

            this.OperationInfo.Visible = true;
        }
    }
}
