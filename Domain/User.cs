using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
  public  class User
    {

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
  }
}
