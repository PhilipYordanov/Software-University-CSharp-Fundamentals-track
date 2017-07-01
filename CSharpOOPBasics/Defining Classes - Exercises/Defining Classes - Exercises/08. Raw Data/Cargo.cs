namespace _08.Raw_Data
{
    public class Cargo
    {
        private int weigth;
        private string type;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Cargo(int weigth,string type)
        {
            this.weigth = weigth;
            this.Type = type;
        }
    }
}
