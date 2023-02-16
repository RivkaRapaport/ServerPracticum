using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;

namespace MyProject.WebAPI.Models
{
    public class UserModel
    {
        public string Family { get; set; }
        public string Name { get; set; }
        public string Identity { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }
        public int UserHmoId { get; set; }


    }
}
