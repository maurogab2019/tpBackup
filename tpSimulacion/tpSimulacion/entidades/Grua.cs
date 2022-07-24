using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpSimulacion.entidades
{
    public class Grua
    {
        public int numeroGrua { get; set; }
        public string estado { get; set; } = "T";

        public int proximaLlegadaReparación { get; set; }

        public double RndPrimerRotura { get; set; }

        public int tiempoProximaRotura { get; set; }

        public int InicioReparacion { get; set; }

        public int FinReparacion { get; set; }

        public int CantidadReparaciones { get; set; }


        public void Repararndo(Grua grua)
        {
            grua.estado = "S.R";
        }

        public void EsperarEnCola(Grua grua)
        {
            grua.estado = "E.C";
        }

        public void Trabajando(Grua grua)
        {
            grua.estado = "T";
        }

    }
}
