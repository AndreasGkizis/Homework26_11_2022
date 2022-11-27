using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022
{
    internal class LifelessBaseClass
    {

        //THING -> PROPS: OWNER, NAME, DESCR
        
        public string Name { get; set; }
        public string Description { get; set; }


        public LifelessBaseClass ()
        {

        }

    public LifelessBaseClass(string name, string description)
    {
        Name = name;
        Description = description;
    }


        public override string ToString()
        {
            return $"LifelessBaseClass-->Name{Name}\tDescription{Description}";
        }












    }
}
