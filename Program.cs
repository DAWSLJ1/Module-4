using System.Xml.Linq;

namespace Module3
{
    internal class Program
    {
        public class CeilingFan
        {
            
            private int speedLevel;      
            private string direction;    
            private bool isPoweredOn;    


            public CeilingFan(int speedLevel, string direction, bool isPoweredOn)
            {
                this.speedLevel = 2;
                this.direction = "Counterclockwise";
                this.isPoweredOn = true;
            }

            public override string ToString() => $"Speed Level: {speedLevel}, Direction: {direction}, Powered On: {isPoweredOn}";
        }
        static void Main()
        {
            CeilingFan myFan = new CeilingFan(2, "Counterclockwise", true);
            Console.WriteLine(myFan.ToString());
            Console.ReadLine();
        }
    }
}
