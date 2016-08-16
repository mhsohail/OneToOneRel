namespace OneToOneRel
{
    public class AmphibiousVehicle : Vehicle, Boat
    {
        private int __Id { get; set; }
        private string __Name { get; set; }
        private decimal __Price { get; set; }

        public int Id
        {
            get
            {
                return __Id;
            }

            set
            {
                __Id = value;
            }
        }

        public string Name
        {
            get
            {
                return __Name;
            }

            set
            {
                __Name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return __Price;
            }

            set
            {
                __Price = value;
            }
        }
    }
}
