namespace part2_HW1
{
    public class Cars : Car
    {
        public static List<Car> listOfCars = new List<Car>()
        {
            { new Car() { Year = 1964, Brand = "Porsche", Model = "911", Color = "Green"} },
            { new Car() { Year = 1996, Brand = "Porsche", Model = "Boxster/Cayman", Color = "Yellow"} },
            { new Car() { Year = 2014, Brand = "Porsche", Model = "Macan", Color = "Blue"} },
            { new Car() { Year = 2019, Brand = "Porsche", Model = "Taycan", Color = "White"} }
        };
    }
}
