using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person: BaseEntity
    {
        public string Passport { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public List<DrivingCategory> DrivingCategories { get; set; } = new List<DrivingCategory>();

        public Person()
        { }

        public Person(int id, string passport, string fullName)
        {
            Id = id;
            Passport = passport;
            FullName = fullName;
        }

        public void AddDrivingCategory(IEnumerable<DrivingCategory> drivingCategories)
        {
            if (drivingCategories == null)
                throw new ArgumentException("drivingCategories is null");

            foreach (var drivingCategory in drivingCategories)
            {
                AddDrivingCategory(drivingCategory);
            }
        }

        public void AddDrivingCategory(DrivingCategory drivingCategory)
        {
            if (drivingCategory == null)
                throw new ArgumentException("drivingCategory is null");

            DrivingCategories.Add(drivingCategory);
        }

        public void RemoveDrivingCategory(DrivingCategory drivingCategory)
        {
            if (drivingCategory == null)
                throw new ArgumentException("drivingCategory is null");

            DrivingCategories.Remove(drivingCategory);
        }

        public override string ToString()
        {
            return this.FullName;
        }
    }
}
