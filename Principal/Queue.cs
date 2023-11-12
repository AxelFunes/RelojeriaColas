using RelojeriaColas.Eventos;
using RelojeriaColas.ControlVariables;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace RelojeriaColas.Principal
{
    public class Queue : ICloneable
    {
        public string Evento { get; set; }
        public string NextEvent { get; set; }
        public double Reloj { get; set; }
        public int ClientQuantity { get; set; } = 0;
        public LlegadaCliente ClientArrival { get; set; }
        public tipoAtencion ClientReason { get; set; }
        public Atencion Atencion { get; set; }
        public Ayudante Ayudante { get; set; }
        public ArregloReloj WatchFix { get; set; }
        public Relojero Relojero { get; set; }
        public Estadisticas Stats { get; set; }
        public Cafe Coffee { get; set; }
        public Descanso Descanso { get; set; }


        public List<Cliente> Clients { get; set; }
        public static Random rndGenerator { get; set; } = new Random();

        public List<Cliente> CloneList(List<Cliente> previous)
        {
            List<Cliente> list = new List<Cliente>();
            foreach(Cliente client in previous)
            {
                list.Add((Cliente)client.Clone());
            }
            return list;
        }

        // Constructor para el Evento Inicialización
        public Queue(ParametrosSimulacion parameterObj, int orderParam)
        {
            this.ClientQuantity = orderParam;
            this.Evento = Eventos.Evento.Init;
            this.NextEvent = Eventos.Evento.Arrival;
            this.Reloj = 0;
            this.Ayudante = new Ayudante();
            this.Relojero = new Relojero();
            this.Stats = new Estadisticas();

            this.Clients = new List<Cliente>();
            

            // Generate table of Probabilities for TipoAtencion of Arrive of a Cliente
            ProbabilitiesReason.generateReasonProbabilities(parameterObj.ProbComprar, parameterObj.ProbEntregar, parameterObj.ProbRetirar);
            this.ClientArrival = new LlegadaCliente(parameterObj.LlegadaClientesD, parameterObj.LlegadaClientesH, this.Reloj);
        }

        // Constructor para los demás Eventos
        public Queue(ParametrosSimulacion parameterObj, Queue previous, int orderParam)
        {
            this.ClientQuantity = orderParam;
            this.Evento = previous.NextEvent;
            this.Clients = CloneList(previous.Clients);
            if (this.Evento == Eventos.Evento.Arrival)
            {
                this.Reloj = Calculos.TruncateDigits(previous.ClientArrival.proximaLlegada, 4) ;
                this.arrival(parameterObj, previous);
            }
            else if (this.Evento == Eventos.Evento.EndAttention)
            {
                this.Reloj = Calculos.TruncateDigits(previous.Atencion.FinAtencion, 4);
                this.FinAtencion(parameterObj, previous); 
            }
            else if (this.Evento == Eventos.Evento.EndFixing)
            {
                this.Reloj = Calculos.TruncateDigits(previous.WatchFix.finArreglo, 4);
                this.endOfFixing(parameterObj, previous);
            }
            else if (this.Evento == Eventos.Evento.FinCafecito)
            {
                this.Reloj = Calculos.TruncateDigits(previous.Coffee.FinCafe, 4);
                this.FinCafecin(parameterObj, previous);
            }
            this.Stats.HelperTotalTime = this.Reloj;
            this.Stats.TiempoTotalRelojero = this.Reloj;
            this.defineNextEvent();
        }

        private void arrival(ParametrosSimulacion parameterObj, Queue previous)
        {
            this.Evento = previous.NextEvent;
            if(this.WatchFix != null)
            {
                this.WatchFix.finArreglo = previous.WatchFix.finArreglo;
            }
            if (this.Atencion != null)
            {
                this.Atencion.FinAtencion = previous.Atencion.FinAtencion;
            }
            if (previous.Coffee != null)
            {
                this.Coffee = this.Coffee = previous.Coffee is null ? null : (Cafe)previous.Coffee.Clone();
            }
            this.Ayudante = (Ayudante) previous.Ayudante.Clone();
            this.Relojero = (Relojero) previous.Relojero.Clone();
            this.Stats =  (Estadisticas)previous.Stats.Clone();
            //this.Clients = CloneList(previous.Clients);
            this.WatchFix = previous.WatchFix is null ? null : (ArregloReloj)previous.WatchFix.Clone();
            this.Atencion = previous.Atencion is null ? null : (Atencion)previous.Atencion.Clone();
            //this.Coffee = previous.Coffee is null ? null : (Cafe)previous.Coffee.Clone();
            

            this.ClientArrival = new LlegadaCliente(parameterObj.LlegadaClientesD, parameterObj.LlegadaClientesH, this.Reloj);
            Cliente arrivedClient = new Cliente();
            this.ClientQuantity++;
            arrivedClient.Id = this.ClientQuantity;
            this.ClientReason = new tipoAtencion();
            arrivedClient.TipoAtencion = this.ClientReason.Atencion;
           
            if (this.Ayudante.AyudanteQueue == 0 && this.Ayudante.AyudanteEstado == Eventos.Evento.Free)
            {
                arrivedClient.EstadoCliente = Eventos.Evento.BeingAttended;
                this.Stats.HelperOcupiedBegin = this.Reloj;
                arrivedClient = CreateAttention(arrivedClient, parameterObj);
                //this.Clients = CloneList(previous.Clients);
                this.Ayudante.clienteAtendiendo++; 
            }
            else
            {
                arrivedClient.EstadoCliente = Eventos.Evento.WaitingAttention;
                this.Ayudante.AyudanteQueue++;
            }
            this.Clients.Add(arrivedClient);

        }

        private Cliente CreateAttention(Cliente client, ParametrosSimulacion parameterObj)
        {
            client.EstadoCliente = Eventos.Evento.BeingAttended; // Ya está puesto antes
            this.Ayudante.AyudanteEstado = Eventos.Evento.Ocupied;
            if (client.TipoAtencion == Eventos.Evento.Buy)
            {
                this.Atencion = new Atencion(this.Reloj, parameterObj);
            }
            else
            { 
                this.Atencion = new Atencion(3, this.Reloj, parameterObj);
            }
            return client;
        }

        private void FinAtencion(ParametrosSimulacion parameterObj, Queue previous)
        {
            this.Evento = previous.NextEvent;
            this.ClientArrival = (LlegadaCliente) previous.ClientArrival.Clone();
            if(previous.WatchFix != null)
            {
                this.WatchFix = this.WatchFix = previous.WatchFix is null ? null : (ArregloReloj)previous.WatchFix.Clone();
            }
            if (previous.Coffee != null)
            {
                this.Coffee = this.Coffee = previous.Coffee is null ? null : (Cafe)previous.Coffee.Clone();
            }
            this.Ayudante = (Ayudante) previous.Ayudante.Clone();
            this.Relojero = (Relojero) previous.Relojero.Clone();
            this.Stats = (Estadisticas) previous.Stats.Clone();
            // this.Clients = CloneList(previous.Clients);

            this.Stats.HelperOcupiedAcum += (this.Reloj - this.Stats.HelperOcupiedBegin); // Q: no es mejor this.Atencion.FinAtencion??

            Cliente clientAttended = null;
            this.Clients[0].EstadoCliente = Eventos.Evento.JustAttended;
            clientAttended = this.Clients[0];        
            
            if (clientAttended.TipoAtencion == Eventos.Evento.Retire) // Retiro de Reloj
            {
                this.Stats.RetireRequests++;
                if (this.Relojero.RelojesParaRetirar > 0)
                {
                    this.Stats.AcumuladorRetirar++;
                    this.Relojero.RelojesParaRetirar--;
                }
            }
            else if (this.Clients[0].TipoAtencion == Eventos.Evento.Leave) // Dejar Reloj para arreglar
            {
                if(this.Relojero.EstadoRelojero == Eventos.Evento.Free)
                {
                    this.Relojero.EstadoRelojero = Eventos.Evento.Ocupied;
                    this.WatchFix = new ArregloReloj(parameterObj.TiempoArregloD, parameterObj.TiempoArregloH, this.Reloj, parameterObj, this.Relojero.QueueRelojero);
                    this.Stats.WatchmanOcupiedBegin = this.Reloj;                    
                }
                else
                {
                    this.WatchFix = previous.WatchFix is null ? null : (ArregloReloj)previous.WatchFix.Clone();
                    this.Relojero.QueueRelojero++;
                }
            }

            this.Clients.RemoveAt(0);

            if (this.Ayudante.AyudanteQueue == 0)
            {
                this.Ayudante.AyudanteEstado = Eventos.Evento.Free;
            }
            else
            {
                this.Ayudante.AyudanteQueue--;
                this.Ayudante.clienteAtendiendo++;
                this.Clients[0] = CreateAttention(this.Clients[0], parameterObj);
                this.Clients[0].EstadoCliente = Eventos.Evento.BeingAttended; // Q: No sería el 0 el que empieza a atender?
                this.Stats.HelperOcupiedBegin = this.Reloj;
            }
        }

        private void endOfFixing(ParametrosSimulacion parameterObj, Queue previous)
        {
            this.ClientArrival = (LlegadaCliente) previous.ClientArrival.Clone();
            //if( previous.WatchFix.Cafecito == "No")
            //{
            //    this.Reloj = previous.WatchFix.finArreglo;
            //}
            //else
            //{
            //    this.Reloj = previous.WatchFix.FinCafe;
            //}
            if (this.Coffee != null)
            {
                this.Coffee = this.Coffee = previous.Coffee is null ? null : (Cafe)previous.Coffee.Clone();
            }
            this.Atencion = previous.Atencion is null ? null : (Atencion) previous.Atencion.Clone();
            this.Ayudante = (Ayudante) previous.Ayudante.Clone();
            this.Relojero = (Relojero) previous.Relojero.Clone();
            this.Stats =  (Estadisticas)previous.Stats.Clone();
            //this.Clients = CloneList(previous.Clients);
            this.Relojero.RelojesParaRetirar++;
            this.Stats.RelojeroOcupacionAcum += (this.Reloj - this.Stats.WatchmanOcupiedBegin);

            //double RndCafe = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 3);
            if(previous.WatchFix.RndCafe < parameterObj.ProbCafe)
            {if (previous.WatchFix.DemoraEuler != null)
                {
                    this.Coffee = new Cafe(this.Reloj, previous.WatchFix.DemoraEuler, previous.WatchFix.RndCafe);
                    this.Relojero.EstadoRelojero = Eventos.Evento.Descansando;
                }
                else
                {
                    this.Coffee = new Cafe(this.Reloj, 0, previous.WatchFix.RndCafe);
                    this.Relojero.EstadoRelojero = Eventos.Evento.Descansando;
                }
            }
            
            //if (this.Coffee.FinCafe != 0 /*&&this.Cafecito.FinCafe != null*/)
            //{
                
            //}
            else if(this.Relojero.QueueRelojero == 0)
            {
                this.Relojero.EstadoRelojero = Eventos.Evento.Free;
                //this.Coffee = previous.Coffee;
            }
            else
            {
                this.Relojero.QueueRelojero--;
                this.WatchFix = new ArregloReloj(parameterObj.TiempoArregloD, parameterObj.TiempoArregloH, this.Reloj,parameterObj, this.Relojero.QueueRelojero);
                this.Stats.WatchmanOcupiedBegin = this.Reloj;
                //this.Coffee = previous.Coffee;
            }
        }

        private void FinCafecin(ParametrosSimulacion parameterObj, Queue previous)
        {
            if (this.Coffee != null)
            {
                this.Coffee = this.Coffee = previous.Coffee is null ? null : (Cafe)previous.Coffee.Clone();
            }
            this.ClientArrival = (LlegadaCliente)previous.ClientArrival.Clone();
            this.Atencion = previous.Atencion is null ? null : (Atencion)previous.Atencion.Clone();
            this.Ayudante = (Ayudante)previous.Ayudante.Clone();
            this.Relojero = (Relojero)previous.Relojero.Clone();
            //this.Coffee = (Cafe)previous.Coffee.Clone();
            this.Stats = (Estadisticas)previous.Stats.Clone();
            //this.Clients = CloneList(previous.Clients);
            //this.Relojero.EstadoRelojero = Eventos.Evento.Free;
            
            if (this.Relojero.QueueRelojero == 0)
            {
                this.Relojero.EstadoRelojero = Eventos.Evento.Free;
            }
            else
            {
                this.Relojero.QueueRelojero--;
                this.WatchFix = new ArregloReloj(parameterObj.TiempoArregloD, parameterObj.TiempoArregloH, this.Reloj, parameterObj, this.Relojero.QueueRelojero);
                this.Stats.WatchmanOcupiedBegin = this.Reloj;
                this.Relojero.EstadoRelojero = Eventos.Evento.Ocupied;
            }
        }
        private void defineNextEvent()
        {
            double nextEndOfAttention = this.Atencion != null ? this.Atencion.FinAtencion : 9329318293812.123;
            double nextEndOfFix = this.WatchFix != null ? this.WatchFix.finArreglo : 9329318293812.123;
            double nextEndCoffee = this.Coffee != null ? this.Coffee.FinCafe : 9329318293812.123;
            
            double nextArrival = this.ClientArrival.proximaLlegada;

            
            if(nextArrival <= nextEndOfAttention && nextArrival <= nextEndOfFix && nextArrival <= nextEndCoffee)
            {
                this.NextEvent = Eventos.Evento.Arrival;
            } 
            else if(nextEndOfAttention <= nextEndOfFix && nextEndOfAttention <= nextEndCoffee)
            {
                this.NextEvent = Eventos.Evento.EndAttention;
            }
            else if(nextEndOfFix <= nextEndCoffee && nextEndCoffee != 0)
            {
                this.NextEvent = Eventos.Evento.EndFixing;
            }
            else 
            {
                this.NextEvent = Eventos.Evento.FinCafecito;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }

    public class LlegadaCliente : ICloneable  
        // Representa:   Llegada Cliente
        // Distribución: U(LlegadaClientesD; LlegadaClientesH)
        // Fórmula:      LlegadaClientesD + RND * (LlegadaClientesD - LlegadaClientesD)
    {
        public double RNDLlegadaCliente { get; set; }
        public double tiempoLlegada { get; set; }
        public double proximaLlegada { get; set; }

        public LlegadaCliente(double from, double to, double actualClock)
        {
            this.RNDLlegadaCliente = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 4);
            this.tiempoLlegada = this.calcularLlegada(from, to);
            this.proximaLlegada = this.tiempoLlegada + actualClock;
        }

        private double calcularLlegada(double desde, double hasta)
        {
            return (desde + this.RNDLlegadaCliente * (hasta - desde));
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class tipoAtencion
        // Representa:  El motivo del cliente 
    {
        public double RNDtipoAtencion { get; set; }
        public string Atencion { get; set; }

        public tipoAtencion()
        {
            this.RNDtipoAtencion = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 4);
            this.Atencion = ProbabilitiesReason.getReason(this.RNDtipoAtencion);
        }
    }

    public class Atencion : ICloneable  // Representa la atención a una compra
    {
        public double RNDTiempoAtencion { get; set; }
        public double tiempoAtencion { get; set; }
        public double FinAtencion { get; set; }

        // Constructor para evento de compra
        public Atencion( double clock, ParametrosSimulacion parameterObj)
        {
            this.RNDTiempoAtencion = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 4);
            this.tiempoAtencion = parameterObj.TiempoCompraD + this.RNDTiempoAtencion * (parameterObj.TiempoCompraH - parameterObj.TiempoCompraD);
            this.FinAtencion = this.tiempoAtencion + clock;
        }
        // Constructor para eventos de entrega o reparación
        public Atencion(double tiempo, double reloj, ParametrosSimulacion parameterObj)
        {
            this.tiempoAtencion = tiempo;
            this.FinAtencion = this.tiempoAtencion + reloj;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public class Descanso : ICloneable
    {
        public double RndDescanso { get; set; }
        public string Tipo { get; set; }
        public double FinDescanso { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        public Descanso(double rnd)
        {
            this.RndDescanso = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 4);
            if (rnd < 0.5)
                this.Tipo="Refresco";
            else
            {
                this.Tipo = "Café";
            }
        }
    }
    public class Cafe : ICloneable
    {
        public double RndCafe { get; set; }
        public string Cafecito { get; set; }
        public double FinCafe { get; set; }

        public Cafe(double actualClock, double demora, double randomCafe)
        {
            this.RndCafe = randomCafe;
            this.Cafecito = TomaCafe(randomCafe);
            this.FinCafe = actualClock + demora;
            
            
        }
        public double FinCafecito(double actualClock)
        {
            if (Cafecito == "Toma Cafe")
            {
                return (Calculos.TruncateDigits(actualClock + 5, 3));
            }
            else
            {
                return (0);
            }
        }
        public string TomaCafe(double rnd)
        {
            if (rnd > 0.5)
                return ("Refresco");
            else
            {
                return ("Café");
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class ArregloReloj : ICloneable  // Representa el arreglo del Reloj
    {
        public double RNDArregloReloj { get; set; }
        public double tiempoArreglo { get; set; }
        public double finArreglo { get; set; }
        public double RndCafe { get; set; }
        public string TomaDescanso { get; set; }
        public double RndTipo { get; set; }
        public string Tipo { get; set; }
        //public string Cafecito { get; set; }
        public double FinCafe { get; set; }
        public double DemoraEuler { get; set; }

        public ArregloReloj(double desde, double hasta, double actualClock, ParametrosSimulacion parameterObj, double relojEnCola)
        {
            this.RNDArregloReloj = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 3);
            this.tiempoArreglo = Calculos.TruncateDigits(calcularArreglo(desde, hasta), 3);
            this.finArreglo = Calculos.TruncateDigits(this.tiempoArreglo + actualClock, 3);
            this.RndCafe = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 3);
            this.TomaDescanso = Toma(RndCafe,parameterObj);
            this.RndTipo = Calculos.TruncateDigits(Queue.rndGenerator.NextDouble(), 3);
            this.Tipo = TomaCafe(RndTipo);
            this.FinCafe = CalculoDemora(Tipo, relojEnCola, parameterObj) + actualClock;


        }
        //private double FinCafecito(double actualClock)
        //{
        //    if (Cafecito == "Toma Cafe")
        //    {
        //        return (Calculos.TruncateDigits(finArreglo + 5, 3));
        //    }
        //    else
        //    {
        //        return (0);
        //    }
        //}
        //private string TomaCafe()
        //{
        //    if (this.RndCafe < 0.1)
        //        return ("Toma Cafe");
        //    else
        //    {
        //        return ("No");
        //    }
        //}

        public double CalculoDemora(string tipo, double relojEnCola, ParametrosSimulacion parameterObj)
        {
            double demora = 0;
            if (tipo == "Refresco")
            {
                demora = ResolverPorEuler(parameterObj, relojEnCola, 50);
            }
            else
            {
                demora = ResolverPorEuler(parameterObj, relojEnCola, 80);
            }
            return demora;
        }
        static double ResolverPorEuler(ParametrosSimulacion parameterObj, double relojEnCola, double C)
        {
            double t = 0.0;
            double h = 0.1;
            double D = 0.0;
            double a = parameterObj.A;

          
            while (D < C)
            {
                // Calcular la siguiente iteración usando el método de Euler
                double dDdt = 0.4 * C + t + a * relojEnCola;
                D += h * dDdt;

                // Avanzar en el tiempo
                t += h;
            }

            return t;
        }
        public string TomaCafe(double rnd)
        {
            if (rnd > 0.5)
                return ("Refresco");
            else
            {
                return ("Café");
            }
        }
        public string Toma(double rnd, ParametrosSimulacion parameterObj)
        {
            if (rnd < parameterObj.ProbCafe)  
                return ("SI");
          
            return ("NO");
            
        }
        private double calcularArreglo(double desde, double hasta)
        {

            return (desde + this.RNDArregloReloj * (hasta - desde));
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
    public class Ayudante : ICloneable// Representa al Ayudante (Servidor)
    {
        public string AyudanteEstado { get; set; } // Libre, Ocupado
        public int AyudanteQueue { get; set; }
        public double HelperAttentionInit { get; set; }
        public int clienteAtendiendo { get; set; } = 0;

        public Ayudante()
        {
            this.AyudanteEstado = "Libre";
            this.AyudanteQueue = 0;
            this.HelperAttentionInit = 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
    public class Relojero : ICloneable// Representa al Relojero (Servidor)
    {
        public string EstadoRelojero { get; set; } // Libre, Ocupado
        public int QueueRelojero { get; set; }
        public int RelojesParaRetirar { get; set; }

        public Relojero()
        {
            this.EstadoRelojero = "Libre";
            this.QueueRelojero = 0;
            this.RelojesParaRetirar = 3;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public class Estadisticas : ICloneable// Representa Vars Estadísticas
    {
        public double AcumuladorRetirar { get; set; }
        public double RetireRequests { get; set; }
        public double HelperOcupiedBegin { get; set; }
        public double HelperOcupiedAcum { get; set; }
        public double HelperTotalTime { get; set; }
        public double WatchmanOcupiedBegin { get; set; }
        public double RelojeroOcupacionAcum { get; set; }
        public double TiempoTotalRelojero { get; set; }

        // Constructor para el evento de inicialización
        public Estadisticas()
        {
            this.AcumuladorRetirar = 0;
            this.RetireRequests = 0;
            this.HelperOcupiedBegin = 0;
            this.HelperOcupiedAcum = 0;
            this.HelperTotalTime = 0;
            this.WatchmanOcupiedBegin = 0;
            this.RelojeroOcupacionAcum = 0;
            this.TiempoTotalRelojero = 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public class Cliente : ICloneable
    {
        public string EstadoCliente { get; set; } // Esperando Atención, Siendo Atendido
        public string TipoAtencion { get; set; } // Comprar, Entregar, Retirar
        public int Id { get; set; } //Identificador de cliente

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object ToData()
        {
            return new 
            {
                State = this.EstadoCliente.ToString(),
                Reason = this.TipoAtencion.ToString(),
                Order = this.Id.ToString(),
            };
        }
    }
    public class ProbabilityReason
    {
        // Probabilidades: ProbComprar = "Comprar"; ProbEntregar = "Entregar"; ProbRetirar = "Retirar"
        public double from { get; set; }
        public double to { get; set; }
        public double probability { get; set; }
        public double accumProbability { get; set; }
        public string meaning { get; set; } // Comprar, Entregar, Retirar

        public ProbabilityReason(double probability, double from, string meaning)
        {
            this.from = from;
            this.probability = probability;
            this.to = from + probability - 0.0001;
            this.accumProbability = from + probability;
            this.meaning = meaning;
        }
    }
    public static class ProbabilitiesReason
    {
        private static List<ProbabilityReason> probabilitiesReasons;

        public static void generateReasonProbabilities(double buyP, double giveP, double retireP)
        {
            probabilitiesReasons = new List<ProbabilityReason>();
            double from = 0;
            List<string> reasons = new List<string> { Evento.Buy, Evento.Leave, Evento.Retire };
            reasons.ForEach(reason =>
            {
                if (reason == Evento.Buy)
                {
                    probabilitiesReasons.Add(new ProbabilityReason(buyP, from, reason));
                }
                if (reason == Evento.Leave)
                {
                    from += buyP;
                    probabilitiesReasons.Add(new ProbabilityReason(giveP, from, reason));
                }
                if (reason == Evento.Retire)
                {
                    from += giveP;
                    probabilitiesReasons.Add(new ProbabilityReason(retireP, from, reason));
                }
            });
        }

        // Controlar
        public static string getReason(double rnd)
        {
            string reason = "";
            for (int i = 0; i < probabilitiesReasons.Count; i++)
            {
                if (rnd <= probabilitiesReasons[i].to)
                {
                    reason = probabilitiesReasons[i].meaning;
                    break;
                }
            }

            return reason;
        }
    }
}
