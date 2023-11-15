using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojeriaColas.Principal
{
    public class ParametrosSimulacion
    {
        public int Cantidad { get; set; } = 5000;
        public int DesdeMinuto { get; set; } = 100;
        public int CantidadIteraciones { get; set; } = 10;
        public double ProbComprar { get; set; } = 0.45;
        public double ProbEntregar { get; set; } = 0.25;
        public double ProbRetirar { get; set; } = 0.30;
        public double LlegadaClientesD { get; set; } = 13;
        public double LlegadaClientesH { get; set; } = 17;
        public double TiempoCompraD { get; set; } = 6;
        public double TiempoCompraH { get;set; } = 10;
        public double TiempoArregloD { get; set; } = 18;
        public double TiempoArregloH { get; set; } = 22;
        public double RetireTime { get; set; } = 3;
        public double ProbCafe { get; set; } = 0.1; //aca habria que cambiar por ProbDescanso
        public double H { get; set; } = 0.1; 
        public double A { get; set; } = 0;

    }
}
