using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);
            var adminAccount = JsonSerializer.Deserialize<DefaultAccount>(json, new JsonSerializerOptions());
            string emailA = adminAccount.Email;
            string passwordA = adminAccount.Password;

            MessageBox.Show(passwordA);

            if (txtEmail.Text.Equals(emailA) && txtPassword.Text.Equals(passwordA))
            {
                frmMain frmMain = new frmMain
                {
                    User = new UserBase
                    {
                        UserID = -1,
                        Role = "ADMIN"
                    }

                };
                frmMain.ShowDialog();
                Close();
            }
           

            IMemberRepository memberRepository = new MemberRepository();

            var memeber = memberRepository.GetMember(txtEmail.Text, txtPassword.Text);

            if (memeber == null)
            {
                MessageBox.Show("Incorrect email or password");
                return;
            }

            frmUserMain frmUserMain = new frmUserMain
            {
                User = new UserBase
                {
                    UserID = memeber.MemberId,
                    Role = "USER"
                }

            };
            frmUserMain.ShowDialog();
            Close();



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
