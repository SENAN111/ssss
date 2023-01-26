using lumia.Models.Base;

namespace lumia.Models
{
    public class Position:BaseEntitiyName
    {
     
        public ICollection<Employee> Employees { get; set; }
    }
}
