namespace POS_system
{
    partial class FrmOrderManagement
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
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.dgvOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.AllowUserToDeleteRows = false;
            this.dgvOrderInfo.ColumnHeadersHeight = 50;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderID,
            this.dgvCustomer,
            this.dgvEmployee,
            this.dgvOrderDate,
            this.dgvTotalPrice});
            this.dgvOrderInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.RowHeadersVisible = false;
            this.dgvOrderInfo.RowHeadersWidth = 51;
            this.dgvOrderInfo.RowTemplate.Height = 35;
            this.dgvOrderInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderInfo.Size = new System.Drawing.Size(795, 482);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellDoubleClick);
            // 
            // dgvOrderID
            // 
            this.dgvOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvOrderID.DataPropertyName = "OrderID";
            this.dgvOrderID.HeaderText = "訂單編號";
            this.dgvOrderID.MinimumWidth = 6;
            this.dgvOrderID.Name = "dgvOrderID";
            this.dgvOrderID.ReadOnly = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCustomer.DataPropertyName = "CustomerName";
            this.dgvCustomer.HeaderText = "會員";
            this.dgvCustomer.MinimumWidth = 6;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEmployee.DataPropertyName = "EmployeeName";
            this.dgvEmployee.HeaderText = "點餐人員";
            this.dgvEmployee.MinimumWidth = 6;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            // 
            // dgvOrderDate
            // 
            this.dgvOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvOrderDate.DataPropertyName = "OrderDate";
            this.dgvOrderDate.HeaderText = "日期";
            this.dgvOrderDate.MinimumWidth = 6;
            this.dgvOrderDate.Name = "dgvOrderDate";
            this.dgvOrderDate.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTotalPrice.DataPropertyName = "TotalPrice";
            this.dgvTotalPrice.HeaderText = "總金額";
            this.dgvTotalPrice.MinimumWidth = 6;
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // FrmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.dgvOrderInfo);
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "FrmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderManagement";
            this.Load += new System.EventHandler(this.FrmOrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
    }
}