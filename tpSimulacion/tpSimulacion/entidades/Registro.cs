using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpSimulacion.entidades
{
    public class Registro
    {
        public string evento { get; set; }

        public int reloj { get; set; } = 0;

        public double RndPrimeraRotura { get; set; }

        public int tiempoProximaRotura { get; set; }

        //usamos la lista de gruas xd
        //public int proximaReparacion { get; set; }

        public double RndTiempoReparacion { get; set; }

        public int tiempoReparacion { get; set; }

        public int cantidadGruasCola { get; set; }

        public List<Grua> colaGruas { get; set; }

        public int tiempoMaximoReparacion { get; set; }

        public int AcumuladorTiemposReparacion { get; set; }

        public int cantidadMaximaEnCola { get; set; }

        public double PromedioTiempoReparacion { get; set; }

        public int AcumuladorGruasReparadas { get; set; }  
        
        public double promedioGruasDisponibles { get; set; }

        public int cantidadGruasDisponibles { get; set; }

        public int tiempoOciosoCapacidades { get; set; }

        public int AcumuladortiempoOciosoCapacidades { get; set; }

        public int MaximoReparacionPorGrua { get; set; }


        //metricas luego
    }
}
