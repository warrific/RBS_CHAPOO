using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int Id { get; private set; }
        public Status_tafel Status { get; private set; }

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
                this.Id = in_id;
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
