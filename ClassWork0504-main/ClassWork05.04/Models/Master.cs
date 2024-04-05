using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05._04.Models
{
    internal class Master:Student
    {
        public int _mastercourse;
        public string _masteruniname;

        public int MasterCourse
        {
            get { return _mastercourse; }

            set
            {
                if (value < 3)
                {
                    _mastercourse = value;
                }
            }
        }
          
         
        public string MasterUniName { get; set; }
    }
}
