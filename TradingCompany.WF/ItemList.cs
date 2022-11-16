using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.Concrete;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class ItemList : Form
    {
        private readonly IManager _manager;
        private readonly UserDto _user;
        private List<ItemDto> _items;
        private List<ItemDto> _currentItems;
        private List<OrderDto> _currentOrders;

        public ItemList(IManager manager)
        {
            InitializeComponent();

            _manager = manager;
            _user = LoginForm._CurrentUser;
            Authenticate();
            _items = _manager.GetItemsList();
        }

        private void Authenticate()
        {
            if (_user.Roles.Find(o => o.Name == "Seller") != null)
            {
                _currentItems = _manager.GetSellerItemsList(_user.UserID);
                _currentOrders = _manager.GetSellerOrdersList(_user.UserID);
            }
            else
            {
                viewItems.Enabled = false;
            }    
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            RefreshCurrentGrid(viewItems.SelectedTab.Name);
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void viewItems_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RefreshCurrentGrid(viewItems.SelectedTab.Name);
        }

        private void RefreshCurrentGrid(string name)
        {
            switch (name)
            {
                case "Items":

                    BindingList<ItemDto> blItems = new BindingList<ItemDto>(_items);
                    bsItems.DataSource = blItems;
                    dgvItems.DataSource = bsItems;
                    MainNavigator.BindingSource = bsItems;

                    cbOrderStatus.Visible = false;
                    bindingNavigatorAddNew.Enabled = false;
                    bindingNavigatorDeleteItem.Enabled = false;
                    break;
                case "YourItems":
                    BindingList<ItemDto> blSellerItems = new BindingList<ItemDto>(_currentItems);
                    bsItems.DataSource = blSellerItems;
                    dgvSellerItems.DataSource = bsItems;
                    MainNavigator.BindingSource = bsItems;

                    cbOrderStatus.Visible = false;
                    bindingNavigatorAddNew.Enabled = false;
                    bindingNavigatorDeleteItem.Enabled = false;
                    break;
                case "Orders":
                    _currentOrders = _manager.GetSellerOrdersList(_user.UserID);
                    BindingList<OrderDto> blOrders = new BindingList<OrderDto>(_currentOrders);
                    bsOrders.DataSource = blOrders;
                    dgvOrders.DataSource = bsOrders;
                    MainNavigator.BindingSource = bsOrders;


                    cbOrderStatus.Visible = true;
                    cbOrderStatus.SelectedIndex = 0;
                    bindingNavigatorAddNew.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void bindingNavigatorAddNew_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void ShowEdit(OrderDto order = null)
        {
            UpdateOrder editForm = new UpdateOrder(_manager, order);

            var res = editForm.ShowDialog();
            if (DialogResult.OK == res || DialogResult.Cancel == res)
            {
                RefreshCurrentGrid(viewItems.SelectedTab.Name);
            }
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure?", "Delete item", MessageBoxButtons.OKCancel))
            {
                _manager.Delete(((OrderDto)bsItems.Current).OrderID);
                RefreshCurrentGrid(viewItems.SelectedTab.Name);
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit(_currentOrders[e.RowIndex]);
        }

        private void cbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderStatus.SelectedIndex == 0)
            {
                var blOrders = new BindingList<OrderDto>(_currentOrders);
                bsOrders.DataSource = blOrders;

            }
            else
            {
                var fBlOrders = new BindingList<OrderDto>(_currentOrders.Where(x => x.StatusID == cbOrderStatus.SelectedIndex).ToList());
                bsOrders.DataSource = fBlOrders;
            }
        }
    }
}
