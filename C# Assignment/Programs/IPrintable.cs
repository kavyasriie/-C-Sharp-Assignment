using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Weekly_Assesment2
{
public interface IPrintable
    {
        void Print();
    }
    public interface ISerializable
    {
        void SaveToFile(string filename);
    }
    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public void Print()
        {
            Console.WriteLine($"Report: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        // Implementing ISerializable
        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, $"Report: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filename}");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        Report report = new Report("Monthly Sales", "Sales increased by 20% this month.");

    //        // Using IPrintable interface
    //        report.Print();

    //        // Using ISerializable interface
    //        report.SaveToFile("report.txt");
    //    }
    //}
}