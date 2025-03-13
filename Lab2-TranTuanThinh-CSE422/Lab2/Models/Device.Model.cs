using Lab2.DefaultEnums;

namespace Lab2.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int CategoryId { get; set; }
        public DeviceStatus Status { get; set; }
        public DateTime EntryDate { get; set; }
        public Category? Category { get; set; }

        public Device()
        {
            EntryDate = DateTime.UtcNow;
        }

        public Device(int id, int categoryId, string name, int code, DeviceStatus status)
        {
            Id = id;
            CategoryId = categoryId;
            Name = name;
            Code = code;
            Status = status;
            EntryDate = DateTime.UtcNow;
        }
    }
}
