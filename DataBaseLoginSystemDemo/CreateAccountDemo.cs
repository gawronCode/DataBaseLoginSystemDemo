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
    public partial class CreateAccountDemo : Form
    {

        private readonly DataBaseClient _dataBaseClient = new DataBaseClient();

        public CreateAccountDemo()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var logInSystemDemo = new LogInSystemDemo();
            logInSystemDemo.StartPosition = FormStartPosition.CenterScreen;
            logInSystemDemo.FormClosing += delegate { this.Close(); };
            logInSystemDemo.Show();
            this.Hide();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {

            if (_dataBaseClient.AddAccount(this.FirstName.Text, this.LastName.Text, this.Email.Text, this.Nick.Text,
                this.Password.Text, out string message))
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
