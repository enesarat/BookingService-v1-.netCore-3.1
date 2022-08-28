﻿using BookingService.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookingService.DataAccess.Abstract
{
    public interface IGenericEntityDAL<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetAllItems();
        Task<T> GetItemById(int id);
        Task<T> InsertItem(T item);
        Task<T> UpdateItem(T item);
        Task DeleteItem(int id);
    }
}
