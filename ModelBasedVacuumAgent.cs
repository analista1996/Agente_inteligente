using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;


namespace WD_Easy_Control.classes.Agente
{
    public class ModelBasedVacuumAgent : Agent<VacuumLocation, VacuumPerception, VacuumAction>
    {
        private IDictionary<VacuumLocation, VacuumStatus> state = new Dictionary<VacuumLocation, VacuumStatus>();

        public override VacuumAction GetAction(VacuumPerception perception)
        {
            this.state[perception.Location] = perception.Status;
           
            if (perception.Status == VacuumStatus.nao_Tem)
                return VacuumAction.Buscar_e_monta;

            if (perception.Status == VacuumStatus.tem_de_outro_tipo)
                return VacuumAction.iguinorar;

            if (perception.Status == VacuumStatus.ja_existe)
                return VacuumAction.Monta;

            return VacuumAction.iguinorar;
        }
    
    }
}
