﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ProductTypeService
	{
		public List<LoaiSP> GetAll()
		{
			ProductModel context = new ProductModel();
			return context.LoaiSP.ToList();
		}
	}
}
