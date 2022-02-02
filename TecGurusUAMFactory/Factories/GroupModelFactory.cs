using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusUAMCommon.Entities;
using TecGurusUAMCommon.Interfaces;
using TecGurusUAMFactory.Interfaces;
using TecGurusUAMModels;

namespace TecGurusUAMFactory.Factories
{
    public class GroupModelFactory : IGroupModelFactory
    {
        #region Properties
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;
        #endregion

        public GroupModelFactory(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public List<GroupModel> GetGroups()
        {
            var listGroup = _groupService.GetGroups().ToList();
            var LitsGroupModel = _mapper.Map<List<GroupModel>>(listGroup);
            return LitsGroupModel;
        }


        //SELECT SCOPE_IDENTITY() 
        public void CreateGroup(GroupModel groupModel)
        {
            //Con autoMapper
            var group = _mapper.Map<Group>(groupModel);
            //A mano
            //Group group = new Group();
            //group.GroupId = groupModel.GroupId;
            //group.Name = groupModel.Name;

            _groupService.CreateGroup(group);
        }

        public void DeleteGroup(GroupModel groupModel)
        {
            var group = _mapper.Map<Group>(groupModel);
            _groupService.DeleteGroup(group);

        }

        public GroupModel GetGroupModel(int Id)
        {
            var group = _groupService.GetGroup(Id);
            var groupModel = _mapper.Map<GroupModel>(group);
            return groupModel;

        }
    }
}