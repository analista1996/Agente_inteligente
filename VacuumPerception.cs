using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD_Easy_Control.classes.Agente
{
    public class VacuumPerception
    {
        private VacuumStatus status;
        private VacuumLocation location;
        public int DocumentoInt;
        private byte[] Documento;
        public void VacuumPerception1(VacuumLocation location, VacuumStatus status,byte[] documento)
        {
            this.location = location;
            this.status = status;
           
            if(documento.Length > 0)
            {   
                this.DocumentoInt = documento.GetHashCode();
                this.Documento = documento;
            }
          
        }

        public VacuumPerception()
        {
            // TODO: Complete member initialization
        }

        public VacuumStatus Status { get { return this.status; } }

        public VacuumLocation Location { get { return this.location; } }
        public byte[] VacumDoc { get { return this.Documento; } }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is VacuumPerception)
            {
                var perp = (VacuumPerception)obj;

                if (this.location == perp.location && this.status == perp.status )
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.location.GetHashCode() + this.status.GetHashCode();
        }
    }
}
