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
        public class Car
        {

            private int year;
            private string make;
            private string model;


            public string Make
            {
                get { return make}
                set { make = value }

            }
            public string Model
            {
                get { return model}
                set { model = value }
            }
            public int Year
            {
                get { return year}
                set { year = value }
            }

            public Car(int speedLevel, string direction, bool isPoweredOn)
            {
                this.make = "";
                this.model = "";
                this.year = 1;
            }

            public override string ToString() => $"Make: {make}, Model: {model}, Year: {year}";
        }
        static void Main()
        {
            CeilingFan myFan = new CeilingFan(2, "Counterclockwise", true);
            Console.WriteLine(myFan.ToString());
            Console.ReadLine();
        }
    }
}
