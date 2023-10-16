using AutomobileLibrary.BussinessObjects;
using AutomobileLibrary.Reponsitory;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // False insert -- true update

        public Car CarInfo { get; set; }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //update
            {
                txtCarID.Text = CarInfo.CarId.ToString();
                txtCarName.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarId = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };

                if (InsertOrUpdate == true) CarRepository.UpdateCar(car);
                else CarRepository.InsertCar(car);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == true ? "Update a car" : "Insert new car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        
    }

}