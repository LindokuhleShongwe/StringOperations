

namespace stringOperations
{

    class Program
    {
        static Text text = new Text("");//Declare and initialise the text object on a above scope level.
        public static void Main()
       {
            //Changing the Console colors
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            //Getting user text
            Console.Write("Enter text :");
            string Usertext = Console.ReadLine();

            Usertext.ToLower();//Convert all text to lower case
            Console.WriteLine(ShowMenuOperations());//Print the Operations to the user by calling the ShowOper...method
        
            text = new Text(Usertext); //giving the text object the text from the user;

            //asking user to select operations
            Console.Write("\nWhich operations to perform ?  (1) (2) (3) (1 & 2) (1 & 3) (2 & 3) (1 , 2 & 3) \n");
            try
            {
                int Input = int.Parse(Console.ReadLine());
                Menu(Usertext, Input);

            }//Handling the error if use enters a invalid input
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress any key to restart the program");//User can restart the program
            Console.ReadKey();

            Console.Clear();//clearing the console
            Main();//restarting the program


        }
        public static void Menu(string UserText, int Input)//Prepares the menu so operations are peformed successfully
        {

          
     
            switch (Input)
            {
                case 1:
                    DuplicatesList(); break;
                case 2: Console.WriteLine(text.VowelCount()); break;
                case 3: Console.WriteLine(text.CheckVowels()); break;


                case 12:
                    DuplicatesList();
                    Console.WriteLine(text.VowelCount()); break;


                case 13:
                    DuplicatesList();
                    Console.WriteLine(text.CheckVowels()); break;


                case 123:// performs all operations
                    DuplicatesList();
                    Console.WriteLine(text.VowelCount());
                    Console.WriteLine(text.CheckVowels()); break;


                case 23:
                    Console.WriteLine(text.VowelCount());
                    Console.WriteLine(text.CheckVowels()); break;

                default:
                    Console.WriteLine("Please Make sure you have selected a valid opration"); break;

            }



        }
        public static string ShowMenuOperations()//Display the operatins available to the user.
        {
            return $"\n====================================================================" +
                 "\n1.Duplicate check.\n" +
                    "2.Count the number of unique vowel\n" +
                    "3.Output if there are more unique vowels or unique non vowels" +
                    "\n====================================================================";

        }
        public static  void DuplicatesList()//sets the list of duplicates and return the desired results
        {
            List<char> DuplicatesList = text.CheckDuplicates();

            if (DuplicatesList.Count != 0)//checks if the list is not null
            {
                Console.Write("\nWe have the found the followig duplicates : ");
                foreach (var c in DuplicatesList)
                {
                    Console.Write(c.ToString());
                }
            }
            else
                Console.WriteLine("\nNo duplicate values were found");
        }

    }

}