using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class warehouse_invoice
    {
        public int warehouse_invoice_id { get; set; }
        public int warehouse_id { get; set; }
        public int invoice_number { get; set; }
        public int Quantity { get; set; }
        public double price { get; set; }
        public double Amount_paid { get; set; }
        public String Notes { get; set; }
        public int material_id { get; set; }


        public warehouse_invoice(int warehouse_invoice_id,
            int warehouse_id,
            int invoice_number,
            int Quantity,
            double price,
            double Amount_paid,
            String Notes,
            int material_id)
        {
            this.warehouse_invoice_id = warehouse_invoice_id;
            this.warehouse_id = warehouse_id;
            this.invoice_number = invoice_number;
            this.Quantity = Quantity;
            this.price = price;
            this.Amount_paid = Amount_paid;
            this.Notes = Notes;
            this.material_id = material_id;
        }
    }
}
