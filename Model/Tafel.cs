using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        private int id;
        public int Id { get { return id; } set { if (id > 0 || id < 11) { id = value; } } }
        private Status_tafel status;
        public Status_tafel Status { get { return status; } set {if(status == Status_tafel.Vrij||status == Status_tafel.Bezet ) status = value; }}

    }
}
