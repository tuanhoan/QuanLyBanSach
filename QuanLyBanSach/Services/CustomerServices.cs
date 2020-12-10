using LinqKit;
using QuanLyBanSach.Data;
using QuanLyBanSach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanSach.Services
{
    class CustomerServices
    {
        public List<Customer> GetAll()
        {
            using(var _context = new QuanLyBanSachContext())
            {
                return _context.Customers.ToList();
            }
        }
        public void Insert(Customer customer)
        {
            using(var _context = new QuanLyBanSachContext())
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
        }
        public void Update(Customer customer)
        {
            using(var _context = new QuanLyBanSachContext())
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
            }
        } 
        public void Delete(Customer customer)
        {
            using(var _context = new QuanLyBanSachContext())
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
        public List<Customer> Filter(string name, string phonenumber)
        {
            var filterCondition = PredicateBuilder.New<Customer>();

            if (!String.IsNullOrWhiteSpace(name)) filterCondition.And(c => c.Name == name);
            if (!String.IsNullOrWhiteSpace(phonenumber)) filterCondition.And(c => c.PhoneNumber == phonenumber);

            if (String.IsNullOrWhiteSpace(name) &&
                String.IsNullOrWhiteSpace(phonenumber))
            {
                filterCondition.And(c => true);
            }
            using (var _context = new QuanLyBanSachContext())
            {
                return _context.Customers
                                     .Where(filterCondition)
                                     .OrderByDescending(c => c.CreateAt)
                                     .ToList();
            } 
        }
    }
}
