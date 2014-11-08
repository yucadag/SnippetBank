using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class CodeRevision
    {
        private int codeId;

        public int CodeId
        {
            get { return codeId; }
            set { codeId = value; }
        }
        private int revisionId;

        public int RevisionId
        {
            get { return revisionId; }
            set { revisionId = value; }
        }
        private string codeContent;

        public string CodeContent
        {
            get { return codeContent; }
            set { codeContent = value; }
        }
        private int insertedBy;

        public int InsertedBy
        {
            get { return insertedBy; }
            set { insertedBy = value; }
        }
        private DateTime insertedDate;

        public DateTime InsertedDate
        {
            get { return insertedDate; }
            set { insertedDate = value; }
        }
    }
}
