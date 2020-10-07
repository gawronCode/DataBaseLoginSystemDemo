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
    public partial class LogInSystemDemo : Form
    {
        public LogInSystemDemo()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            var logInDemo = new LogInDemo();
            logInDemo.StartPosition = FormStartPosition.CenterScreen;
            logInDemo.FormClosing += delegate { this.Close(); };
            logInDemo.Show();
            this.Hide();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            var createAccountDemo = new CreateAccountDemo();
            createAccountDemo.StartPosition = FormStartPosition.CenterScreen;
            createAccountDemo.FormClosing += delegate { this.Close(); };
            createAccountDemo.Show();
            this.Hide();
        }
    }
}
