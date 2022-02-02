using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;
using TecGurusUAMCommon.Interfaces;

namespace TecGurusUAMCommon.Services
{
    public class GroupService : IGroupService
    {
        private readonly IEfRepository<Group> _groupsRepository;
        public GroupService(IEfRepository<Group> groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }


        public IEnumerable<Group> GetGroups()
        {
            return _groupsRepository.GetAll();
        }

        public void CreateGroup(Group group)
        {
            _groupsRepository.Create(group);
            _groupsRepository.Save();
        }

        public void DeleteGroup(Group group)
        {
            _groupsRepository.Delete(group);
            _groupsRepository.Save();
        }
        public Group GetGroup(int Id)
        {
            return _groupsRepository.GetById(Id);
        }
    }
}
    