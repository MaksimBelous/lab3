namespace lab3.library
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "{x: " + X.ToString() + ", y: " + Y.ToString() + "}";
        }
    }
}
