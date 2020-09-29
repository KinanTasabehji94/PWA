﻿using PWA.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interface
{
    public interface IAccounts
    {
        Task<UserToken> Login(UserInfo userInfo);
        Task<UserToken> Register(UserInfo userInfo);
        Task<UserToken> RenewToken();
    }
}
