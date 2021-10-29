using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class materials
    {
        public int material_id { get; set; }
        public String material_name { get; set; }
        public String date_of_purchase { get; set; }
        public int Quantity { get; set; }
        public double total_price { get; set; }

        public materials(int material_id, String material_name, String date_of_purchase, int Quantity,  double total_price)
        {
            this.material_id = material_id;
            this.material_name = material_name;
            this.date_of_purchase = date_of_purchase;
            this.Quantity = Quantity;
            this.total_price = total_price;

        }
    }
}
