using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;
using TecGurusUAMModels;

namespace TecGurusUAMFactory.Interfaces
{

    public interface IGroupModelFactory
    {
        List<GroupModel> GetGroups();
        void CreateGroup(GroupModel groupModel);
        void DeleteGroup(GroupModel groupModel);
        GroupModel GetGroupModel(int Id);
    }
}