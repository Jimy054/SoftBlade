using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBlade.Model
{
    class SaleDetailModel
    {
        public int SaleDetailID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public string Observation { get; set; }

        [ForeignKey("Sale")]
        public int SaleID { get; set; }
        public ICollection<SaleModel> Sale { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public ICollection<ProductModel> Product { get; set; }
    }
}
