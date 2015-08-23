using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changelist.Model
{

   
    class ChangelistItem
    {

        private int id;

        private string title;

        private ICollection<ChangelistSubItems> subitems;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        internal ICollection<ChangelistSubItems> Subitems
        {
            get
            {
                return subitems;
            }

            set
            {
                subitems = value;
            }
        }
    }
}
