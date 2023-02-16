using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string Identity { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }
        public Hmo Hmo { get; set; }
        public int HmoId { get; set; }

    }
}
