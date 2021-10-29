using System;

namespace Dental_clinic_management
{
    class session
    {
        public int session_id { get; set; }
        public String start_time { get; set; }
        public String end_time { get; set; }
        public String x_ray_image { get; set; }
        public double Payment_amount { get; set; }
        public double discount_value { get; set; }
        public double price { get; set; }
        public String Patient_id { get; set; }
        public String Doctor_id { get; set; }
        public String room_id { get; set; }
        public String Period_id { get; set; }
        public String Medicine_id { get; set; }
        public String Notes { get; set; }


        public session(
        int session_id,
        String start_time,
        String end_time,
        String x_ray_image,
        double Payment_amount,
        double discount_value,
        double price,
        String Patient_id,
        String Doctor_id,
        String room_id,
        String Period_id,
        String Medicine_id,
        String Notes

        )
        {
            this.session_id = session_id;
            this.start_time = start_time;
            this.end_time = end_time;
            this.x_ray_image = x_ray_image;
            this.Payment_amount = Payment_amount;
            this.discount_value = discount_value;
            this.price = price;
            this.Patient_id = Patient_id;
            this.Doctor_id = Doctor_id;
            this.room_id = room_id;
            this.Period_id = Period_id;
            this.Medicine_id = Medicine_id;
            this.Notes = Notes;
        }
    }
}
