using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\abelm\Desktop\c-sharp-basics\Lesson22\Example.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (FileNotFoundException) 
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly!");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory C:\\Lesson22 exist!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}
