using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ItemA: Item
    {
        public int A1 { get; set; }
        public int A2 { get; set; }
    }
    public class ItemB: Item
    {
        public bool B1 { get; set; }
        public DateTime B2 { get; set; }
    }
    public class SetX: Set<ItemA>
    {
        public string X1 { get; set; }
    }
    public class SetY: Set<ItemB>
    {
        public ConsoleColor Y1 { get; set; }
    }
    public class AlbumM: Album<SetX>
    {
        public DayOfWeek M1 { get; set; }
    }
    public class AlbumN: Album<SetY>
    {
        public int? N1 { get; set; }
    }
}
