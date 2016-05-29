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

            //Save the uploaded file as PDF
            Diagram diagram = new Diagram(srcFileName);

            //Find a particular shape and update its properties
            foreach (Aspose.Diagram.Shape shape in diagram.Pages[0].Shapes)
            {
                if (shape.Name.ToLower() == "process1")
                {
                    shape.Text.Value.Clear();
                    shape.Text.Value.Add(new Txt("Hello World"));

                    //Find custom style sheet and set as shape's text style
                    foreach (StyleSheet styleSheet in diagram.StyleSheets)
                    {
                        if (styleSheet.Name == "CustomStyle1")
                        {
                            shape.TextStyle = styleSheet;
                        }
                    }

                    //Set horizontal and vertical position of the shape
                    shape.XForm.PinX.Value = 5;
                    shape.XForm.PinY.Value = 5;

                    //Set height and width of the shape
                    shape.XForm.Height.Value = 2;
                    shape.XForm.Width.Value = 3;
                }
            }

            //Save shape as VDX
            diagram.Save(destFileName, SaveFileFormat.VDX);

        }
    }
}
