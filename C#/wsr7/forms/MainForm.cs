using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsr7.Forms.EntitiesForms;
using wsr7.managers;

namespace wsr7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void but_goClients_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new ClientsForm());
        }

        private void but_goRieltors_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new RieltorsForm());
        }

        private void but_goFlats_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new FlatsForm());
        }

        private void but_goHouses_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new HousesForm());
        }

        private void but_goEarth_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new EarthesForm());
        }

        private void but_goSupplies_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new SuppliesForm());
        }


        private void but_goDemands_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new DemandsForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerForms.ChangeForm(new DealsForm());
        }
    }
}
