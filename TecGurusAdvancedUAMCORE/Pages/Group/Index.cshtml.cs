using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecGurusUAMFactory.Interfaces;
using TecGurusUAMModels;
using Entities = TecGurusUAMCommon.Entities;

namespace TecGurusAdvancedUAMCORE.Pages.Group
{
    public class IndexModel : PageModel
    {
        private readonly IGroupModelFactory _groupModelFactory;

        public List<GroupModel> Groups { get; set; }
        public IndexModel(IGroupModelFactory groupModelFactory)
        {
            _groupModelFactory = groupModelFactory;
        }

        public void OnGet()
        {
            Groups = _groupModelFactory.GetGroups();
        }
    }
}
