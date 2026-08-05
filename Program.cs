namespace Module3
{
    internal class Program
    {
        public class CeilingFan
        {
            
            private int speedLevel;      
            private string direction;    
            private bool isPoweredOn;    


            public CeilingFan()
            {
                speedLevel = 0;
                direction = "Counterclockwise";
                isPoweredOn = false;
            }

            public void PowerOn()
            {
                isPoweredOn = true;
                Console.WriteLine("Fan is now ON.");
            }

            public void PowerOff()
            {
                isPoweredOn = false;
                speedLevel = 0;
                Console.WriteLine("Fan is now OFF.");
            }

            public void SetSpeed(int level)
            {
                if (isPoweredOn && level >= 0 && level <= 3)
                {
                    speedLevel = level;
                    Console.WriteLine($"Fan speed set to level {level}.");
                }
                else
                {
                    Console.WriteLine("Invalid speed or fan is off.");
                }
            }
            public void ReverseDirection()
            {
                direction = (direction == "Clockwise") ? "Counterclockwise" : "Clockwise";
                Console.WriteLine($"Fan direction changed to {direction}.");
            }
        }
        static void Main()
        {
            CeilingFan fan = new CeilingFan();
            Console.WriteLine("Ceiling Fan");
            Console.WriteLine("");
            Console.WriteLine("1. ");
            Console.ReadLine();
        }
    }
}
