using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchExcelFileTool
{
    public class DirectoryFile
    {
        private string _path;
        public DirectoryFile(string directoryPath)
        {
            _path = directoryPath;
        }

        internal string CreateFileInDirectory(string folderName)
        {
            var dic = new DirectoryInfo(_path);
            try
            {
                dic.CreateSubdirectory(folderName);
                return "Folder created succesfully";
            }
            catch (DirectoryNotFoundException ex)
            {
                return ex.Message;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "SOMETHING WENT WRONG";


        }

    }
}
