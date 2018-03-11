using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS.Entities
{
    public class PhoneVerificationToken : BaseEntity
    {
        public string PhoneNumber { get; set; }

        public int Code { get; set; }

        public bool Verified { get; set; }
    }
}
