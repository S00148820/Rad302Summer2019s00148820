using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad302Summer2019DataLayers00148820
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime? RegisteredOn { get; set; }
        public float CurrentCreditBalace { get; set; }
    }
}
