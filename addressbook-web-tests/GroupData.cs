using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    class GroupData
    {
        private string name;

        public GroupData(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
