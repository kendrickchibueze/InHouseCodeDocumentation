using System.Reflection;

namespace CodeDocumentation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.PrintColorMessage(ConsoleColor.Yellow, "************ Welcome to the In-House Code Documentation Tool********\n\n");




            InHouseCode.GetDocs();

           


        }
    }
}