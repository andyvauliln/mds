using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDS.Models
{
    public class PhoneVerificationTokenModel 
    {
        public int ObjId { get; set; }

        public string PhoneNumber { get; set; }

        public int Code { get; set; }

        public int AttempsAmount { get; set; }

        public bool Verified { get; set; }
    }
}