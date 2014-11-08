using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Code
    {

        private int codeId;

        public int CodeId
        {
            get { return codeId; }
            set { codeId = value; }
        }

        private string codeName;

        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        private int programmingLanguageId;

        public int ProgrammingLanguageId
        {
            get { return programmingLanguageId; }
            set { programmingLanguageId = value; }
        }

        private int lastVersionId;

        public int LastVersionId
        {
            get { return lastVersionId; }
            set { lastVersionId = value; }
        }
        private string isLocked;

        public string IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }

        private int insertedBy;

        public int InsertedBy
        {
            get { return insertedBy; }
            set { insertedBy = value; }
        }
        
        


    }
}
