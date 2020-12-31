using DecisionsTaskT.Datatypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace TasktRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileconents = System.IO.File.ReadAllText("Variables.xml");
            var data = new DecisionsTaskT.TasktXMLData().GetXMLVariables(fileconents);

        }
    }

    
}
