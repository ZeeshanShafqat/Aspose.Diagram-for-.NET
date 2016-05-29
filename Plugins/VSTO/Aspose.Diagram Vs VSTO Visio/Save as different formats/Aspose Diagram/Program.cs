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
            
            //Load diagram
            Diagram vsdDiagram = new Diagram(srcFileName);

            //Save the diagram as VDX
            vsdDiagram.Save(FilePath+"Drawing1.vdx", SaveFileFormat.VDX);

            //Save as PDF
            vsdDiagram.Save(FilePath + "Drawing1.pdf", SaveFileFormat.PDF);

            //Save as JPEG
            vsdDiagram.Save(FilePath + "Drawing1.jpg", SaveFileFormat.JPEG);
        }
    }
}
