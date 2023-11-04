using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        string role = SessionManager.Instance.Get("role") as string;
        public frmMember()
        {
            InitializeComponent();
        }
        IMemberRepository resm = new MemberRepository();
        public void loadMemberList()
        {
            var list = resm.GetMembers();
            BindingSource source = new BindingSource();
            source.DataSource = list;

            dgvMember.DataSource = null;
            dgvMember.DataSource = list;
        }

        public void loadMemberListUser()
        {
            int? id = SessionManager.Instance.Get("id") as int?;
            MessageBox.Show(""+ id.Value);
            if (id.HasValue)
            {
                var users = new List<object> { resm.GetMemberID(id.Value ) };
                BindingSource source = new BindingSource();
                source.DataSource = users;

                dgvMember.DataSource = null;
                dgvMember.DataSource = users;
            }


        }

        public Member GetMember()
        {
            Member member = null;
            try
            {
                int index = dgvMember.CurrentCell.RowIndex;
                var dummy = (Member)dgvMember.Rows[index].DataBoundItem;
                member = resm.GetMemberID(dummy.MemberId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return member;
        }

        public void ClearText()
        {
            txtMemberID.Text = "";
            txtCmName.Text = "";

        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            string role = SessionManager.Instance.Get("role") as string;

            if (role.Equals("admin")) loadMemberList();

            else
            {
                loadMemberListUser();
                lbCompanyName.Hide();
                lbMemberID.Hide();
                btnCreate.Hide();
                btnDelete.Hide();
                txtCmName.Hide();
                txtMemberID.Hide();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Create Member",
                InsertOrUpdate = false,
                MRepository = resm,
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Member Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var memberID = GetMember();
                resm.DeleteMember(memberID);
                loadMemberList();
            }
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var memberID = resm.GetMemberID(int.Parse(txtMemberID.Text));
                BindingSource source = new BindingSource();
                source.DataSource = memberID;
                dgvMember.DataSource = null;
                dgvMember.DataSource = source;

            }
            catch (Exception ex) { }
        }

        private void txtCmName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cmName = resm.GetCompanyName(txtCmName.Text);
                BindingSource source = new BindingSource();
                source.DataSource = cmName;
                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
            }
            catch (Exception ex) { }
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfor = GetMember(),
                MRepository = resm,
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();
            }
        }



        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfor = GetMember(),
                MRepository = resm,
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();
            }
        }
    }
}
