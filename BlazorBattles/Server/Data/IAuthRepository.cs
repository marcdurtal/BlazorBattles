﻿using System;
using System.Collections.Generic;
using System.Linq;
using BlazorBattles.Shared;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<bool> UserExists(string email);
    }
}
