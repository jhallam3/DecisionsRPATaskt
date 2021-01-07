using DecisionsFramework.Design.Flow;
using DecisionsTaskT.Datatypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace DecisionsTaskT
{
    [AutoRegisterMethodsOnClass(true, "Integration\\RPA\\Taskt")]
    public class TasktXMLData
    {


        public string[] GetVariablesinTaskTXML(string FileContents)
        {
            List<string> ListOfVariables = new List<string>();
            using (TextReader sr = new StringReader(FileContents))
            {
                var docnav = new XPathDocument(sr);
                var length = 100;
                for (int i = 1; i < length; i++)
                {
                    var expression = "/Script/Variables[1]/ScriptVariable[" + i + "]/VariableName[1]/text()";
                    var nav = docnav.CreateNavigator();
                    var data = nav.Evaluate(expression);

                    var selected = nav.Select(expression);
                    var movedforward = selected.MoveNext();
                    if (movedforward == true)
                    {
                        var output = selected.Current.Value;
                        output = "{" + output + "}";
                        ListOfVariables.Add(output);
                    }

                }

                return ListOfVariables.ToArray();
            }
        }

        public string[] GetTasktVariables(byte[] FileContents)
        {
            List<string> ListOfVariables = new List<string>();
           
                var reader = new StreamReader(new MemoryStream(FileContents), true);

                
                var docnav = new XPathDocument(reader);
                var length = 100;
                for (int i = 1; i < length; i++)
                {
                    var expression = "/Script/Variables[1]/ScriptVariable[" + i + "]/VariableName[1]/text()";
                    var nav = docnav.CreateNavigator();
                    var data = nav.Evaluate(expression);

                    var selected = nav.Select(expression);
                    var movedforward = selected.MoveNext();
                    if (movedforward == true)
                    {
                        var output = selected.Current.Value;
                        output = "{" + output + "}";
                        ListOfVariables.Add(output);
                    }

                }

                return ListOfVariables.ToArray();
            
        }
        public TasktDataXMLLine[] GetXMLVariables(string FileContents)
        {
            List<string> ListOfVariables = new List<string>();
            using (TextReader sr = new StringReader(FileContents))
            {
                var docnav = new XPathDocument(sr);
                var length = 100;
                for (int i = 1; i < length; i++)
                {
                    var expression = "/Script/Variables[1]/ScriptVariable["+i+"]/VariableName[1]/text()";
                    var nav = docnav.CreateNavigator();
                    var data = nav.Evaluate(expression);
                    
                    var selected = nav.Select(expression);
                    var movedforward = selected.MoveNext();
                    if (movedforward == true)
                    {
                        var output = selected.Current.Value;

                        ListOfVariables.Add(output);
                    }

                }
                

            }
           


            List<TasktDataXMLLine> LTaskTDataLines = new List<TasktDataXMLLine>();
           
           
            //string path = "pingwithvariable.xml";
            //string path = "variables.xml";
            
            var filescontents =  FileContents.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var FileContentLines = filescontents.Where(x => x.Contains("CommandName=\"VariableCommand\"")).ToArray();
            foreach (var s in FileContentLines)
            {
                var result = new TasktDataXMLLine();
                result.TheLine = s;

                var splitthem = s.Split("\" ");
                //variablename 
                var variablename = splitthem.Where(c => c.Contains("v_userVariableName="));
                result.variableName = variablename.ElementAt(0).Split('=').Last().ToString().Trim('"');

                //variablevalue
                var variablevalue = splitthem.Where(c => c.Contains("v_Input=")).FirstOrDefault();
                if (variablevalue == null)
                {
                    result.VariableValue = "";
                }
                else
                {
                    result.VariableValue = variablevalue.ElementAt(0) + "\"";
                }
                

                var id = splitthem.Where(c => c.Contains("CommandID=")).ElementAt(0) + "\"";
                result.id = id;
                LTaskTDataLines.Add(result);
            }

            return LTaskTDataLines.ToArray();
        }
    }
}
