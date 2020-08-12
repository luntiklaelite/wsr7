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
    public partial class SuppliesForm : Form
    {
        Client client;
        Rieltor rieltor;
        public SuppliesForm(Client client = null, Rieltor rieltor = null)
        {
            this.rieltor = rieltor;
            this.client = client;
            InitializeComponent();
            refreshGrid("");
            fillCombos();
        }

        void fillCombos()
        {
            Client[] clients = ModelContext.init().Clients.ToArray();
            fie_add_client.Items.Clear();
            fie_add_client.Items.AddRange(clients);
            fie_edit_client.Items.Clear();
            fie_edit_client.Items.AddRange(clients);
            Rieltor[] rieltors = ModelContext.init().Rieltors.ToArray();
            fie_add_rieltor.Items.Clear();
            fie_edit_rieltor.Items.Clear();
            fie_add_rieltor.Items.AddRange(rieltors);
            fie_edit_rieltor.Items.AddRange(rieltors);
            Realty[] realties = ModelContext.init().Realties.ToArray();
            fie_add_realty.Items.Clear();
            fie_edit_realty.Items.Clear();
            fie_add_realty.Items.AddRange(realties);
            fie_edit_realty.Items.AddRange(realties);
        }

        void refreshGrid(string filter)
        {
            grid_Flats.Rows.Clear();
            List<Supply> supplies;
            if (filter == "")
                supplies = ModelContext.init().Supplies.Include(e => e.Realty).Include(e => e.rieltor).Include(e => e.client).ToList();
            else
                supplies = ModelContext.init().Supplies.Include(e => e.Realty).Include(e => e.rieltor).Include(e => e.client).AsEnumerable().Where(c => new LengthLevensht.LengthLevensht(c.Realty.Address_City, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_Street, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_House, filter).getItog() <= 1 ||
                    new LengthLevensht.LengthLevensht(c.Realty.Address_Number, filter).getItog() <= 1).
                    ToList();
            if (client != null)
                supplies = supplies.Where(s => s.client.ID == client.ID).ToList();
            if (rieltor != null)
                supplies = supplies.Where(s => s.rieltor.ID == rieltor.ID).ToList();
            foreach (Supply e in supplies)
            {
                int r = grid_Flats.Rows.Add(e.ID, e.price, e.client.Name, e.rieltor.Name, e.Realty.ID + " - " + e.Realty.getAddress());
                grid_Flats.Rows[r].Tag = e;
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
            Supply cl = grid_Flats.SelectedRows[0].Tag as Supply;
            if (cl.Deal != null)
            {
                MessageBox.Show("Невозможно удалить, т.к. есть связь со сделкой!!");
                return;
            }
            ModelContext.init().Supplies.Remove(cl);
            save();
        }
    }
}
