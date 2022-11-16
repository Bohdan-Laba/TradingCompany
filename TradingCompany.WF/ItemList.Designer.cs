namespace TradingCompany.WF
{
    partial class ItemList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.MainNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNew = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bLogout = new System.Windows.Forms.ToolStripButton();
            this.viewItems = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YourItems = new System.Windows.Forms.TabPage();
            this.dgvSellerItems = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rowInsertTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrders = new System.Windows.Forms.BindingSource(this.components);
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbOrderStatus = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNavigator)).BeginInit();
            this.MainNavigator.SuspendLayout();
            this.viewItems.SuspendLayout();
            this.Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.YourItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerItems)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // bsItems
            // 
            this.bsItems.DataSource = typeof(TradingCompany.DTO.ItemDto);
            // 
            // MainNavigator
            // 
            this.MainNavigator.AddNewItem = this.bindingNavigatorAddNew;
            this.MainNavigator.BindingSource = this.bsItems;
            this.MainNavigator.CountItem = this.bindingNavigatorCountItem;
            this.MainNavigator.DeleteItem = null;
            this.MainNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNew,
            this.bindingNavigatorDeleteItem,
            this.bLogout,
            this.toolStripSeparator1,
            this.cbOrderStatus});
            this.MainNavigator.Location = new System.Drawing.Point(0, 0);
            this.MainNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.MainNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.MainNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.MainNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.MainNavigator.Name = "MainNavigator";
            this.MainNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.MainNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainNavigator.Size = new System.Drawing.Size(800, 30);
            this.MainNavigator.TabIndex = 1;
            this.MainNavigator.Text = "ListNavigator";
            // 
            // bindingNavigatorAddNew
            // 
            this.bindingNavigatorAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNew.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNew.Image")));
            this.bindingNavigatorAddNew.Name = "bindingNavigatorAddNew";
            this.bindingNavigatorAddNew.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNew.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorAddNew.Text = "Add new";
            this.bindingNavigatorAddNew.Click += new System.EventHandler(this.bindingNavigatorAddNew_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 27);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDelete_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // bLogout
            // 
            this.bLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(68, 27);
            this.bLogout.Text = "Logout";
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // viewItems
            // 
            this.viewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewItems.Controls.Add(this.Items);
            this.viewItems.Controls.Add(this.YourItems);
            this.viewItems.Controls.Add(this.Orders);
            this.viewItems.Location = new System.Drawing.Point(2, 33);
            this.viewItems.Name = "viewItems";
            this.viewItems.SelectedIndex = 0;
            this.viewItems.Size = new System.Drawing.Size(798, 412);
            this.viewItems.TabIndex = 2;
            this.viewItems.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.viewItems_Selecting);
            // 
            // Items
            // 
            this.Items.Controls.Add(this.dgvItems);
            this.Items.Location = new System.Drawing.Point(4, 25);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(790, 383);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.availabilityDataGridViewCheckBoxColumn});
            this.dgvItems.DataSource = this.bsItems;
            this.dgvItems.Location = new System.Drawing.Point(0, 3);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(790, 383);
            this.dgvItems.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            this.sellerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availabilityDataGridViewCheckBoxColumn
            // 
            this.availabilityDataGridViewCheckBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.availabilityDataGridViewCheckBoxColumn.Name = "availabilityDataGridViewCheckBoxColumn";
            this.availabilityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // YourItems
            // 
            this.YourItems.Controls.Add(this.dgvSellerItems);
            this.YourItems.Location = new System.Drawing.Point(4, 25);
            this.YourItems.Name = "YourItems";
            this.YourItems.Padding = new System.Windows.Forms.Padding(3);
            this.YourItems.Size = new System.Drawing.Size(790, 383);
            this.YourItems.TabIndex = 1;
            this.YourItems.Text = "Your Items";
            // 
            // dgvSellerItems
            // 
            this.dgvSellerItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSellerItems.AutoGenerateColumns = false;
            this.dgvSellerItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellerItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellerItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.sellerIDDataGridViewTextBoxColumn1,
            this.availabilityDataGridViewCheckBoxColumn1,
            this.rowInsertTimeDataGridViewTextBoxColumn});
            this.dgvSellerItems.DataSource = this.bsItems;
            this.dgvSellerItems.Location = new System.Drawing.Point(0, 3);
            this.dgvSellerItems.Name = "dgvSellerItems";
            this.dgvSellerItems.RowHeadersWidth = 51;
            this.dgvSellerItems.RowTemplate.Height = 24;
            this.dgvSellerItems.Size = new System.Drawing.Size(790, 382);
            this.dgvSellerItems.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.dgvOrders);
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(790, 383);
            this.Orders.TabIndex = 2;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.UserID,
            this.ItemID,
            this.Quantity,
            this.StatusID});
            this.dgvOrders.DataSource = this.bsOrders;
            this.dgvOrders.Location = new System.Drawing.Point(0, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(790, 383);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // sellerIDDataGridViewTextBoxColumn1
            // 
            this.sellerIDDataGridViewTextBoxColumn1.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn1.HeaderText = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sellerIDDataGridViewTextBoxColumn1.Name = "sellerIDDataGridViewTextBoxColumn1";
            // 
            // availabilityDataGridViewCheckBoxColumn1
            // 
            this.availabilityDataGridViewCheckBoxColumn1.DataPropertyName = "Availability";
            this.availabilityDataGridViewCheckBoxColumn1.HeaderText = "Availability";
            this.availabilityDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.availabilityDataGridViewCheckBoxColumn1.Name = "availabilityDataGridViewCheckBoxColumn1";
            // 
            // rowInsertTimeDataGridViewTextBoxColumn
            // 
            this.rowInsertTimeDataGridViewTextBoxColumn.DataPropertyName = "RowInsertTime";
            this.rowInsertTimeDataGridViewTextBoxColumn.HeaderText = "RowInsertTime";
            this.rowInsertTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rowInsertTimeDataGridViewTextBoxColumn.Name = "rowInsertTimeDataGridViewTextBoxColumn";
            // 
            // bsOrders
            // 
            this.bsOrders.DataSource = typeof(TradingCompany.DTO.OrderDto);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // StatusID
            // 
            this.StatusID.DataPropertyName = "StatusID";
            this.StatusID.HeaderText = "StatusID";
            this.StatusID.MinimumWidth = 6;
            this.StatusID.Name = "StatusID";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.Items.AddRange(new object[] {
            "All Orders",
            "Pending",
            "Accepted",
            "Paid",
            "Shipped",
            "Delivered"});
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(121, 30);
            this.cbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cbOrderStatus_SelectedIndexChanged);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.viewItems);
            this.Controls.Add(this.MainNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemList";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNavigator)).EndInit();
            this.MainNavigator.ResumeLayout(false);
            this.MainNavigator.PerformLayout();
            this.viewItems.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.YourItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerItems)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsItems;
        private System.Windows.Forms.BindingNavigator MainNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bLogout;
        private System.Windows.Forms.TabControl viewItems;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage YourItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.DataGridView dgvSellerItems;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowInsertTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbOrderStatus;
    }
}

