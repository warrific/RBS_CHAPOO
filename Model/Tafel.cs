using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int tafel_id { get; private set; }
        public string status { get; private set; }

        public Tafel(int tafel_id_in, string status_in)
        {
            tafel_id = tafel_id_in;
            status = status_in;
        }
    }
}
