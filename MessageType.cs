using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchExcelFileTool
{
    class MessageType
    {
        public string[] messageType;
        public Dictionary<int, string> listOfRespnses = new Dictionary<int, string>
        {
            {0 , "Your Template #1"},

            {1, "Your Template #2" },

            {2, "Your Template #3" },

            {3, "Your Template #4" },

            {4, "Your Template #5" },
            {5, "Your Template #6"}
        };

        public Dictionary<int, string> GetPredefinedData()
        {
            return listOfRespnses;
        }
        public MessageType()
        {
            messageType = new string[]
            { "Message to Recruirers",
                "Message to SchoolAlumni",
                "Message to People Similar Background" ,
                "Message To People at Dream Company",
                "MEssage To People who switched Companies",
                "Follow-up Message if No Response"
            };

        }



    }

}
