// Simple trip planner written in C#

internal class Program
{
    static void Main(string[] args)
    {
        // welcome user and ask for location, save user input
        // also check for correct input, otherwise return to loop
        Console.WriteLine("***************  Welcome to the Travel Buddy  ***************");
        Console.WriteLine("-------------------------------------------------------------");

        string userAnswer = "";
        do
        {
            Console.WriteLine();
            string userLocationChoice = "";

            do
            {
                if (userLocationChoice != "bodrum" && userLocationChoice != "marmaris" && userLocationChoice != "cesme"
                    && userLocationChoice != "")
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine();
                }

                Console.WriteLine("- Which location do you want to visit?");
                Console.WriteLine("- 1) Bodrum (Package starting price 4000 TL)");
                Console.WriteLine("- 2) Marmaris (Package starting price 3000 TL)");
                Console.WriteLine("- 3) Cesme (Package starting price 5000 TL)");
                Console.Write("Write your travel city choice: ");
                userLocationChoice = Console.ReadLine().ToLower();
            } while (userLocationChoice != "bodrum" && userLocationChoice != "marmaris" && userLocationChoice != "cesme");
            Console.WriteLine();

            // give short information about the chosen location
            string bodrumInfoHeader = "Short information about Bodrum:";
            string bodrumInfo = "A lively coastal city in southwestern Turkey, Bodrum is famous for its vibrant nightlife, historic " +
                "landmarks like the Bodrum Castle, and beautiful beaches that attract sun-seekers and sailing enthusiasts alike.";

            string marmarisInfoHeader = "Short information about Marmaris:";
            string marmarisInfo = "Located on Turkey’s Turquoise Coast, Marmaris is known for its stunning beaches, crystal-clear waters, " +
                "and lively marina, making it a top destination for both relaxation and water activities like sailing and diving.";

            string cesmeInfoHeader = "Short information about Cesme:";
            string cesmeInfo = "Situated on the Aegean coast, Cesme offers pristine beaches, luxurious resorts, and a relaxed atmosphere, " +
                "known for its thermal springs and windsurfing opportunities, particularly at Alacati, a nearby town.";

            switch (userLocationChoice)
            {
                case "bodrum":
                    Console.WriteLine(bodrumInfoHeader);
                    Console.WriteLine(bodrumInfo);
                    Console.WriteLine();
                    break;

                case "marmaris":
                    Console.WriteLine(marmarisInfoHeader);
                    Console.WriteLine(marmarisInfo);
                    Console.WriteLine();
                    break;

                case "cesme":
                    Console.WriteLine(cesmeInfoHeader);
                    Console.WriteLine(cesmeInfo);
                    Console.WriteLine();
                    break;

                default:
                    break;
            }

            // ask user for number of people and save user input
            Console.Write("- How many people are in your group?: ");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // ask user which way they prefer to travel, and save user input
            // also check for correct input, otherwise return to loop
            int userTravelChoice = 1;
            do
            {
                if (userTravelChoice != 1 && userTravelChoice != 2)
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine();
                }

                Console.WriteLine("- Which way do you prefer to travel?");
                Console.WriteLine("- 1) By road (1500 TL per person round trip)");
                Console.WriteLine("- 2) By air (4000 TL per person round trip)");
                Console.Write("Your choice (1 or 2): ");
                userTravelChoice = Convert.ToInt32(Console.ReadLine());
            } while (userTravelChoice != 1 && userTravelChoice != 2);

            // calculate user travel and total trip cost
            int userTravelCost = userTravelChoice == 1 ? numberOfPeople * 1500 : numberOfPeople * 4000;
            int userLocationCost = userLocationChoice == "bodrum" ? 4000 : userLocationChoice == "marmaris" ? 3000 : 5000;
            int userTotalCost = userLocationCost * numberOfPeople + userTravelCost;

            // convert user city choice to uppercase
            userLocationChoice = char.ToUpper(userLocationChoice[0]) + userLocationChoice.Substring(1);

            // calculate total cost of travel and display it
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("You have chosen to travel to " + userLocationChoice + " with " + numberOfPeople + " people.");
            Console.WriteLine("The cost of your travel by " + (userTravelChoice == 1 ? "road" : "air") + " will be: " + userTravelCost + " TL for " + numberOfPeople + " people.");
            Console.WriteLine("The total cost of your vacation with chosen travel is: " + userTotalCost + " TL.");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Do you want to calculate another travel plan?(Y/N): ");
            userAnswer = Console.ReadLine().ToLower();
        }
        while (userAnswer == "y" || userAnswer == "yes");

        // end of program
        Console.WriteLine("Thank you for using Travel Buddy. Goodbye!");
    }
}