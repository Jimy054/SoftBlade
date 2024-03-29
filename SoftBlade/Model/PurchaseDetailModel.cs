﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBlade.Model
{
    class PurchaseDetailModel
    {
        public int PurchaseDetailID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public float PriceWithoutIVA { get; set; }
        public float IVA { get; set; }

        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public string Observation { get; set; }
        [ForeignKey("Purchase")]
        public int PurchaseID { get; set; }
        public ICollection<PurchaseModel> Purchase { get; set; }

        [ForeignKey("Prdocut")]
        public int ProductID { get; set; }
        public ICollection<ProductModel> Product { get; set; }
    }
}
