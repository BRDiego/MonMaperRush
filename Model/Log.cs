using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public enum EntitiesControl
    {
        TRANSFERENCE = 1
    }

    public class Log
    {
        public EntitiesControl Entity { get; set; }
        public DateTime Moment { get; set; }
        public string Description { get; set; }
        public char Action { get; set; }
    }
}
