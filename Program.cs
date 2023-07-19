using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace A10
{
    public class operations
    {

        public static void create()
        {
            string path = "D:\\";
            Console.WriteLine("Enter File name");
            string fname = Console.ReadLine();
            string fpath = path + fname;

            if (File.Exists(fpath))
            {

                Console.WriteLine("file already exis");
            }
            else
            {
                string result = " Go Ahead file created";
                File.Create(fpath);
                Console.WriteLine(fpath);

                Console.WriteLine("file created ");

            }


        }
        public static void Read()
        {
            StreamReader sr;
            Console.WriteLine("enter file path to read");
            string fpath = Console.ReadLine();
            sr = new StreamReader(fpath);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();

        }
        public static void append()
        {
            Console.WriteLine("enter file path");
            string fpath = Console.ReadLine();
            if (File.Exists(fpath))
            {

                StreamWriter sw = File.AppendText(fpath);
                Console.WriteLine("enter line you want to append");
                sw.WriteLine(Console.ReadLine());
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Text Appended");
            }
            else
            {
                Console.WriteLine("the file is not exist");
            }
        }
        public static void delete()
        {
            Console.WriteLine("enter path");
            string path = Console.ReadLine();
            Console.WriteLine("file name to Delete");
            string fname = Console.ReadLine();
            string fpath = path + fname;
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
                Console.WriteLine("file deleted successfully");
            }
            else
            {
                Console.WriteLine("file not exist");
            }



        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        repeat:
            Console.WriteLine("Enter Your Choice ");
            Console.WriteLine("Enter 1 for File Creation\nEnter 2 for File Read\nEnter 3 for File Append\nEnter 4 for File Delete");
            int ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    operations.create();
                    break;
                case 2:
                    operations op = new operations();
                    operations.Read();
                    break;
                case 3:

                    operations.append();
                    break;
                case 4:

                    operations.delete();
                    break;

                default:
                    Console.WriteLine("Choice not found");
                    break;

            }
            Console.WriteLine("would you like to continue if yes press y for no press any key");
            var cont = Console.ReadLine();
            if (cont == "y")
            {
                goto repeat;
            }
            else
            {
                Console.WriteLine("thank you for using my code");
                Console.ReadKey();
            }
        }
    }
}