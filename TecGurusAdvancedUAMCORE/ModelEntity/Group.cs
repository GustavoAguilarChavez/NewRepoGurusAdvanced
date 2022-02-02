using System;
using System.Collections.Generic;

#nullable disable

namespace TecGurusAdvancedUAMCORE.ModelEntity
{
    public partial class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
