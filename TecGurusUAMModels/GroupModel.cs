using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusUAMModels
{
    public class GroupModel
    {
        [Display(Name = "Id de grupo")]
        public int GroupId { get; set; }
        [Display(Name="Nombre grupo")]
        [Required(ErrorMessage = "*Required")]
        [StringLength(10, ErrorMessage = "Máximo diez digitos")]
        public string Name { get; set; }
    }
}
