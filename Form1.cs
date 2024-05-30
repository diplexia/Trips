using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ffff
{
    public partial class Form1 : MaterialForm
    {
        TripContext db;
        public Form1()
        {
            InitializeComponent();
            db = new TripContext();


            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;

            if (db.Trips.Any(trip => trip.Login == username))
            {
                MessageBox.Show("Користувач з таким іменем вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Trip trip = new Trip();
                trip.Login = username;
                trip.City = CityBox.Text;
                trip.Price = PriceBox.Text;

                db.Trips.Add(trip);
                db.SaveChanges();
            }
        }


        private void ShowButt_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm();
            showForm.Show();
            this.Hide();
        }

        private void CityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            UserBox.Text = "";
            CityBox.Text = "";
            PriceBox.Text = "";
        }
    }
}
