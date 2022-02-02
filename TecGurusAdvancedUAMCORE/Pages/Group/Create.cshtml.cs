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
    public class CreateModel : PageModel
    {

        [BindProperty]
        public GroupModel GroupModel { get; set; }

        private readonly IGroupModelFactory _groupModelFactory;
        public CreateModel(IGroupModelFactory groupModelFactory)
        {
            _groupModelFactory = groupModelFactory;
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _groupModelFactory.CreateGroup(GroupModel);

            return RedirectToPage("./Index");

        }


    }
}
