using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitoriaMariaStudio.Domain.Entities
{
    public class Role
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Role()
        { }

        public Role(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}