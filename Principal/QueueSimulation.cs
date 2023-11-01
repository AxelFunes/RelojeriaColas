using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojeriaColas.Principal
{
    public class QueueSimulation
    {
        private List<Queue> Queue { get; set; } // Filas a Mostrar
        private Queue QueueActual { get; set; } // Fila Actual
        private Queue QueueAnterior { get; set; } // Fila Anterior
        private ParametrosSimulacion parametros { get; set; }
        private int Orden { get; set; }

        public List<Queue> crearQueues (ParametrosSimulacion parametersFromFront)
        {
            Queue = new List<Queue> ();
            parametros = parametersFromFront;
            for(int i = 0; i <= parametros.Cantidad; i++)
            {
                InitializacionQueue(parametros);
                if(i >= parametros.DesdeMinuto && i < parametros.DesdeMinuto + parametros.CantidadIteraciones)
                {
                    Queue.Add(QueueActual);
                }
            }
            Queue.Add(QueueActual); // Ultima cola siempre se agrega, asi la mostras
            return Queue;
        }

        private void InitializacionQueue(ParametrosSimulacion parametersObj)
        {   
            if (QueueActual != null)
            {
                QueueAnterior = (Queue) QueueActual.Clone();
                QueueActual = new Queue(parametersObj, QueueAnterior, Orden);
                this.Orden = QueueActual.ClientQuantity;
            } 
            else
            {
                QueueActual = new Queue(parametersObj, Orden);
                this.Orden = QueueActual.ClientQuantity;
            }
        }
    }
}
