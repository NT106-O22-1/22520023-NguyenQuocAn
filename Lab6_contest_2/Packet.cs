using System.Collections.Generic;

namespace Lab6_contest_2
{
    internal class Packet
    {
        public int Code { get; set; }
        public List<Item> movieList { get; set; }
        public Packet(int code)
        {
            Code = code;
            movieList = new List<Item>();
        }
    }
}