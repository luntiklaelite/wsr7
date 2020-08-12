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
    public partial class RieltorsForm : Form
    {
        public RieltorsForm()
        {
            InitializeComponent();
            refreshGrid("");
        }

        void refreshGrid(string filter)
        {
            filter = filter.ToLower();
            Grid_Rieltors.Rows.Clear();
            List<Rieltor> rieltors;
            if (filter != "")
                rieltors = ModelContext.init().Rieltors.AsEnumerable().Where(r => new LengthLevensht.LengthLevensht(r.Familia, filter).getItog() <= 3 || new LengthLevensht.LengthLevensht(r.Name, filter).getItog() <= 3 || new LengthLevensht.LengthLevensht(r.Otchestvo, filter).getItog() <= 3).ToList();
            else
                rieltors = ModelContext.init().Rieltors.ToList();
            foreach (Rieltor rieltor in rieltors)
            {
                int r = Grid_Rieltors.Rows.Add(rieltor.ID, rieltor.Familia, rieltor.Name, rieltor.Otchestvo, rieltor.Comissia);
                Grid_Rieltors.Rows[r].Tag = rieltor;
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

        private void But_Dell_Click(object sender, EventArgs e)
        {
            if (Grid_Rieltors.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Rieltor riel = Grid_Rieltors.SelectedRows[0].Tag as Rieltor;
            if (riel.Supplies.Count() > 0)
            {
                MessageBox.Show("Невозможно удалить, т.к. у риелтора есть предложение!");
                return;
            }
            if (riel.Demands.Count() > 0)
            {
                MessageBox.Show("Невозможно удалить, т.к. у риелтора есть потребность!");
                return;
            }
            ModelContext.init().Rieltors.Remove(riel);
            save();
        }

        private void But_Edit_Click(object sender, EventArgs e)
        {
            if (Grid_Rieltors.SelectedRows.Count != 1)
                return;
            if (!double.TryParse(fie_edit_comissia.Text, out double comissia) || fie_edit_familia.Text == "" || fie_edit_name.Text == "" || fie_edit_otchestvo.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(comissia < 0 || comissia > 100)
            {
                MessageBox.Show("Комиссия от 0 до 100!");
                return;
            }
            if (!ReallyDoIt())
                return;
            Rieltor riel = Grid_Rieltors.SelectedRows[0].Tag as Rieltor;
            riel.Name = fie_edit_name.Text;
            riel.Familia = fie_edit_familia.Text;
            riel.Otchestvo = fie_edit_otchestvo.Text;
            riel.Comissia = comissia;
            save();
            fie_edit_otchestvo.Text = "";
            fie_edit_name.Text = "";
            fie_edit_familia.Text = "";
            fie_edit_comissia.Text = "";

        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(fie_add_comissia.Text, out double comissia) || fie_add_familia.Text == "" || fie_add_name.Text == "" || fie_add_otchestvo.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (comissia < 0 || comissia > 100)
            {
                MessageBox.Show("Комиссия от 0 до 100!");
                return;
            }
            if (!ReallyDoIt())
                return;
            Rieltor rieltor = new Rieltor() {
                Familia = fie_add_familia.Text,
                Name = fie_add_name.Text,
                Comissia = comissia,
                Otchestvo = fie_add_otchestvo.Text };
            ModelContext.init().Rieltors.Add(rieltor);
            save();
        }

        private void Grid_Rieltors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Rieltors.SelectedRows.Count != 1)
                return;
            Rieltor riel = Grid_Rieltors.SelectedRows[0].Tag as Rieltor;
            fie_edit_familia.Text = riel.Familia;
            fie_edit_comissia.Text = riel.Comissia.ToString();
            fie_edit_name.Text = riel.Name;
            fie_edit_otchestvo.Text = riel.Otchestvo;
        }

        private void Fie_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid(Fie_Search.Text);
        }

        private void go_Supplies_Click(object sender, EventArgs e)
        {
            if (Grid_Rieltors.SelectedRows.Count != 1)
                return;
            Rieltor riel = Grid_Rieltors.SelectedRows[0].Tag as Rieltor;
            managers.ManagerForms.ChangeForm(new SuppliesForm(null,riel));
        }

        private void go_Demands_Click(object sender, EventArgs e)
        {
            if (Grid_Rieltors.SelectedRows.Count != 1)
                return;
            Rieltor riel = Grid_Rieltors.SelectedRows[0].Tag as Rieltor;
            managers.ManagerForms.ChangeForm(new DemandsForm(null, riel));
        }
    }
}
