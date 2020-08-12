using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsr7.data;
using System.Data.Entity;
using wsr7.Data;

namespace wsr7.Forms.EntitiesForms
{
    public partial class EarthesForm : Form
    {
        public EarthesForm()
        {
            InitializeComponent();
            refreshGrid("");
        }

        void refreshGrid(string filter)
        {
            grid_earthes.Rows.Clear();
            List<Earth> earthes;
            if (filter == "")
                earthes = ModelContext.init().Earths.Include(e => e.Realty).ToList();
            else
                earthes = ModelContext.init().Earths.Include(e => e.Realty).AsEnumerable().Where(c => new LengthLevensht.LengthLevensht(c.Realty.Address_City, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_Street, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_House, filter).getItog() <= 1 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_Number, filter).getItog() <= 1).
                    ToList();
            foreach (Earth e in earthes)
            {
                int r = grid_earthes.Rows.Add(e.Realty_ID, e.TotalArea, e.Realty.Address_City, e.Realty.Address_Street, e.Realty.Address_House, e.Realty.Address_Number, e.Realty.Coordinate_latitude, e.Realty.Coordinate_longitude);
                grid_earthes.Rows[r].Tag = e;
            }
        }

        private bool ReallyDoIt()
        {
            var result = MessageBox.Show("Вы уверены, что хотите совершить это действие?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return false;
            return true;
        }

        private void save()
        {
            ModelContext.init().SaveChanges();
            MessageBox.Show("Успешно!");
            refreshGrid("");
        }

        

        private void Fie_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid(Fie_Search.Text);
        }

        private void But_Dell_Click(object sender, EventArgs e)
        {
            if (grid_earthes.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Earth cl = grid_earthes.SelectedRows[0].Tag as Earth;
            if (cl.Realty.Supplies.Count() > 0)
            {
                MessageBox.Show("Невозможно удалить, т.к. объект связан с предложением");
                return;
            }
            ModelContext.init().Realties.Remove(cl.Realty);
            save();
        }

        private void but_prev_Click(object sender, EventArgs e)
        {
            managers.ManagerForms.ChangeForm(new MainForm());
        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            double ploshad, shirota, dolgota;
            if((!double.TryParse(fie_add_ploshad.Text, out ploshad) && fie_add_ploshad.Text != "") || (!double.TryParse(fie_add_shirota.Text, out shirota) && fie_add_shirota.Text != "") || (!double.TryParse(fie_add_dolgota.Text, out dolgota) && fie_add_dolgota.Text != ""))
            {
                MessageBox.Show("Некорректные значения!");
                return;
            }
            if(shirota < -90 || shirota > 90)
            {
                MessageBox.Show("Широта от -90 до 90!");
                return;
            }
            if (dolgota < -180 || dolgota > 180)
            {
                MessageBox.Show("Долгота от -180 до 180!");
                return;
            }
            if (!ReallyDoIt())
                return;
            Earth ear = new Earth
            {
                Realty = new Realty
                {
                    Address_City = fie_add_city.Text,
                    Address_House = fie_add_house.Text,
                    Address_Number = fie_add_flat.Text,
                    Address_Street = fie_add_street.Text,
                    Coordinate_latitude = shirota,
                    Coordinate_longitude = dolgota
                },
                TotalArea = ploshad
            };
            ModelContext.init().Earths.Add(ear);
            save();
        }

        private void But_Edit_Click(object sender, EventArgs e)
        {
            if (grid_earthes.SelectedRows.Count != 1)
                return;
            double ploshad, shirota, dolgota;
            if ((!double.TryParse(fie_edit_area.Text, out ploshad) && fie_edit_area.Text != "") || (!double.TryParse(fie_edit_shirota.Text, out shirota) && fie_edit_shirota.Text != "") || (!double.TryParse(fie_edit_dolgota.Text, out dolgota) && fie_edit_dolgota.Text != ""))
            {
                MessageBox.Show("Некорректные значения!");
                return;
            }
            if (shirota < -90 || shirota > 90)
            {
                MessageBox.Show("Широта от -90 до 90!");
                return;
            }
            if (dolgota < -180 || dolgota > 180)
            {
                MessageBox.Show("Долгота от -180 до 180!");
                return;
            }
            if (!ReallyDoIt())
                return;
            Earth cl = grid_earthes.SelectedRows[0].Tag as Earth;
            cl.Realty.Address_City = fie_edit_city.Text;
            cl.Realty.Address_House = fie_edit_house.Text;
            cl.Realty.Address_Number = fie_edit_flat.Text;
            cl.Realty.Address_Street = fie_edit_street.Text;
            cl.Realty.Coordinate_latitude = shirota;
            cl.Realty.Coordinate_longitude = dolgota;
            cl.TotalArea = ploshad;
            save();
        }

        private void fie_add_flat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_earthes.SelectedRows.Count != 1)
                return;
            Earth cl = grid_earthes.SelectedRows[0].Tag as Earth;
            fie_edit_area.Text = cl.TotalArea.ToString();
            fie_edit_city.Text = cl.Realty.Address_City;
            fie_edit_dolgota.Text = cl.Realty.Coordinate_longitude.ToString();
            fie_edit_flat.Text = cl.Realty.Address_Number;
            fie_edit_house.Text = cl.Realty.Address_House;
            fie_edit_shirota.Text = cl.Realty.Coordinate_latitude.ToString();
            fie_edit_street.Text = cl.Realty.Address_Street;
        }
    }
}
