using Aspose.Diagram;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Diagram for .NET API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. If you do not wish to use NuGet, you can manually download Aspose.Diagram for .NET API from http://www.aspose.com/downloads, install it and then add its reference to this project. For any issues, questions or suggestions please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace AsposeSourceCode.AsposeVSVSTO
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"..\..\..\..\Sample Files\";
            string srcFileName = FilePath + "Sample Diagram.vsdx";
            
            //Call the diagram constructor to load diagram from a VDX file
            Diagram vdxDiagram = new Diagram(srcFileName);

            foreach (Aspose.Diagram.Connect connector in vdxDiagram.Pages[1].Connects)
            {
                //Display information about the Connectors
                Console.WriteLine("\nFrom Shape ID : " + connector.FromSheet);
                Console.WriteLine("To Shape ID : " + connector.ToSheet);
            }

            Console.ReadLine();
        }
    }
}
