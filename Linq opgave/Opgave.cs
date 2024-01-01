using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Linq_opgave
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
    }

    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars = new List<Car>();
    }


}
