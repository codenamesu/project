using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using login.DIalog;

namespace login
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        MainForm mainForm;
        Login login;
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            mainForm = new MainForm();
            mainForm.Show();
            login = new Login();
            login.Close();
        }
    }
}
