using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insmart.Core.Enums
{
    public enum AppointmentStatus
    {
        Booked=0,
        Completed=1,
        CancelledByUser=2,
        CancelledByDoctor=3,
        CancelledByHospital=4
    }
}
