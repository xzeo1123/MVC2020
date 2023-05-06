﻿using DataAccess;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class PaymentService : IPaymentService
    {
        private ApplicationDbContext _context;
        public PaymentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Bill bill, int[] proids)
        {
            _context.Bill.AddAsync(bill);
            await _context.SaveChangesAsync();
            var billid = bill.BillID;
            for(int i=0;i<proids.Count();i++)
            {
                var productBill = new ProductBill();
                productBill.BillID = billid;
                productBill.ProductID = proids[i];
                productBill.Quantity = 1;
                AddProductBill(productBill);
            }
        }

        public async Task AddProductBill(ProductBill pbill)
        {
            _context.ProductBill.AddAsync(pbill);
            await _context.SaveChangesAsync();
        }

        public async Task ClearCart(int userid)
        {
            var rowsToDelete = _context.Cart.Where(c => c.UserID == userid);
            _context.Cart.RemoveRange(rowsToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
