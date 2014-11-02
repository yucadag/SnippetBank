using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProgrammingLanguage
    {

        private int programmingLanguageId;

        public int ProgrammingLanguageId
        {
            get { return programmingLanguageId; }
            set { programmingLanguageId = value; }
        }

        private string programmingLanguageName;

        public string ProgrammingLanguageName
        {
            get { return programmingLanguageName; }
            set { programmingLanguageName = value; }
        }


    }
}
