// User Input And Replace String 

namespace PracticePro1
{
  public class UserName
    {
        public static void DisplayUserName()
        {

            Console.WriteLine("Enter the UserName");
            string str = Console.ReadLine();

            int length = str.Length;
            Console.WriteLine("The Length Of User Name :" + length);

            if (length > 3)
            {
                Console.WriteLine("Hello " + str + " How Are You?");
            }
            else
            {
                Console.WriteLine("The User Name is less Than 3 ");
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                UserName.DisplayUserName();
            }
        }
    }
}