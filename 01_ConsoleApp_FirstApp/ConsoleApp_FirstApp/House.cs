using System;
using System.Diagnostics;

namespace ConsoleApp_GameOfThrones
{
    //[DebuggerDisplay("{Name,nq}")]
    public class House
    {
        public string Name { get; set; }
        public string Territory { get; set; }
        public HouseType HouseType { get; set; }
    }
}
