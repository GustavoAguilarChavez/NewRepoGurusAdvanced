using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;

namespace TecGurusUAMCommon.Interfaces
{
    public interface IGroupService
    {
        IEnumerable<Group> GetGroups();
        void CreateGroup(Group group);
        void DeleteGroup(Group group);
        Group GetGroup(int Id);
    }
}
