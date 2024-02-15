namespace POS_system
{
    partial class UserControlProuct
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxProuct = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numericQuan = new System.Windows.Forms.NumericUpDown();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProuct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProuct
            // 
            this.pictureBoxProuct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProuct.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProuct.Name = "pictureBoxProuct";
            this.pictureBoxProuct.Size = new System.Drawing.Size(283, 200);
            this.pictureBoxProuct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProuct.TabIndex = 0;
            this.pictureBoxProuct.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(27, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(69, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(27, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "label1";
            // 
            // numericQuan
            // 
            this.numericQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuan.Location = new System.Drawing.Point(198, 53);
            this.numericQuan.Name = "numericQuan";
            this.numericQuan.Size = new System.Drawing.Size(71, 30);
            this.numericQuan.TabIndex = 2;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddDetail.Location = new System.Drawing.Point(69, 102);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(146, 50);
            this.btnAddDetail.TabIndex = 3;
            this.btnAddDetail.Text = "確認";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxProuct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 200);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.btnAddDetail);
            this.panel2.Controls.Add(this.numericQuan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 166);
            this.panel2.TabIndex = 5;
            // 
            // UserControlProuct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProuct";
            this.Size = new System.Drawing.Size(283, 366);
            this.Load += new System.EventHandler(this.UserControlProuct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProuct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxProuct;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Button btnAddDetail;
        public System.Windows.Forms.NumericUpDown numericQuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
