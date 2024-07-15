
namespace Stuffmanagement2.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private List<Staff> _staffs = null;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff() { Id = 1, FirstName = "Dell", LastName = "Laptop", Email = "dell.com", Department = "Technic" },
                new Staff() { Id = 2, FirstName = "Lenovo", LastName = "PC", Email = "lenovo.com", Department = "Computer" },
                new Staff() { Id = 3, FirstName = "Acer", LastName = "Monitor", Email = "acer.com", Department = "Screen" }
            };
        }

        public Staff Get(int id)
        {
           return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }
    }
}
