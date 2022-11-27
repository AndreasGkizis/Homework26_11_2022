using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouaMatHomework26_11_2022.Models
{
    internal class Bell : HouseItems
    {
        public Bell()
        {
            Name = "default Name";
            kapoioSpiti = new House();
        }
        public Bell(string onoma, House spiti) : base(onoma, spiti)
        {

        }

        public void Ring()
        {
            Console.WriteLine($"~!The Grand {Name} has been rung!~");
        }
    }
}
