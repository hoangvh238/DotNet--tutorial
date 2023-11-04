using BussinessObject;
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

namespace NewsWinApp
{
    public partial class frmNewsDetail : Form
    {
        NewsRepository newRepository = new NewsRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        UserRepository UserRepository = new UserRepository();
        public bool CreateOrUpdate { get; set; } //update = true 
        public News News { get; set; }
        public frmNewsDetail()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            txtTitle.Text = null;
            txtDepcriptions.Text = null;
            cmbCategory.SelectedIndex = 0;

        }
        public void RenderDropListCate()
        {
            List<String> choice = new List<string>();
            cmbCategory.Items.Clear();

            var list = CategoriesDAO.Instance.GetCategories();

            foreach (Categories cate in list)
            {
                cmbCategory.Items.Add(cate.Name);
            }

        }

        public int GetCateIndex()
        {
            var list = CategoriesDAO.Instance.GetCategories();
            int index = 0;
            foreach (var item in list)
            {
                if (item.CatetoryID == News.CatetoryID) return index;
                index++;
            }
            return index;
        }
        private void frmNewsDetail_Load(object sender, EventArgs e)
        {

            RenderDropListCate();
            if (CreateOrUpdate)
            {
                btnUpdateOrCreate.Text = "Update";
                txtTitle.Text = News.Titles;
                txtDepcriptions.Text = News.Description;
                cmbCategory.SelectedIndex = GetCateIndex();
                ckbStatus.Checked = News.Status;

            }
            else btnUpdateOrCreate.Text = "Create";

        }

        private Users GetUser()
        {
            return UserRepository.GetUser("pika", "123");
        }

        private Categories GetCategoriesByName(string name)
        {
            return categoryRepository.GetCategory(name);
        }
        private void btnUpdateOrCreate_Click(object sender, EventArgs e)
        {
            if(CreateOrUpdate)
            {
                News.Status = ckbStatus.Checked;
                News.Description = txtDepcriptions.Text;
                News.Titles = txtTitle.Text;
                News.DateUpdate = DateTime.Now;
                Categories cate = GetCategoriesByName(cmbCategory.Text);
                News.Categories = cate;
                News.CatetoryID = cate.CatetoryID;
               
                newRepository.UpdateNews(News);
                
            }
            else
            {
                News.Status = ckbStatus.Checked;
                News.Description = txtDepcriptions.Text;
                News.Titles = txtTitle.Text;
                News.DateUpdate = DateTime.Now;

                Users user = GetUser();
                News.Users = user;
                News.UserId = user.UserId;
                Categories cate = GetCategoriesByName(cmbCategory.Text);
                News.Categories = cate;
                News.CatetoryID = cate.CatetoryID;
                newRepository.AddNews(News);
            }
        }
    }
}
