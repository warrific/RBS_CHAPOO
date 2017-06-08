using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Tafel
    {
        public int id;
        public TafelStatus status { get; private set; }

        public Tafel(int in_id, TafelStatus in_status)
        {
            id = in_id;
            status = in_status;
        }
    }
}
