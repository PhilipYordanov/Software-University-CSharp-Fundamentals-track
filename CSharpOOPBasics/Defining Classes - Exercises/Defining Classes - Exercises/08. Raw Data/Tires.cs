namespace _08.Raw_Data
{
    public class Tires
    {
        private int tiresAge;
        private double tiresPressure;
       
        public double TiresPressure
        {
            get
            {
                return this.tiresPressure;
            }
            set
            {
                this.tiresPressure = value;
            }
        }
      
        public Tires(int age , double pressure)
        {
            this.tiresAge = age;
            this.TiresPressure = pressure;
        }
    }
}
