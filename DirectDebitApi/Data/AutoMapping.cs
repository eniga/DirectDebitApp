using System;
using System.Collections.Generic;
using AutoMapper;
using DirectDebitApi.Entities;

namespace DirectDebitApi.Data
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Users, UserDTO>();
            CreateMap<UserDTO, Users>();
        }
    }
}
