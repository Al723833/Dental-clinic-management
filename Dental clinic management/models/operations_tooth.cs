namespace Dental_clinic_management
{
    class operations_tooth
    {
        public int operations_tooth_id { get; set; }
        public int session_id { get; set; }
        public int Teeth_id { get; set; }
        public int Operations_id { get; set; }
        public int number_pieces { get; set; }
        public double price { get; set; }


        public operations_tooth(int operations_tooth_id,
            int session_id,
            int Teeth_id,
            int Operations_id,
            int number_pieces,
            double price)
        {
            this.operations_tooth_id = operations_tooth_id;
            this.session_id = session_id;
            this.Teeth_id = Teeth_id;
            this.Operations_id = Operations_id;
            this.number_pieces = number_pieces;
            this.price = price;

        }
    }
}
