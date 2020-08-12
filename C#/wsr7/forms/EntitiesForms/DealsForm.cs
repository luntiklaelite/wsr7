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
    public partial class DealsForm : Form
    {
        public DealsForm()
        {
            InitializeComponent();
            fillCombos(fie_add_demand, fie_add_supply);
            fillCombos(fie_edit_demand, fie_edit_supply, true);
            refreshGrid("");
            combo_types.SelectedIndex = 3;
        }

        void fillCombos(ComboBox c_dem, ComboBox c_sup, bool asEdit = false)
        {
            Supply[] supplies;
            Demand[] demands;
            Demand ld = c_dem.SelectedItem as Demand;
            Supply ls = c_sup.SelectedItem as Supply;
            if (ld == null)
            {
                supplies = ModelContext.init().Supplies.Include(s => s.Deal).Include(s => s.Realty).Include(s => s.Realty.Earth).Include(s => s.Realty.Flat).Include(s => s.Realty.House).ToArray();

            }
            else
            {
                supplies = ModelContext.init().Supplies.Include(s => s.Deal).Include(s => s.Realty).Include(s => s.Realty.Earth).Include(s => s.Realty.Flat).Include(s => s.Realty.House).AsEnumerable()
                    .Where(s => s.Compare(ld)).ToArray();
            }
            if (ls == null)
            {
                demands = ModelContext.init().Demands.Include(i => i.Deal).Include(i => i.HouseDemand).Include(i => i.EarthDemand).Include(i => i.FlatDemand).ToArray();
            }
            else
            {
                demands = ModelContext.init().Demands.Include(i => i.Deal).Include(i => i.HouseDemand).Include(i => i.EarthDemand).Include(i => i.FlatDemand).AsEnumerable().Where(d => ls.Compare(d)).ToArray();
            }
            
            supplies = supplies.Where(s => s.Deal == null || asEdit && (ls != null && s.ID == ls.ID)).ToArray();
            demands = demands.Where(s => s.Deal == null || asEdit && (ld != null && s.ID == ld.ID)).ToArray();
            c_sup.Items.Clear();
            c_dem.Items.Clear();
            c_sup.Items.AddRange(supplies);
            c_dem.Items.AddRange(demands);
            if (demands.Contains(ld))
                c_dem.SelectedItem = ld;
            if (supplies.Contains(ls))
                c_sup.SelectedItem = ls;
        }

        void refreshGrid(string filter)
        {
            grid_Flats.Rows.Clear();
            List<Deal> deals;
            if (filter == "")
                deals = ModelContext.init().Deals.Include(i => i.Demand).Include(i => i.Supply).Include(i => i.Supply.Realty).Include(i => i.Demand.EarthDemand).Include(i => i.Demand.FlatDemand).Include(i => i.Demand.HouseDemand).Include(i => i.Supply.Realty.Earth).Include(i => i.Supply.Realty.Flat).Include(i => i.Supply.Realty.House).ToList();
            else
                deals = ModelContext.init().Deals.Include(i => i.Demand).Include(i => i.Supply).Include(i => i.Supply.Realty).Include(i => i.Demand.EarthDemand).Include(i => i.Demand.FlatDemand).Include(i => i.Demand.HouseDemand).Include(i => i.Supply.Realty.Earth).Include(i => i.Supply.Realty.Flat).Include(i => i.Supply.Realty.House).AsEnumerable().Where(c => new LengthLevensht.LengthLevensht(c.Supply.Realty.Address_City, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Supply.Realty.Address_Street, filter).getItog() <= 3 ||
                    new LengthLevensht.LengthLevensht(c.Supply.Realty.Address_House, filter).getItog() <= 1 ||
                    new LengthLevensht.LengthLevensht(c.Supply.Realty.Address_Number, filter).getItog() <= 1).ToList();
            foreach (Deal deal in deals)
            {
                if ((deal.Demand.HouseDemand == null && combo_types.SelectedIndex == 0) || (combo_types.SelectedIndex == 1 && deal.Demand.FlatDemand == null) || (combo_types.SelectedIndex == 2 && deal.Demand.EarthDemand == null))
                    continue;
                int r = grid_Flats.Rows.Add(deal.ID, deal.Demand, deal.Supply);
                grid_Flats.Rows[r].Tag = deal;
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
            refreshAllFies();
        }

        private void but_prev_Click(object sender, EventArgs e)
        {
            managers.ManagerForms.ChangeForm(new MainForm());
        }

        private void Fie_Search_TextChanged(object sender, EventArgs e)
        {
            refreshGrid(Fie_Search.Text);
        }

        private void But_Dell_Click_1(object sender, EventArgs e)
        {
            if (grid_Flats.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Deal cl = grid_Flats.SelectedRows[0].Tag as Deal;
            ModelContext.init().Deals.Remove(cl);
            save();
        }

        private void fie_add_demand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCombos(fie_add_demand, fie_add_supply);
        }

        private void refreshAllFies()
        {
            fie_add_demand.SelectedItem = null;
            fie_add_supply.SelectedItem = null;
            fie_edit_demand.SelectedItem = null;
            fie_edit_supply.SelectedItem = null;
            fillCombos(fie_add_demand, fie_add_supply);
            fillCombos(fie_edit_demand, fie_edit_supply, true);
        }

        private void refreshAllFies_changebox(object sender, EventArgs e)
        {
            refreshAllFies();
        }

        private void fie_edit_supply_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCombos(fie_edit_demand, fie_edit_supply, true);
        }

        private void showPercents(Deal d)
        {
            double toCompanyFromSupply;
            if (d.Demand.EarthDemand != null)
                toCompanyFromSupply = 30000 + d.Supply.price * 0.02;
            else if (d.Demand.FlatDemand != null)
                toCompanyFromSupply = 36000 + d.Supply.price * 0.01;
            else
                toCompanyFromSupply = 30000 + d.Supply.price * 0.01;
            double toCompanyDemand = d.Supply.price * 0.03;
            double toSupply = toCompanyFromSupply * d.Supply.rieltor.Comissia/100, toDemand = toCompanyDemand * d.Demand.Rieltor.Comissia/100;
            double toCompany = toCompanyDemand + toCompanyFromSupply - toSupply - toDemand;
            MessageBox.Show($"Компания получит: {toCompany}\nРиелтор клиента-продавца: {toSupply}\nРиелтор клиента-покупателя: {toDemand}");
        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            Deal d = new Deal
            {
                Demand = fie_add_demand.SelectedItem as Demand,
                Supply = fie_add_supply.SelectedItem as Supply
            };
            if (!ReallyDoIt())
                return;
            showPercents(d);
            ModelContext.init().Deals.Add(d);
            save();
        }

        private void But_Edit_Click(object sender, EventArgs e)
        {
            if(fie_edit_demand.SelectedItem == null || fie_edit_supply.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали элемент!");
                return;
            }
            if (grid_Flats.SelectedRows.Count != 1)
                return;
            if (!ReallyDoIt())
                return;
            Deal d = grid_Flats.SelectedRows[0].Tag as Deal;
            d.Demand = fie_edit_demand.SelectedItem as Demand;
            d.Supply = fie_edit_supply.SelectedItem as Supply;
            showPercents(d);
            
            if (d.Supply.Compare(d.Demand))
                save();
            else
            {
                MessageBox.Show("Элементы не соответствуют условиям!");
                return;
            }
        }

        private void grid_Flats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_Flats.SelectedRows.Count != 1)
                return;
            Deal d = grid_Flats.SelectedRows[0].Tag as Deal;
            fie_edit_demand.Items.Add(d.Demand);
            fie_edit_supply.Items.Add(d.Supply);
            fie_edit_demand.SelectedItem = d.Demand;
            fie_edit_supply.SelectedItem = d.Supply;
            fillCombos(fie_edit_demand, fie_edit_supply, true);
        }

        private void combo_types_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshGrid("");
        }
    }
}
