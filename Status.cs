using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAreesha
{
    class Status
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private bool ispaid;

        public bool Ispaid
        {
            get { return ispaid; }
            set { ispaid = value; }
        }
        private bool isdelivered;

        public bool Isdelivered
        {
            get { return isdelivered; }
            set { isdelivered = value; }
        }

    }
}
