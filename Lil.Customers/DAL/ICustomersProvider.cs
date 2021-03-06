﻿using Lil.Customers.Models;
using System.Threading.Tasks;

namespace Lil.Customers.DAL
{
    public interface ICustomersProvider
    {
        Task<Customer> GetAsync(string id);
    }
}
