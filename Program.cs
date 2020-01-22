using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "Yes";
            double length;
            double width;
            double area;
            double per;
            string roomSize;
            double height;
            double vol;

            while (again == "Yes" || again == "Y" || again == "y")
             {

                //Ask User for input
                Console.Write("Enter the length of the room: ");
                string input = Console.ReadLine();
                length = double.Parse(input);

                Console.Write("Enter the width of the room: ");
                input = Console.ReadLine();
                width = double.Parse(input);

                Console.Write("Enter the height of the room: ");
                input = Console.ReadLine();
                height = double.Parse(input);

                //Calculate
                area = length * width;
                per = (length * 2) + (width * 2);
                vol = length * width * height;

                //Check Room Size
                if (area >= 650)
                {
                    roomSize = "Large";
                }
                else if (area > 250)
                {
                    roomSize = "Medium";
                }
                else
                {
                    roomSize = "Small";
                }

                //Output data
                Console.WriteLine("The size of your room is " + roomSize);

                Console.WriteLine("The area of the room is " + area);
                Console.WriteLine("The perimiter of the room is " + per);
                Console.WriteLine("The volume of the room is " + vol);

                Console.WriteLine("Would you like to measure another room?");
                Console.WriteLine("Type Yes or Y to enter more values. Any other entry to exit");
                again = Console.ReadLine();
            }
            //Exit Message
            Console.WriteLine("Thank you for using the Room Calculator tool!");

        }
    }
}
