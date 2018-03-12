using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDS.Models
{
    public class UserExportModel
    {
        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        public int ShareId { get; set; }

        public string ShareType { get; set; }

        public string ShareBarcode { get; set; }

        public string UserShareCode { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserMale { get; set; }

        public string UserEmail { get; set; }

        public string UserDateOfBirth { get; set; }

        public string UserLocation { get; set; }

        public string UserPhone { get; set; }

    }
}