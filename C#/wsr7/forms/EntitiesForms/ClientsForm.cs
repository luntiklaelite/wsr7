
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

namespace wsr7.Forms.EntitiesForms
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            refreshGrid("");
        }

        void refreshGrid(string filter)
        {
            Grid_Clients.Rows.Clear();
            List<Client> clients;
            if (filter == "")
                clients = ModelContext.init().Clients.ToList();
            else
                clients = ModelContext.init().Clients.AsEnumerable().Where(c => new LengthLevensht.LengthLevensht(c.Familia, filter).getItog() <= 3 || new LengthLevensht.LengthLevensht(c.Name, filter).getItog() <= 3 || new LengthLevensht.LengthLevensht(c.Otchestvo, filter).getItog() <= 3).ToList();
            foreach(Client client in clients)
            {
                int r = Grid_Clients.Rows.Add(client.ID, client.Familia, client.Name, client.Otchestvo, client.PhoneNumber, client.EMail);
                Grid_Clients.Rows[r].Tag = client;
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

        private void But_Add_Click(object sender, EventArgs e)
        {
            if(fie_add_number.Text == "" && fie_add_mail.Text == "")
            {
                MessageBox.Show("Ввведите номер телефона или Email");
                return;
            }
            if (!ReallyDoIt())
                return;
            Client client = new Client {
                Familia = fie_add_familia.Text,
                Name = fie_add_name.Text,
                Otchestvo = fie_add_otchestvo.Text,
                EMail = fie_add_mail.Text,
                PhoneNumber = fie_add_number.Text };
            ModelContext.init().Clients.Add(client);
            save();
        }

        private void But_Dell_Click(object sender, EventArgs e)
        {
            if (Grid_Clients.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Client cl = Grid_Clients.SelectedRows[0].Tag as Client;
            if(cl.Supplies.Count() > 0)
            {
                MessageBox.Show("Невозможно удалить, т.к. у клиента есть предложение!");
                return;
            }
            if(cl.Demands.Count() > 0)
            {
                MessageBox.Show("Невозможно удалить, т.к. у клиента есть потребность!");
                return;
            }
            ModelContext.init().Clients.Remove(cl);
            save();
        }


        private void But_Edit_Click(object sender, EventArgs e)
        {
            if (Grid_Clients.SelectedRows.Count != 1)
                return;
            if (fie_edit_number.Text == "" && fie_edit_mail.Text == "")
            {
                MessageBox.Show("Ввведите номер телефона или Email");
                return;
            }
            if (!ReallyDoIt())
                return;
            Client cl = Grid_Clients.SelectedRows[0].Tag as Client;
            cl.Familia = fie_edit_familia.Text;
            cl.EMail = fie_edit_mail.Text;
            cl.Name = fie_edit_name.Text;
            cl.Otchestvo = fie_edit_otchestvo.Text;
            cl.PhoneNumber = fie_edit_number.Text;
            save();
        }

        private void Grid_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Clients.SelectedRows.Count != 1)
                return;
            Client cl = Grid_Clients.SelectedRows[0].Tag as Client;
            fie_edit_familia.Text = cl.Familia;
            fie_edit_mail.Text = cl.EMail;
            fie_edit_name.Text = cl.Name;
            fie_edit_number.Text = cl.PhoneNumber;
            fie_edit_otchestvo.Text = cl.Otchestvo;
        }

        private void Fie_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid(Fie_Search.Text);
        }

        private void go_Demands_Click(object sender, EventArgs e)
        {
            if (Grid_Clients.SelectedRows.Count != 1)
                return;
            Client cl = Grid_Clients.SelectedRows[0].Tag as Client;
            managers.ManagerForms.ChangeForm(new DemandsForm(cl));
        }

        private void go_Supplies_Click(object sender, EventArgs e)
        {
            if (Grid_Clients.SelectedRows.Count != 1)
                return;
            Client cl = Grid_Clients.SelectedRows[0].Tag as Client;
            managers.ManagerForms.ChangeForm(new SuppliesForm(cl));
        }
    }
}
