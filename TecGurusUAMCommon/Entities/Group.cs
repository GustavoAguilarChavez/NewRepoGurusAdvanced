using System;
using System.Collections.Generic;

#nullable disable

namespace TecGurusUAMCommon.Entities
{
    public partial class Group: BaseEntity
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
