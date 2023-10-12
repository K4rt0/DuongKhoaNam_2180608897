namespace DeThi02
{
	partial class frmSanPham
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(310, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH MỤC SẢN PHẨM";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
			this.txtSearch.Location = new System.Drawing.Point(34, 51);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(153, 22);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.NgayNhap,
            this.TenLoai});
			this.dgvProduct.Location = new System.Drawing.Point(34, 79);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.Size = new System.Drawing.Size(554, 235);
			this.dgvProduct.TabIndex = 6;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// MaSP
			// 
			this.MaSP.HeaderText = "Mã SP";
			this.MaSP.MinimumWidth = 6;
			this.MaSP.Name = "MaSP";
			this.MaSP.ReadOnly = true;
			this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MaSP.Width = 125;
			// 
			// TenSP
			// 
			this.TenSP.HeaderText = "Tên sản phẩm";
			this.TenSP.MinimumWidth = 6;
			this.TenSP.Name = "TenSP";
			this.TenSP.ReadOnly = true;
			this.TenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TenSP.Width = 125;
			// 
			// NgayNhap
			// 
			this.NgayNhap.HeaderText = "Ngày nhập";
			this.NgayNhap.MinimumWidth = 6;
			this.NgayNhap.Name = "NgayNhap";
			this.NgayNhap.ReadOnly = true;
			this.NgayNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NgayNhap.Width = 125;
			// 
			// TenLoai
			// 
			this.TenLoai.HeaderText = "Loại SP";
			this.TenLoai.MinimumWidth = 6;
			this.TenLoai.Name = "TenLoai";
			this.TenLoai.ReadOnly = true;
			this.TenLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TenLoai.Width = 125;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(638, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã SP:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(631, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên SP:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(603, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ngày nhập:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(629, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Loại SP:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(113, 331);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(101, 36);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(219, 331);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(101, 36);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(326, 331);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(101, 36);
			this.btnDel.TabIndex = 9;
			this.btnDel.Text = "Xoá";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(433, 331);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(101, 36);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(540, 331);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(101, 36);
			this.button6.TabIndex = 11;
			this.button6.Text = "K.Lưu";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(647, 331);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(101, 36);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(722, 120);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(178, 22);
			this.txtID.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(722, 158);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(178, 22);
			this.txtName.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(193, 51);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(722, 233);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(178, 24);
			this.cmbType.TabIndex = 5;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(723, 194);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(177, 22);
			this.dtpDate.TabIndex = 4;
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 391);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Name = "frmSanPham";
			this.Text = "QUẢN LÝ SẢN PHẨM";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
		private System.Windows.Forms.DateTimePicker dtpDate;
	}
}

