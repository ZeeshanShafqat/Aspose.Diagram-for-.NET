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
            
            // Load diagram
            Diagram diagram = new Diagram(srcFileName);

            // Get max page ID
            int MaxPageId = GetMaxPageID(diagram);

            // Initialize a new page object
            Page newPage = new Page();
            // Set name
            newPage.Name = "new page";
            // Set page ID
            newPage.ID = MaxPageId + 1;

            // Or try the Page constructor
            // Page newPage = new Page(MaxPageId + 1);

            // Add a new blank page
            diagram.Pages.Add(newPage);

            // Save diagram
            diagram.Save(destFileName, SaveFileFormat.VDX);


        }

        private static int GetMaxPageID(Diagram diagram)
        {
            int max = diagram.Pages[0].ID;
            for (int i = 1; i < diagram.Pages.Count; i++)
            {
                if (max < diagram.Pages[i].ID)
                    max = diagram.Pages[i].ID;
            }
            return max;
        }
    }
}
