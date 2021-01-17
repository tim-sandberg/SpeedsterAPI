﻿using SpeedsterAPI.Models;
using SpeedsterAPI.Models.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedsterAPI.Interfaces
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task Login(Login model);
        Task Logout();
        Task Register(AddUser model);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }
}