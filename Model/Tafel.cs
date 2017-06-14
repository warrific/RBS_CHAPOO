using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public  class Tafel
    {
        private int id;
        public int Id { get { return id; } set { if (id > 0 || id < 11) { id = value; } } }
        private TafelStatus status;
        public TafelStatus Status { get { return status; } set {if(status == TafelStatus.vrij||status == TafelStatus.bezet ) status = value; }}
       
        public Tafel() {}
         
         public Tafel(int in_id, TafelStatus in_status)
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

        public bool SetTafelStatus(TafelStatus in_status)
        {
            if ((in_status == TafelStatus.vrij || in_status == TafelStatus.bezet))
            {
                this.Status = in_status;
                return true;
            }
            return false;
        }

    }
}
