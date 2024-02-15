namespace POS_system
{
    partial class FrmCategoryEdit
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
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 27;
            this.listBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(351, 328);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddCategory.Location = new System.Drawing.Point(163, 346);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(200, 31);
            this.txtAddCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmCategoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 473);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddCategory);
            this.Controls.Add(this.listBoxCategory);
            this.MaximumSize = new System.Drawing.Size(395, 520);
            this.MinimumSize = new System.Drawing.Size(395, 520);
            this.Name = "FrmCategoryEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoryEdit";
            this.Load += new System.EventHandler(this.FrmCategoryEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.Button btnAdd;
    }
}