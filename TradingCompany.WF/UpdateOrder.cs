using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class UpdateOrder : Form
    {
        private readonly IManager _manager;
        private OrderDto _order;

        //private List<OrderDto> _currentOrders;


        //private ItemDto _item;
        //public UpdateOrder(IManager manager, ItemDto item)
        //{
        //    InitializeComponent();

        //    _manager = manager;
        //    _item = item;
        //}
        public UpdateOrder(IManager manager, OrderDto order)
        {
            InitializeComponent();

            _manager = manager;
            _order = order;
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            BindOrder();

            if (_order != null)
            {
                lblOrderID.Text = _order.OrderID.ToString();
                tbUserID.Text = _order.UserID.ToString();
                tbItem.Text = _manager.GetItem(_order.ItemID).Name;
                tbQuantity.Text = _order.Quantity.ToString();
                cbStatus.SelectedValue = _order.StatusID;
            }
        }

        private void BindOrder()
        {
            BindingList<StatusDto> statuses = new BindingList<StatusDto>(_manager.GetStatusesList());
            bsStatus.DataSource = statuses;
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            updOrder();

            var isUpdated = _manager.Update(_order);
            if (!isUpdated)
            {
                _order = _manager.Add(_order);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void updOrder()
        {
            if (_order != null)
            {
                _order.UserID = int.Parse(tbUserID.Text);
                _order.ItemID = _manager.GetItem(tbItem.Text).ItemID;
                _order.Quantity = int.Parse(tbQuantity.Text);
                _order.StatusID = ((StatusDto)cbStatus.SelectedItem).StatusID;
            }
            else
            {
                _order = new OrderDto
                {
                    UserID = int.Parse(tbUserID.Text),
                    ItemID = _manager.GetItem(tbItem.Text).ItemID,
                    Quantity = int.Parse(tbQuantity.Text),
                    StatusID = ((StatusDto)cbStatus.SelectedItem).StatusID,
                };
            }

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
