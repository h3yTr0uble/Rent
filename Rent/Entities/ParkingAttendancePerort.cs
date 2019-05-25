using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ParkingAttendancePerort
    {
        public string Address { get; set; }
        public int VisitsCount { get; set; }

        public ParkingAttendancePerort(string address, int visitsCount)
        {
            Address = address;
            VisitsCount = visitsCount;
        }
    }
}
