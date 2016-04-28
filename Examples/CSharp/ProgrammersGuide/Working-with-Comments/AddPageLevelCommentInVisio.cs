﻿using Aspose.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ProgrammersGuide.Working_Diagrams
{
    public class AddPageLevelCommentInVisio
    {
        public static void Run()
        {
            //ExStart:AddPageLevelCommentInVisio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_VisioComments();

            // Load diagram
            Diagram diagram = new Diagram(dataDir + "Drawing1.vsdx");

            // Add comment
            diagram.Pages[0].AddComment(7.205905511811023, 3.880708661417323, "test@");

            // Save diagram
            diagram.Save(dataDir + "AddComment_Out.vsdx", SaveFileFormat.VSDX);
            //ExEnd:AddPageLevelCommentInVisio
        }
    }
}