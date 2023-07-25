using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProject_1._9
{
        internal class Program
        {
            static void Main(string[] args)
            {
                string filePath = @"D:\DotNet\Project_1.9\ConAppProject-1.9\Student.txt";
                try
                {

                    Console.WriteLine("Student Data:");
                    Console.WriteLine("-------------");
                    string fileContent = File.ReadAllText(filePath);
                    Console.WriteLine(fileContent);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }