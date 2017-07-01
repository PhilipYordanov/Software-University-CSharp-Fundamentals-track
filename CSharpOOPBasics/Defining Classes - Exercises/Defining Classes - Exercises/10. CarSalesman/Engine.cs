namespace _10.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        //optional
        private string displacement;
        private string efficiency;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public string Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.displacement = "n/a";
            this.efficiency = "n/a";
        }
    }
}
