using BussinessObject.Repository;
using Data_Access;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsWinApp
{
    public partial class frmLogin : Form
    {
        UserRepository userRepository = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Users user = userRepository.GetUser(txtUserName.Text,txtPassword.Text);
            if(user != null) 
            {
                this.Hide();
                frmHome frm = new frmHome();
             
                frm.ShowDialog();
                this.Close();

            }
            MessageBox.Show("Wrong username or password");

        }
    }
}
