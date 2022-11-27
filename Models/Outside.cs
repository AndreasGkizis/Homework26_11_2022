using RouaMatHomework26_11_2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Models
{
    internal class Outside :LifelessBaseClass, IPlaces
    {
        public Outside() 
        {
            Name = "Park";
        }    

    }
}
