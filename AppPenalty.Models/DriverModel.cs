using System;

namespace AppPenalty.Models
{
    public class DriverModel
    {
        public string FullName { get; set; }

        public string Id { private set; get; }

        public DriverModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public DriverModel(string id, string fullname)
        {
            Id = id ?? Guid.NewGuid().ToString("N");
            FullName = fullname;
        }
    }
}
