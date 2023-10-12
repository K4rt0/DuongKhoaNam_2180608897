using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02.BUS
{
	public class ProductService
	{
		public List<SanPham> GetAll()
		{
			ProductModel product = new ProductModel();
			return product.SanPham.ToList();
		}
		public SanPham FindByID(string ProductName)
		{
			ProductModel context = new ProductModel();
			return context.SanPham.FirstOrDefault(p => p.MaSP == ProductName);
		}
		public void UpdateProduct(SanPham product)
		{
			ProductModel context = new ProductModel();
			context.SanPham.AddOrUpdate(product);
			context.SaveChanges();
		}
	}
}
