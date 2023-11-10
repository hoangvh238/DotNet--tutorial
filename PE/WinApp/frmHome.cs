using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTUniversityWinApp
{
    public partial class frmHome : Form
    {
        PeDB pe = new PeDB();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        public void LoadAll()
        {
            var list = pe.Doctors.ToList();
            dgvDoctor.DataSource = list;
            var listChoice = pe.Specializations.ToList();
            cmbSpec.DataSource = listChoice;
            cmbSpec.ValueMember = "SpecializationName";
            txtDocID.Enabled = false;
        }

        public void LoadData()
        {
            int index = dgvDoctor.CurrentCell.RowIndex;
            var dummy = (Doctor)dgvDoctor.Rows[index].DataBoundItem;
            if (dummy != null)
            {
                txtDocID.Text = dummy.DoctorID.ToString();
                txtName.Text = dummy.DoctorName.ToString();
                txtAdr.Text = dummy.Address.ToString();
            }

        }
        private void txtSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                MessageBox.Show("Not null name");
                return;
            }
            if (txtAdr.Text == null)
            {
                MessageBox.Show("Not null Adress");
                return;
            }
            Specialization specialization = (Specialization)cmbSpec.SelectedItem;
            int index = dgvDoctor.CurrentCell.RowIndex;
            var dummy = (Doctor)dgvDoctor.Rows[index].DataBoundItem;
            if (dummy != null)
            {
                dummy.Address = txtAdr.Text;
                dummy.DoctorName = txtName.Text;
                dummy.SpecializationID = specialization.SpecializationID;
            }


            pe.Doctors.Update(dummy);
            pe.SaveChanges();
            LoadAll();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Specialization specialization = (Specialization)cmbSpec.SelectedItem;
            Doctor doctor = new Doctor()
            {
                DoctorName = txtName.Text,
                SpecializationID = specialization.SpecializationID,
                Address = txtAdr.Text,
            };
            pe.Doctors.Add(doctor);
            pe.SaveChanges();
            LoadAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvDoctor.CurrentCell.RowIndex;
            var dummy = (Doctor)dgvDoctor.Rows[index].DataBoundItem;
            

            pe.Doctors.Remove(dummy);
            pe.SaveChanges();
            LoadAll();
        }
    }
}
