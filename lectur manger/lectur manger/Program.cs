using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;



namespace lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
        nazanm:
            printingthelecture();
            int num = Convert.ToInt32(Console.ReadLine());
            switchcase(num);
            goto nazanm;
        }
        static void printingthelecture()
        {
            string folderPath = @"C:\Users\reban\darsakan";
            int i = 0;

            if (Directory.Exists(folderPath))
            {
                string[] subfolders = Directory.GetDirectories(folderPath);


                foreach (string subfolder in subfolders)
                {
                    i++;
                    string folderName = Path.GetFileName(subfolder);
                    Console.WriteLine($"{i} - {folderName}");
                }
            }
            else
            {
                Console.WriteLine($"The folder '{folderPath}' does not exist.");
            }

        }

        static void switchcase(int n)
        {
            int i_tow = 0;

            switch (n)
            {
                case 2:
                    digital();
                    break;
                case 3:
                    it();
                    break;
                case 4:
                    math();
                    break;
                case 5:
                    programing();
                    break;
                default:
                    Console.WriteLine("the number that has been enterd is wrong");
                    break;
            }
        }
        static void digital()
        {
            string folderPathop = @"C:\Users\reban\darsakan\digital";
            if (Directory.Exists(folderPathop))
            {

                string[] allFiles = Directory.GetFiles(folderPathop);


                foreach (string file in allFiles)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                }
                int choice = int.Parse(Console.ReadLine());

                if (choice > 0 && choice <= allFiles.Length)
                {
                    string selectedFile = allFiles[choice - 1];

                    try
                    {
                        // Open the selected file with its default application
                        Process.Start(selectedFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"An error occurred while opening the file: {e.Message}");
                    }
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine($"The folder '{folderPathop}' does not exist.");
            }

        }


      
        static void it()
        {
            string folderPathop = @"C:\Users\reban\darsakan\it";
            if (Directory.Exists(folderPathop))
            {

                string[] allFiles = Directory.GetFiles(folderPathop);


                foreach (string file in allFiles)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                }
                int choice = int.Parse(Console.ReadLine());

                if (choice > 0 && choice <= allFiles.Length)
                {
                    string selectedFile = allFiles[choice - 1];

                    try
                    {
                        // Open the selected file with its default application
                        Process.Start(selectedFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"An error occurred while opening the file: {e.Message}");
                    }
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine($"The folder '{folderPathop}' does not exist.");
            }
        }
      
        static void math()
        {
            string folderPathop = @"C:\Users\reban\darsakan\math";
            if (Directory.Exists(folderPathop))
            {

                string[] allFiles = Directory.GetFiles(folderPathop);


                foreach (string file in allFiles)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                }
                int choice = int.Parse(Console.ReadLine());

                if (choice > 0 && choice <= allFiles.Length)
                {
                    string selectedFile = allFiles[choice - 1];

                    try
                    {
                        // Open the selected file with its default application
                        Process.Start(selectedFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"An error occurred while opening the file: {e.Message}");
                    }
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine($"The folder '{folderPathop}' does not exist.");
            }
        }
        static void programing()
        {
            string folderPathop = @"C:\Users\reban\darsakan\programming";
            if (Directory.Exists(folderPathop))
            {

                string[] allFiles = Directory.GetFiles(folderPathop);


                foreach (string file in allFiles)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                }
                int choice = int.Parse(Console.ReadLine());

                if (choice > 0 && choice <= allFiles.Length)
                {
                    string selectedFile = allFiles[choice - 1];

                    try
                    {
                        // Open the selected file with its default application
                        Process.Start(selectedFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"An error occurred while opening the file: {e.Message}");
                    }
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine($"The folder '{folderPathop}' does not exist.");
            }
        }
    }
}

