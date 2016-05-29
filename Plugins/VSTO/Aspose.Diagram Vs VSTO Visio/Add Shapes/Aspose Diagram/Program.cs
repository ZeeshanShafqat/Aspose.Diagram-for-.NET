using Aspose.Diagram;

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
            string destFileName = FilePath + "Output.vdx";
            
            // Load masters from any existing diagram, stencil or template
            // and add in the new diagram
            
            //Names of the masters present in the stencil
            string rectangleMaster = @"Rectangle";

            int pageNumber = 0;
            double width = 2, height = 2, pinX = 4.25, pinY = 9.5;

            // Create a new diagram
            Diagram diagram = new Diagram(srcFileName);

            //Add a new rectangle shape
            long rectangleId = diagram.AddShape(
                pinX, pinY, width, height, rectangleMaster, pageNumber);
            
            //Save the diagram
            diagram.Save(destFileName, SaveFileFormat.VDX);

        }
    }
}
