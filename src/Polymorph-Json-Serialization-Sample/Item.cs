using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Picture { get; set; }
    }

    public abstract class Set
    {
        public string Name { get; set; }
    }

    public class Set<T> : Set
        where T: Item
    {
        public T[] Items { get; set; }
    }

    public abstract class Album
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class Album<T> : Album
        where T: Set
    {
        public T[] Sets { get; set; }
    }

}
