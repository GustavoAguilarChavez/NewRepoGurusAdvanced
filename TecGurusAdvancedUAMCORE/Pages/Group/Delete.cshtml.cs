using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecGurusUAMFactory.Interfaces;
using TecGurusUAMModels;

namespace TecGurusAdvancedUAMCORE.Pages.Group
{
    public class DeleteModel : PageModel
    {
        private readonly IGroupModelFactory _groupModelFactory;
        public DeleteModel(IGroupModelFactory groupModelFactory)
        {
            _groupModelFactory = groupModelFactory;
        }

        [BindProperty]
        public GroupModel GroupModel { get; set; }
        public void OnGet(int Id)
        {
            GroupModel = _groupModelFactory.GetGroupModel(Id);

        }

        public IActionResult OnPost()
        {
            var groupModel = GroupModel;
            _groupModelFactory.DeleteGroup(groupModel);
            return RedirectToPage("./Index");
        }
    }
}
