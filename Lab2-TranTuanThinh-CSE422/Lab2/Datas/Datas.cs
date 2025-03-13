using Lab2.DefaultEnums;
using Lab2.Models;

namespace Lab2.Datas
{
    public class Datas
    {
        public static List<Category> CategoryList { get; set; } = new List<Category>
        {
            new Category { Id = 1, Name = "Technology" },
            new Category { Id = 2, Name = "Home & Living" },
        };

        public static List<Device> DeviceList { get; set; } = new List<Device>
        {
            new Device
            {
                Id = 1,
                Name = "Smartphone",
                Code = 1101,
                CategoryId = 1,
                Status = DeviceStatus.INUSE,
                EntryDate = DateTime.UtcNow.AddDays(-8),
                Category = CategoryList.FirstOrDefault(c => c.Id == 1)
            },
            new Device
            {
                Id = 2,
                Name = "Desk Lamp",
                Code = 2101,
                CategoryId = 2,
                Status = DeviceStatus.INUSE,
                EntryDate = DateTime.UtcNow.AddDays(-12),
                Category = CategoryList.FirstOrDefault(c => c.Id == 2)
            },
        };

        public static List<User> UserList { get; set; } = new List<User>
        {
            new User { Id = 1, FullName = "John Doe", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
            new User { Id = 2, FullName = "Jane Smith", Email = "jane.smith@example.com", PhoneNumber = "098-765-4321" },
            new User { Id = 3, FullName = "Alice Johnson", Email = "alice.johnson@example.com", PhoneNumber = "555-123-4567" }
        };
    }
}
