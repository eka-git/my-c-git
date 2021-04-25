
using System;
using System.Windows.Forms;
namespace f1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRemind = new System.Windows.Forms.Label();
            this.flpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOpt = new System.Windows.Forms.Label();
            this.cmbOpt = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnAddOd = new System.Windows.Forms.Button();
            this.btnModifyOd = new System.Windows.Forms.Button();
            this.btnDeleteOd = new System.Windows.Forms.Button();
            this.btnInputOd = new System.Windows.Forms.Button();
            this.btnOutputOd = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prodc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Location = new System.Drawing.Point(13, 9);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(187, 15);
            this.lblRemind.TabIndex = 0;
            this.lblRemind.Text = "您可以通过以下信息查询：";
            // 
            // flpInfo
            // 
            this.flpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInfo.Controls.Add(this.lblOpt);
            this.flpInfo.Controls.Add(this.cmbOpt);
            this.flpInfo.Controls.Add(this.lblInfo);
            this.flpInfo.Controls.Add(this.txtInfo);
            this.flpInfo.Controls.Add(this.btnSearch);
            this.flpInfo.Location = new System.Drawing.Point(13, 35);
            this.flpInfo.Name = "flpInfo";
            this.flpInfo.Size = new System.Drawing.Size(942, 40);
            this.flpInfo.TabIndex = 1;
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.Location = new System.Drawing.Point(3, 0);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblOpt.Size = new System.Drawing.Size(82, 22);
            this.lblOpt.TabIndex = 6;
            this.lblOpt.Text = "查询方式：";
            // 
            // cmbOpt
            // 
            this.cmbOpt.AutoCompleteCustomSource.AddRange(new string[] {
            "按订单号查询",
            "按商品名称查询",
            "按客户号查询"});
            this.cmbOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpt.FormattingEnabled = true;
            this.cmbOpt.Items.AddRange(new object[] {
            "按订单号查询",
            "按商品名称查询",
            "按客户号查询"});
            this.cmbOpt.Location = new System.Drawing.Point(91, 3);
            this.cmbOpt.Name = "cmbOpt";
            this.cmbOpt.Size = new System.Drawing.Size(165, 23);
            this.cmbOpt.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(262, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblInfo.Size = new System.Drawing.Size(82, 22);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "查询信息：";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(350, 3);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(108, 25);
            this.txtInfo.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRemind);
            this.panel1.Controls.Add(this.flpInfo);
            this.panel1.Location = new System.Drawing.Point(28, 11);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panel1.Size = new System.Drawing.Size(968, 80);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 266);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Prodc,
            this.Num,
            this.ItemPrice});
            this.dataGridView2.DataSource = this.orderItemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(487, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(508, 266);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prodc";
            this.dataGridViewTextBoxColumn1.HeaderText = "商品";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(211, 105);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblOrder.Size = new System.Drawing.Size(67, 22);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "订单信息";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(720, 105);
            this.lblItems.Name = "lblItems";
            this.lblItems.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblItems.Size = new System.Drawing.Size(82, 22);
            this.lblItems.TabIndex = 8;
            this.lblItems.Text = "订单明细项";
            // 
            // btnAddOd
            // 
            this.btnAddOd.Location = new System.Drawing.Point(28, 402);
            this.btnAddOd.Name = "btnAddOd";
            this.btnAddOd.Size = new System.Drawing.Size(99, 34);
            this.btnAddOd.TabIndex = 9;
            this.btnAddOd.Text = "添加订单";
            this.btnAddOd.UseVisualStyleBackColor = true;
            this.btnAddOd.Click += new System.EventHandler(this.btnAddOd_Click);
            // 
            // btnModifyOd
            // 
            this.btnModifyOd.Location = new System.Drawing.Point(132, 402);
            this.btnModifyOd.Name = "btnModifyOd";
            this.btnModifyOd.Size = new System.Drawing.Size(99, 34);
            this.btnModifyOd.TabIndex = 10;
            this.btnModifyOd.Text = "修改订单";
            this.btnModifyOd.UseVisualStyleBackColor = true;
            this.btnModifyOd.Click += new System.EventHandler(this.btnModifyOd_Click);
            // 
            // btnDeleteOd
            // 
            this.btnDeleteOd.Location = new System.Drawing.Point(236, 402);
            this.btnDeleteOd.Name = "btnDeleteOd";
            this.btnDeleteOd.Size = new System.Drawing.Size(99, 34);
            this.btnDeleteOd.TabIndex = 11;
            this.btnDeleteOd.Text = "删除订单";
            this.btnDeleteOd.UseVisualStyleBackColor = true;
            // 
            // btnInputOd
            // 
            this.btnInputOd.Location = new System.Drawing.Point(637, 402);
            this.btnInputOd.Name = "btnInputOd";
            this.btnInputOd.Size = new System.Drawing.Size(99, 34);
            this.btnInputOd.TabIndex = 12;
            this.btnInputOd.Text = "导入订单";
            this.btnInputOd.UseVisualStyleBackColor = true;
            this.btnInputOd.Click += new System.EventHandler(this.btnInputOd_Click);
            // 
            // btnOutputOd
            // 
            this.btnOutputOd.Location = new System.Drawing.Point(741, 402);
            this.btnOutputOd.Name = "btnOutputOd";
            this.btnOutputOd.Size = new System.Drawing.Size(99, 34);
            this.btnOutputOd.TabIndex = 13;
            this.btnOutputOd.Text = "导出订单";
            this.btnOutputOd.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "订单项目号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Prodc
            // 
            this.Prodc.DataPropertyName = "Prodc";
            this.Prodc.HeaderText = "商品";
            this.Prodc.MinimumWidth = 6;
            this.Prodc.Name = "Prodc";
            this.Prodc.Width = 125;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "数量";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.Width = 60;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "总价";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 60;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(f1.OrderItem);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "客户";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 70;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 85;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 60;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(f1.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 446);
            this.Controls.Add(this.btnOutputOd);
            this.Controls.Add(this.btnInputOd);
            this.Controls.Add(this.btnDeleteOd);
            this.Controls.Add(this.btnModifyOd);
            this.Controls.Add(this.btnAddOd);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flpInfo.ResumeLayout(false);
            this.flpInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.FlowLayoutPanel flpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label lblOpt;
        private System.Windows.Forms.ComboBox cmbOpt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnAddOd;
        private System.Windows.Forms.Button btnModifyOd;
        private System.Windows.Forms.Button btnDeleteOd;
        private System.Windows.Forms.Button btnInputOd;
        private System.Windows.Forms.Button btnOutputOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prodc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
    }
 
}

