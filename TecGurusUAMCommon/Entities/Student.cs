using System;
using System.Collections.Generic;

#nullable disable

namespace TecGurusUAMCommon.Entities
{
    public partial class Student: BaseEntity
    {
        public int StudentId { get; set; }
        public int? Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
