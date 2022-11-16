namespace TradingCompany.WF
{
    partial class UpdateOrder
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
            this.lblOrdID = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrdID
            // 
            this.lblOrdID.AutoSize = true;
            this.lblOrdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblOrdID.Location = new System.Drawing.Point(50, 31);
            this.lblOrdID.Name = "lblOrdID";
            this.lblOrdID.Size = new System.Drawing.Size(81, 24);
            this.lblOrdID.TabIndex = 0;
            this.lblOrdID.Text = "Order ID";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(79, 297);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(145, 41);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(361, 297);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(145, 41);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUID.Location = new System.Drawing.Point(50, 85);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(71, 24);
            this.lblUID.TabIndex = 3;
            this.lblUID.Text = "User ID";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblItem.Location = new System.Drawing.Point(50, 139);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(45, 24);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblQuant.Location = new System.Drawing.Point(50, 193);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(78, 24);
            this.lblQuant.TabIndex = 5;
            this.lblQuant.Text = "Quantity";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStatus.Location = new System.Drawing.Point(50, 247);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblOrderID.Location = new System.Drawing.Point(232, 31);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(71, 24);
            this.lblOrderID.TabIndex = 7;
            this.lblOrderID.Text = "New ID";
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.bsStatus;
            this.cbStatus.DisplayMember = "Name";
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(236, 249);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.ValueMember = "Name";
            // 
            // bsStatus
            // 
            this.bsStatus.DataSource = typeof(TradingCompany.DTO.StatusDto);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(236, 195);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(120, 22);
            this.tbQuantity.TabIndex = 10;
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(236, 141);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(120, 22);
            this.tbItem.TabIndex = 11;
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(236, 87);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(120, 22);
            this.tbUserID.TabIndex = 12;
            // 
            // UpdateOrder
            // 
            this.AcceptButton = this.bSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.lblOrdID);
            this.Controls.Add(this.lblOrderID);
            this.Name = "UpdateOrder";
            this.Text = "Update Order";
            this.Load += new System.EventHandler(this.UpdateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrdID;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbUserID;
    }
}