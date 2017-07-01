namespace _09.Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double corX;
        private double corY;

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }
              
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }
              
        public double CorX
        {
            get
            {
                return this.corX;
            }
            private set
            {
                this.corX = value;
            }
        }
               
        public double CorY
        {
            get
            {
                return this.corY;
            }
            private set
            {
                this.corY = value;
            }
        }

        public Rectangle(string id, double width, double height, double corX, double corY)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.CorX = corX;
            this.CorY = corY;
        }

        public bool IntersectRectangles(Rectangle secondRectangle)
        {
            var W1 = this.width;
            var H1 = this.height;
            var X1 = this.corX;
            var Y1 = this.corY;

            var W2 = secondRectangle.width;
            var H2 = secondRectangle.height;
            var X2 = secondRectangle.corX;
            var Y2 = secondRectangle.CorY;

            if (X1 + W1 < X2 || X2 + W2 < X1 || Y1 + H1 < Y2 || Y2 + H2 < Y1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
