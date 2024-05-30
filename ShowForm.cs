using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ffff
{
    public partial class ShowForm : MaterialForm
    {
        public ShowForm()
        {
            InitializeComponent();
            LoadData();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        public void LoadData()
        {
            using (var context = new TripContext())
            {
                dataGridView1.DataSource = context.Trips.ToList();
            }
        }


        private void DeleteButt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var username = selectedRow.Cells["Login"].Value.ToString();

                using (var context = new TripContext())
                {
                    var user = context.Trips.FirstOrDefault(u => u.Login == username);

                    if (user != null)
                    {
                        context.Trips.Remove(user);
                        context.SaveChanges();
                    }
                }

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButt_Click(object sender, EventArgs e)
        {
            using (var context = new TripContext())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string login = row.Cells["Login"].Value.ToString();
                        string city = row.Cells["City"].Value.ToString();
                        string price = row.Cells["Price"].Value.ToString();

                        var existingTrip = context.Trips.FirstOrDefault(t => t.Id == id);
                        if (existingTrip != null)
                        {
                            existingTrip.Login = login;
                            existingTrip.City = city;
                            existingTrip.Price = price;
                        }
                        else
                        {
                            Trip trip = new Trip
                            {
                                Id = id,
                                Login = login,
                                City = city
                            };
                            context.Trips.Add(trip);
                        }
                    }
                }


                context.SaveChanges();
            }
        }

    }
}
