using BUS;
using DAL.Entities;
using DeThi02.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi02
{
	public partial class frmSanPham : Form
	{
		private readonly ProductService productService = new ProductService();
		private readonly ProductTypeService productTypeService = new ProductTypeService();
		public frmSanPham()
		{
			InitializeComponent();
		}

		#region Methods
		void loadProductType(List<LoaiSP> listProductType)
		{
			listProductType.Insert(0, new LoaiSP());
			cmbType.DataSource = listProductType;
			cmbType.DisplayMember = "TenLoai";
			cmbType.ValueMember = "MaLoai";
		}
		void loadProduct(List<SanPham> listProduct)
		{
			dgvProduct.Rows.Clear();
			foreach (var item in listProduct)
			{
				int index = dgvProduct.Rows.Add();
				dgvProduct.Rows[index].Cells[0].Value = item.MaSP;
				dgvProduct.Rows[index].Cells[1].Value = item.TenSP;
				dgvProduct.Rows[index].Cells[2].Value = item.NgayNhap;
				dgvProduct.Rows[index].Cells[3].Value = item.LoaiSP.TenLoai;
			}
		}
		#endregion

		#region Events
		private void frmSanPham_Load(object sender, EventArgs e)
		{
			loadProductType(productTypeService.GetAll());
			loadProduct(productService.GetAll());
		}
		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index != -1)
			{
				txtID.Text = dgvProduct.Rows[index].Cells[0].Value.ToString();
				txtName.Text = dgvProduct.Rows[index].Cells[1].Value.ToString();
				dtpDate.Text = dgvProduct.Rows[index].Cells[2].Value.ToString();
				cmbType.Text = dgvProduct.Rows[index].Cells[3].Value.ToString();
			}
		}
		#endregion

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtName.Text == "" || cmbType.Text == "")
			{

				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				ProductModel context = new ProductModel();
				LoaiSP selectedProductType = context.LoaiSP.FirstOrDefault(p => p.TenLoai == cmbType.Text);
				SanPham product = new SanPham() { MaSP = txtID.Text, TenSP = txtName.Text, NgayNhap = dtpDate.Value, MaLoai = selectedProductType.MaLoai };
				SanPham checkProduct = context.SanPham.FirstOrDefault(p => p.MaSP == txtID.Text);

				if (checkProduct != null)
					MessageBox.Show("Mã sản phẩm này đã tồn tại vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					productService.UpdateProduct(product);
					loadProduct(productService.GetAll());
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtName.Text == "" || cmbType.Text == "")
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				if (productService.FindByID(txtID.Text) != null)
				{
					ProductModel context = new ProductModel();
					LoaiSP selectedProductType = context.LoaiSP.FirstOrDefault(p => p.TenLoai == cmbType.Text);
					SanPham product = new SanPham() { MaSP = txtID.Text, TenSP = txtName.Text, NgayNhap = dtpDate.Value, MaLoai = selectedProductType.MaLoai };
					productService.UpdateProduct(product);
					loadProduct(productService.GetAll());
				}
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (dgvProduct.SelectedRows.Count < 1)
				MessageBox.Show("Bạn chưa chọn vào sản phẩm cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				DialogResult dl = MessageBox.Show("Bạn có muốn xoá sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dl == DialogResult.Yes)
				{
					ProductModel context = new ProductModel();
					SanPham product = context.SanPham.FirstOrDefault(p => p.MaSP == txtID.Text);
					if (product == null)
						MessageBox.Show("Không tìm thấy sản phẩm nào cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
					{
						context.SanPham.Remove(product);
						context.SaveChanges();
						loadProduct(context.SanPham.ToList());
					}
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dl = MessageBox.Show("Bạn có thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dl == DialogResult.Yes)
				Application.Exit();
			else if(dl == DialogResult.No)
				e.Cancel = true;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			ProductModel context = new ProductModel();
			List<SanPham> listProducts = context.SanPham.Where(p => p.MaSP == txtSearch.Text).ToList();
			if (listProducts.Count == 0)
				MessageBox.Show("Không có sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
			else
				loadProduct(listProducts);
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if(txtSearch.Text == "")
			{
				loadProduct(productService.GetAll());
			}
		}
	}
}
