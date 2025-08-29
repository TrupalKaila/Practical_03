namespace Practical_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //Object of Team is created
            Team team = new Team("Blaster");
            //Printing teaminfo by calling TeamInfo method
            Console.WriteLine(team.TeamInfo());


            //Polymorphism
            //Bird object is created
            Bird myBird = new Bird();
            //This causes compile time error as we cannot create parent object and assign it to child
            Duck myDuck = new Bird();
            //Solution for above error
            //Can be fixed if we create a child object and assign it to parent
            //Bird myDuck = new Duck();

            myBird.Voice();
            myDuck.Voice();

            //Abstraction
            //Object of laptop is created
            Laptop laptop = new Laptop();
            //assigned value to private variable using property
            laptop.Brand = "Asus";
            laptop.Model = "VivoBook";
            //Calling LaptopDetails method to print laptop details
            laptop.LaptopDetails();
            //This will cgive compile time error due to protection level 
            laptop.MotherBoardInfo();
            //Solution for above error
            //We are accessing the private method outside the class
            //laptop.getMotherBoardInfo();


        }
    }
}
