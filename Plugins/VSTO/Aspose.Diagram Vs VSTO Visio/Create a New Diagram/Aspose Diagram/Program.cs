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
            
            // Create a new diagram
            Diagram diagram = new Diagram(srcFileName);

            //Add a new rectangle shape
            long shapeId = diagram.AddShape(
                4.25, 5.5, 2, 1, @"Rectangle", 0);
            Shape shape = diagram.Pages[0].Shapes.GetShape(shapeId);
            shape.Text.Value.Add(new Txt(@"Rectangle text."));

            //Add a new star shape
            shapeId = diagram.AddShape(
                2.0, 5.5, 2, 2, @"Star 7", 0);
            shape = diagram.Pages[0].Shapes.GetShape(shapeId);
            shape.Text.Value.Add(new Txt(@"Star text."));

            //Add a new hexagon shape
            shapeId = diagram.AddShape(
              7.0, 5.5, 2, 2, @"Hexagon", 0);
            shape = diagram.Pages[0].Shapes.GetShape(shapeId);
            shape.Text.Value.Add(new Txt(@"Hexagon text."));

            //Save the new diagram
            diagram.Save(destFileName, SaveFileFormat.VDX);

        }
    }
}
