using Aspose.Diagram;
using System.Drawing.Printing;

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
            
            //Load the diagram
            Diagram diagram = new Diagram(srcFileName);

            //Call the print method to print whole Diagram to the default printer
            diagram.Print();

            //Call the print method to print whole Diagram to the desired printer
            diagram.Print("LaserJet1100");

            PrinterSettings settings = new PrinterSettings();
            settings.PrinterName = "LaserJet1100";
            //Call the print method to print whole Diagram to the desired printer and set document name in print job
            diagram.Print(settings, "Job name while printing with Aspose.Diagram");
        }
    }
}
