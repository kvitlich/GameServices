using System;
using System.Collections.Generic;
using System.Text;

namespace GameKviti
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public Uri Logo { get; set; }
        public string Genre { get; set; } 
        public string Description { get; set; }
        public string Realise { get; set; }
    }
}
