using lumia.Models;

namespace lumia.ViewModels.Home
{
    public class HomeVm
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}
