using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;
using TecGurusUAMModels;

namespace TecGurusAdvancedUAMCORE.Utils
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            //Entity to Model
            CreateMap<Group, GroupModel>();
            //Model to Entit
            CreateMap<GroupModel, Group>();
        }

    }
}
