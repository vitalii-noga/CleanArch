﻿using System;
using System.Linq;
using Core.Gateways;

namespace Infrastructure.Gateways
{  
    public class UserGateway : IUserGateway
    {
        public Guid Add(DtoGUserInfo dto)
        {
            return Guid.Empty;
        }

        public DtoGUserInfo Retrieve(Guid id)
        {
            return new DtoGUserInfo();
        }

        public IQueryable<DtoGUserInfo> Retrieve(DtoGUserQuery dto)
        {
            return null;
        }

        public Guid Modify(DtoGUserModified dto)
        {
            return Guid.Empty;
        }

        public Guid Delete(Guid id)
        {
            return Guid.Empty;
        }
    }
}