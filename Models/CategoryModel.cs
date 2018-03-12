using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MDS.Models
{

    public class CategoryModel 
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public string ObjDescription { get; set; }
    }
}
