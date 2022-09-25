namespace Inheritance
{

        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void Copy()
            {
                Console.WriteLine("Object Copied to CLipboard!");
            }
            public void Duplicate()
            {
                Console.WriteLine("Object has been duplicated");
            }
        }
}