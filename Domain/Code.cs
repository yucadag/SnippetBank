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
        

    }
}
