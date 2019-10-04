using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBlade.Model
{
    class SaleModel
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public float SaleTotal { get; set; }
        public string SaleReference { get; set; }
        public string Serie { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public ICollection<ClientModel> Client { get; set; }
    }
}
