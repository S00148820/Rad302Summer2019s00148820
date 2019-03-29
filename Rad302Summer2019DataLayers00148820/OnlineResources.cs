using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rad302Summer2019DataLayers00148820
{
    public class OnlineResources
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResourceID { get; set; }
        public int QuantitySold { get; set; }
        public string Title { get; set; }
        public float UnitCost { get; set; }
        public enum ResourceType { Music, Movie, AudioBook };
    }
}
