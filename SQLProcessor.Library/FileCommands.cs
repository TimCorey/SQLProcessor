using SQLProcessor.Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProcessor.Library
{
    public class FileCommands
    {
        public static List<FileResultsModel> ProcessFolder(string folderPath, bool includeSubfolders = false, string validExtensions = "*.sql")
        {
            List<string> files = GetFilesInFolder(folderPath, includeSubfolders, validExtensions);
            List<FileResultsModel> output = new List<FileResultsModel>();
            FileResultsModel rec = new FileResultsModel();

            foreach (var file in files)
            {
                rec = new FileResultsModel();

                rec.FileName = file;

                var sqlStatements = GetSqlCommandsFromFile(file);

                foreach (var item in sqlStatements)
                {
                    var result = DBCommands.ProcessStatement(item);
                    rec.CommandResults.Add(result);
                }

                output.Add(rec);
            }

            return output;
        }
        public static List<string> GetFilesInFolder(string folderPath, bool includeSubfolders = false, string validExtensions = "*.sql")
        {
            List<string> output = new List<string>();

            if (includeSubfolders)
            {
                output = Directory.GetFiles(folderPath, validExtensions, SearchOption.AllDirectories).ToList();
            }
            else
            {
                output = Directory.GetFiles(folderPath, validExtensions).ToList();
            }

            return output;
        }

        public static List<string> GetSqlCommandsFromFile(string file)
        {
            List<string> output = new List<string>();

            var lines = File.ReadAllLines(file);
            string statement = "";

            foreach (var line in lines)
            {
                if (line.Trim().ToUpper() == "GO")
                {
                    // Make sure there is an actual statement here
                    if (statement.Trim().Length > 0)
                    {
                        output.Add(statement);
                    }

                    // Prepares for the next statement
                    statement = "";
                }
                else
                {
                    // Checks to see if this is not the first line of the statement
                    if (statement.Length > 0)
                    {
                        // Add a newline first, since there is already text in the statement
                        statement += Environment.NewLine;
                    }

                    // 
                    statement += line;
                }
            }

            // Adds the last statement, if there is one
            if (statement.Length > 0)
            {
                output.Add(statement);
            }

            return output;
        }
    }
}
