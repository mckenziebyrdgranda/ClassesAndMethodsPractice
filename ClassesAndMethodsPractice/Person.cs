using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsPractice
{
    public class Person
    {
        //

        //properties need access modifer, type, name
        public int Age { get; set; }
        public bool LikesCilantro { get; set; }
        public  string Name { get; set; }

        public Job Job { get; set; }

        //fields are private, inaccessible outside of this class
        private string _ssn;

    }
}
