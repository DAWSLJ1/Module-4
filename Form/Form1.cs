namespace Module4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Car car1 = new Car("Toyota", "Corrola", 2020);
            Car car2 = new Car("Ford", "Mustang", 2022);
            Car car3 = new Car("Honda", "Civic", 2019);

            MessageBox.Show(car1.ToString());
            MessageBox.Show(car2.ToString());
            MessageBox.Show(car3.ToString());

        }
    }
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
    //public class Car
    //{

    //    //private int year;
    //    //private string make;
    //    //private string model;



    //    //public string Make
    //    //{
    //    //    get => make;
    //    //    set => make = value;

    //    //}
    //    //public string Model
    //    //{
    //    //    get => model;
    //    //    set => model = value;
    //    //}
    //    //public int Year
    //    //{
    //    //    get => year;
    //    //    set => year = value;
    //    //}


    //    public override string ToString() => $"Make: {make}, Model: {model}, Year: {year}";

    //    public Car(string make, string model, int year)
    //    {
    //        this.model = model;
    //        this.make = make;
    //        this.year = year;
    //    }
    

    //public void CarDisplay(object sender, EventArgs e)
    //    {
    //        Car car1 = new Car("Toyota", "Corrola", 2020);
    //        Car car2 = new Car("Ford", "Mustang", 2022);
    //        Car car3 = new Car("Honda", "Civic", 2019);

    //        MessageBox.Show($"Make: {car1.make}, Model: {car1.model}, Year: {car1.year}");
    //        MessageBox.Show($"Make: {car2.make}, Model: {car2.model}, Year: {car2.year}");
    //        MessageBox.Show($"Make: {car3.make}, Model: {car3.model}, Year: {car3.year}");
    //    }
    //}
}
