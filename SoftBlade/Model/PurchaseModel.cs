using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBlade.Model
{
    class PurchaseModel
    {
        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public float PurchaseTotal { get; set; }
        public string PurchaseReference { get; set; }
        public string Serie { get; set; }
        [ForeignKey("Provider")]
        public int ProviderID { get; set; }
        public ProviderModel Provider { get; set; }
    }
}
