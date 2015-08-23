using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Changelist.Data;

namespace Changelist.Data
{
    class ChangelistSubItems
    {

        private int sid;

        private int cliid;

        private string admin;

        private DateTime start;

        private DateTime end;

        private string hostname;

        private string system;

        
        public int Sid
        {
            get
            {
                return sid;
            }

            set
            {
                sid = value;
            }
        }

        public int Cliid
        {
            get
            {
                return cliid;
            }

            set
            {
                cliid = value;
            }
        }

        public string Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        public DateTime Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public DateTime End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public string Hostname
        {
            get
            {
                return hostname;
            }

            set
            {
                hostname = value;
            }
        }

        public string System
        {
            get
            {
                return system;
            }

            set
            {
                system = value;
            }
        }
    }
}
