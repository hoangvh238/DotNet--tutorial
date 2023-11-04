using BussinessObject.Repository;
using Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewsWinApp
{
    //ctrl k+uu undo code comment 
    public partial class frmHome : Form
    {
        NewsRepository newsRepository = new NewsRepository();
        PeDB pe = new PeDB();
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            var listCate = pe.Categories.ToList();
            var list = newsRepository.GetAllNews();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            dgvNews.DataSource = bindingSource;
            cmbStudent.DataSource = listCate;
            cmbStudent.DisplayMember = "Name";
        

        }

        public News GetNews()
        {
            News news = null;
            try
            {
                int index = dgvNews.CurrentCell.RowIndex;
                var dummy = (News)dgvNews.Rows[index].DataBoundItem;
                news = newsRepository.GetNewsById(dummy.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return news;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try
            {
                Categories newCate = (Categories)cmbStudent.SelectedItem;
                Categories addCate = new Categories
                {
                    Name = "asdada",
                    Status = newCate.Status,
                };
                pe.Categories.Add(addCate);
                MessageBox.Show("thanh cong" + addCate.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //frmnewsdetail frmnewsdetail = new frmnewsdetail()
            //{

            //    createorupdate = false,
            //};
            //frmnewsdetail.showdialog();

        }

        private void dgvNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmNewsDetail frmNewsDetail = new frmNewsDetail()
            {
                News = GetNews(),
                CreateOrUpdate = true,
            };
            frmNewsDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvNews.CurrentCell.RowIndex;
            var dummy = (News)dgvNews.Rows[index].DataBoundItem;
            newsRepository.DeleteNews(dummy);
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categories selectedPerson = (Categories)cmbStudent.SelectedItem;
            MessageBox.Show("Bạn đã chọn: " + selectedPerson.CatetoryID);
        }
    }
}
