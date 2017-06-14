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

        public Tafel() {}
         
         public Tafel(int in_id, Status_tafel in_status)
        {
            Id = in_id;
            Status = in_status;
        }

        public bool Setid(int in_id)
        {
            if ((in_id > 0) && (in_id <11))
        {
                this.id = in_id;
                return true;
            }
            return false;
        }

        public bool SetTafelStatus(Status_tafel in_status)
        {
            if ((in_status == Status_tafel.Vrij || in_status == Status_tafel.Bezet))
            {
                this.Status = in_status;
                return true;
            }
            return false;
        }

    }
}
