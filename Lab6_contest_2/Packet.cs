using System.Collections.Generic;

namespace Lab6_contest_2
{
    internal class Packet
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<Item> movieList { get; set; }
        public Packet() { }
        public Packet(int code)
        {
            Code = code;
            Name = "";
            movieList = new List<Item>();
        }
    }
}