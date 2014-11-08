using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace WinnApp.HelperClass
{
    public class BaseForm : Form
    {
        private User activeUser;

        public User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }
        

    }
}
