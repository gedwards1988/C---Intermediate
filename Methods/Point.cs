namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // if we have x and y points, pass as integers
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // if we have a point object
        public void Move(Point newLocation)
        {
            // Throw exception for null value
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}