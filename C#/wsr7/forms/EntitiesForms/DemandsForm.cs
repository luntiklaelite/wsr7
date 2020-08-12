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
using wsr7.Data;
using System.Data.Entity;

namespace wsr7.Forms.EntitiesForms
{
    public partial class DemandsForm : Form
    {
        Client client;
        Rieltor rieltor;
        public DemandsForm(Client client = null, Rieltor rieltor = null)
        {
            this.rieltor = rieltor;
            this.client = client;
            InitializeComponent();
            combo_types.SelectedIndex = 2;
            refreshGrid("");
        }

        void refreshGrid(string filter)
        {
            grid_Flats.Rows.Clear();
            grid_Flats.Columns.Clear();
            refreshColumnsGrid();
            List<Demand> demands;
            if (filter == "")
                demands = ModelContext.init().Demands.Include(e => e.Client).Include(e => e.Rieltor).ToList();
            else
                demands = ModelContext.init().Demands.Include(e => e.Client).Include(e => e.Rieltor).AsEnumerable().Where(c => new LengthLevensht.LengthLevensht(c.Address_City, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Address_Street, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Address_House, filter).getItog() <= 1 ||
                    new LengthLevensht.LengthLevensht(c.Address_Number, filter).getItog() <= 1).
                    ToList();
            if (client != null)
                demands = demands.Where(d => d.clientId == client.ID).ToList();
            if (rieltor != null)
                demands = demands.Where(d => d.rieltorId == rieltor.ID).ToList();
            foreach (Demand e in demands)
            {
                if (combo_types.SelectedIndex == 0)
                {
                    if (e.HouseDemand == null)
                        continue;
                    int r = grid_Flats.Rows.Add(e.ID, e.Client.Name, e.Rieltor.Name, e.getAddress(), e.getPrice(), e.HouseDemand.getArea(), e.HouseDemand.getRooms(), e.HouseDemand.getFloors());
                    grid_Flats.Rows[r].Tag = e;
                }
                else if (combo_types.SelectedIndex == 1)
                {
                    if (e.FlatDemand == null)
                        continue;
                    int r = grid_Flats.Rows.Add(e.ID, e.Client.Name, e.Rieltor.Name, e.getAddress(), e.getPrice(), e.FlatDemand.getArea(), e.FlatDemand.getRooms(), e.FlatDemand.getFloors());
                    grid_Flats.Rows[r].Tag = e;
                }
                else
                {
                    if (e.EarthDemand == null)
                        continue;
                    int r = grid_Flats.Rows.Add(e.ID, e.Client.Name, e.Rieltor.Name, e.getAddress(), e.getPrice(), e.EarthDemand.getArea());
                    grid_Flats.Rows[r].Tag = e;
                }
            }
        }

        void refreshColumnsGrid()
        {
            grid_Flats.Columns.Add("ID", "ID");
            grid_Flats.Columns.Add("Клиент", "Клиент");
            grid_Flats.Columns.Add("Риэлтор", "Риэлтор");
            grid_Flats.Columns.Add("Адрес", "Адрес");
            grid_Flats.Columns.Add("Цена", "Цена");

            if (combo_types.SelectedIndex == 0) // дома
            {
                grid_Flats.Columns.Add("Площадь", "Площадь");
                grid_Flats.Columns.Add("Комнаты", "Комнаты");
                grid_Flats.Columns.Add("Этаж", "Этаж");
            }
            else if (combo_types.SelectedIndex == 1) 
            {
                grid_Flats.Columns.Add("Площадь", "Площадь");
                grid_Flats.Columns.Add("Комнаты", "Комнаты");
                grid_Flats.Columns.Add("Этажей", "Этажей");
            }
            else
            {
                grid_Flats.Columns.Add("Площадь", "Площадь");
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

        private void but_prev_Click(object sender, EventArgs e)
        {
            managers.ManagerForms.ChangeForm(new MainForm());
        }

        private void Fie_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid(Fie_Search.Text);
        }

        private void But_Dell_Click(object sender, EventArgs e)
        {
            if (grid_Flats.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Demand cl = grid_Flats.SelectedRows[0].Tag as Demand;
            if(cl.Deal != null)
            {
                MessageBox.Show("Невозможно удалить, т.к. есть связь со сделкой!!");
                return;
            }
            ModelContext.init().Demands.Remove(cl);
            save();
        }

        private void combo_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGrid("");
        }
    }
}
