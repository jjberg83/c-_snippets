namespace NonPrimitiveProject;

public struct Punkt
    {
        public float x;
        public float y;

        public Punkt(float theX, float theY)
        {
            x = theX;
            y = theY;
        }

        

        public void Posisjon()
        {
            Console.WriteLine($"Min posisjon er {Convert.ToString(x)}, {y.ToString()}");
        }
    }
