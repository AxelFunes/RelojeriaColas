using RelojeriaColas.Principal;
using RelojeriaColas.ControlVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojeriaColas
{
    public partial class MainForm : Form
    {
        public double AverageOcupiedHelper { get; set; }
        public double AverageOcupiedWatchman { get; set; }
        public double ProbabiliOfFixNotFinished { get; set; }
        public MainForm()
        {
            InitializeComponent();
            SetParametros();
        }
        //Metodos
        private bool ValidarDatos()
        {
            if(string.IsNullOrEmpty(textBoxTiempoSimulacion.Text) || int.Parse(textBoxTiempoSimulacion.Text) < 1 || int.Parse(textBoxTiempoSimulacion.Text) > 100000)
            {
                MessageBox.Show("La cantidad de iteraciones puede ir desde 1 a 100.000", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxIteraciones.Text) || int.Parse(textBoxIteraciones.Text) < 0 || int.Parse(textBoxIteraciones.Text) > int.Parse(textBoxTiempoSimulacion.Text))
            {
                MessageBox.Show("La primera iteracion a mostrar debe estar comprenida entre 1 y la cantidad de iteraciones a simular", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCantidadIteraciones.Text) || int.Parse(textBoxCantidadIteraciones.Text) < 1 || (int.Parse(textBoxCantidadIteraciones.Text) + int.Parse(textBoxIteraciones.Text)) > int.Parse(textBoxTiempoSimulacion.Text))
            {
                MessageBox.Show("La cantidad de iteraciones para mostrar deben estar comprenidas entre 1 y la ultima iteracion a simular", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxPComprar.Text) || string.IsNullOrEmpty(textBoxPRetirar.Text) || string.IsNullOrEmpty(textBoxPEntregar.Text) || double.Parse(textBoxPComprar.Text) < 0 || double.Parse(textBoxPComprar.Text) > 1 || double.Parse(textBoxPEntregar.Text) < 0 || double.Parse(textBoxPEntregar.Text) > 1 || double.Parse(textBoxPRetirar.Text) < 0 || double.Parse(textBoxPRetirar.Text) > 1)
            {
                MessageBox.Show("Las probabilidades deben estar comprendidas entre 0 y 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(double.Parse(textBoxPComprar.Text) + double.Parse(textBoxPEntregar.Text) + double.Parse(textBoxPRetirar.Text) != 1)
            {
                MessageBox.Show("La suma de probabilidades debe ser igual a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxLlegadaClientesD.Text) || double.Parse(textBoxLlegadaClientesD.Text) < 1)
            {
                MessageBox.Show("A de la distribucion de llegada de clientes debe ser mayor o igual a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxTiempoCompraD.Text) ||  double.Parse(textBoxTiempoCompraD.Text) < 1)
            {
                MessageBox.Show("A de la distribucion del tiempo de tardanza de compra debe ser mayor o igual a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxTiempoArregloD.Text) ||  double.Parse(textBoxTiempoArregloD.Text) < 1)
            {
                MessageBox.Show("A de la distribucion del tiempo de reparacion debe ser mayor o igual a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxLlegadaClientesH.Text) || double.Parse(textBoxLlegadaClientesH.Text) <= double.Parse(textBoxLlegadaClientesD.Text))
            {
                MessageBox.Show("B de la distribucion de llegada de clientes debe ser mayor a A", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxTiempoCompraH.Text) || double.Parse(textBoxTiempoCompraH.Text) <= double.Parse(textBoxTiempoCompraD.Text))
            {
                MessageBox.Show("B de la distribucion del tiempo de tardanza de compra debe ser mayor a A", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(string.IsNullOrEmpty(textBoxTiempoArrelgoH.Text) ||  double.Parse(textBoxTiempoArrelgoH.Text) <= double.Parse(textBoxTiempoArregloD.Text))
            {
                MessageBox.Show("B de la distribucion del tiempo de reparacion debe ser mayor a A", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }  
        private ParametrosSimulacion GenerarParametros()
        {
            return new ParametrosSimulacion
            {
                Cantidad = int.Parse(textBoxTiempoSimulacion.Text),
                DesdeMinuto = int.Parse(textBoxIteraciones.Text),
                CantidadIteraciones = int.Parse(textBoxCantidadIteraciones.Text),
                ProbComprar = double.Parse(textBoxPComprar.Text),
                ProbEntregar = double.Parse(textBoxPEntregar.Text),
                ProbRetirar = double.Parse(textBoxPRetirar.Text),
                LlegadaClientesD = double.Parse(textBoxLlegadaClientesD.Text),
                LlegadaClientesH = double.Parse(textBoxLlegadaClientesH.Text),
                TiempoCompraD = double.Parse(textBoxTiempoCompraD.Text),
                TiempoCompraH = double.Parse(textBoxTiempoCompraH.Text),
                TiempoArregloD = double.Parse(textBoxTiempoArregloD.Text),
                TiempoArregloH = double.Parse(textBoxTiempoArrelgoH.Text),
                ProbCafe = double.Parse(txtProbCafe.Text),
                DemoraCafe = double.Parse(txtDemoraCafe.Text),
                A= double.Parse(txtA.Text),
        };
        }
        private void SetParametros()
        {
            ParametrosSimulacion parametros = new ParametrosSimulacion();
            textBoxTiempoSimulacion.Text  = parametros.Cantidad.ToString();
            textBoxIteraciones.Text = parametros.DesdeMinuto.ToString();
            textBoxCantidadIteraciones.Text = parametros.CantidadIteraciones.ToString();
            textBoxPComprar.Text = parametros.ProbComprar.ToString();
            textBoxPEntregar.Text = parametros.ProbEntregar.ToString();
            textBoxPRetirar.Text = parametros.ProbRetirar.ToString();
            textBoxLlegadaClientesD.Text = parametros.LlegadaClientesD.ToString();
            textBoxLlegadaClientesH.Text = parametros.LlegadaClientesH.ToString();
            textBoxTiempoCompraD.Text = parametros.TiempoCompraD.ToString();
            textBoxTiempoCompraH.Text = parametros.TiempoCompraH.ToString();
            textBoxTiempoArregloD.Text = parametros.TiempoArregloD.ToString();
            textBoxTiempoArrelgoH.Text = parametros.TiempoArregloH.ToString();
            txtProbCafe.Text = parametros.ProbCafe.ToString();
            txtDemoraCafe.Text = parametros.DemoraCafe.ToString();
            txtA.Text = parametros.A.ToString();

        }
        private void CargarTabla(List<Queue> queues)
        {
            Queue lastQueue = queues[queues.Count - 1];
            queues.RemoveAt(queues.Count - 1);
            lbl_OcupAyudante.Text = Calculos.TruncateDigits(lastQueue.Stats.HelperOcupiedAcum / lastQueue.Stats.HelperTotalTime, 4).ToString() + "%";
            lbl_Ocup_Relojero.Text = Calculos.TruncateDigits(lastQueue.Stats.RelojeroOcupacionAcum / lastQueue.Stats.TiempoTotalRelojero, 4).ToString() + "%";
            lbl_Prob_ST.Text = Calculos.TruncateDigits((lastQueue.Stats.RetireRequests - lastQueue.Stats.AcumuladorRetirar) / lastQueue.Stats.RetireRequests, 4).ToString();
            //labelStats.Text = "Porcentaje de ocupacion del ayudante = " + Calculos.TruncateDigits(lastQueue.Stats.HelperOcupiedAcum / lastQueue.Stats.HelperTotalTime, 4).ToString();
            //labelStats.Text += " // Porcentaje de ocupacion del relojero = " + Calculos.TruncateDigits(lastQueue.Stats.RelojeroOcupacionAcum / lastQueue.Stats.TiempoTotalRelojero, 4).ToString();
            //labelStats.Text += " // Probabilidad de reloj sin terminar = " + Calculos.TruncateDigits((lastQueue.Stats.RetireRequests - lastQueue.Stats.AcumuladorRetirar) / lastQueue.Stats.RetireRequests, 4).ToString();

            //Last Queue
            dataGridViewLastRow.Rows.Clear();
            BindingSource bindingLastQueueSource = new BindingSource
            {
                DataSource = new
                {
                    Reloj = lastQueue.Reloj,
                    Evento = lastQueue.Evento,
                    RND_Llegada_Cliente = lastQueue.ClientArrival.RNDLlegadaCliente.ToString(),
                    LlegadaCliente = lastQueue.ClientArrival.tiempoLlegada.ToString(),
                    Prox_Llegada_Cliente = lastQueue.ClientArrival.proximaLlegada.ToString(),
                    Estado_Ayudante = lastQueue.Ayudante.AyudanteEstado,
                    Cola_Ayudante = lastQueue.Ayudante.AyudanteQueue.ToString(),
                    RND_Razon_Cliente = lastQueue.ClientReason is null ? "-" : lastQueue.ClientReason.RNDtipoAtencion.ToString(),
                    Razon_Cliente = lastQueue.ClientReason is null ? "-" : lastQueue.ClientReason.Atencion,
                    RND_Atención = lastQueue.Atencion is null ? "-" : lastQueue.Atencion.RNDTiempoAtencion.ToString(),
                    Fin_Atención = lastQueue.Atencion is null ? "-" : lastQueue.Atencion.FinAtencion.ToString(),
                    Estado_Relojero = lastQueue.Relojero.EstadoRelojero,
                    Cola_Relojero = lastQueue.Relojero.QueueRelojero.ToString(),
                    RND_Arreglo = lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.RNDArregloReloj.ToString(),
                    Tiempo_Arreglo = lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.tiempoArreglo.ToString(),
                    Fin_Arreglo = lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.finArreglo.ToString(),
                    RndDescanso = lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.RndCafe.ToString(),
                    Toma= lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.TomaDescanso.ToString(),
                    RndTipo = lastQueue.Coffee is null ? "-" : lastQueue.WatchFix.RndTipo.ToString(),
                    TipoDescanso = lastQueue.Coffee is null ? "-" : lastQueue.Coffee.Cafecito.ToString(),
                    FinDescanso = lastQueue.WatchFix is null ? "-" : lastQueue.WatchFix.FinCafe.ToString(),
                    Relojes_Por_Retirar = lastQueue.Relojero.RelojesParaRetirar.ToString(),
                    Retiros = lastQueue.Stats.AcumuladorRetirar.ToString(),
                    Retiros_Solicitados = lastQueue.Stats.RetireRequests.ToString(),
                    Tiempo_Acumulado_Ocupación_Ayudante = lastQueue.Stats.HelperOcupiedAcum.ToString(),
                    Tiempo_Acumulado_Ocupación_Relojero = lastQueue.Stats.RelojeroOcupacionAcum.ToString(),
                    Clientes = ParseClients(lastQueue.Clients),
                }
            };
            
            dataGridViewLastRow.DataSource = bindingLastQueueSource;

            // Queues For Show
            dataGridViewFromRowToRow.Rows.Clear();
            BindingSource bindingQueuesSource = new BindingSource
            {
                DataSource = queues.Select(row => new {
                    Reloj = row.Reloj,
                    Evento = row.Evento,
                    RND_Llegada_Cliente = row.ClientArrival.RNDLlegadaCliente.ToString(),

                    LlegadaCliente = row.ClientArrival.tiempoLlegada.ToString(),
                    Prox_Llegada_Cliente = row.ClientArrival.proximaLlegada.ToString(),
                    Estado_Ayudante = row.Ayudante.AyudanteEstado,
                    Cola_Ayudante = row.Ayudante.AyudanteQueue.ToString(),
                    RND_Razon_Cliente = row.ClientReason is null ? "-" : row.ClientReason.RNDtipoAtencion.ToString(),
                    Razon_Cliente = row.ClientReason is null ? "-" : row.ClientReason.Atencion,
                    RND_Atención = row.Atencion is null ? "-" : row.Atencion.RNDTiempoAtencion.ToString(),
                    Fin_Atención = row.Atencion is null ? "-" : row.Atencion.FinAtencion.ToString(),
                    Estado_Relojero = row.Relojero.EstadoRelojero,
                    Cola_Relojero = row.Relojero.QueueRelojero.ToString(),
                    Relojes_Por_Retirar = row.Relojero.RelojesParaRetirar.ToString(),
                    RND_Arreglo = row.WatchFix is null ? "-" : row.WatchFix.RNDArregloReloj.ToString(),
                    Tiempo_Arreglo = row.WatchFix is null ? "-" : row.WatchFix.tiempoArreglo.ToString(),
                    Fin_Arreglo = row.WatchFix is null ? "-" : row.WatchFix.finArreglo.ToString(),
                    RndDescanso = row.WatchFix is null ? "-" : row.WatchFix.RndCafe.ToString(),
                    Toma = row.WatchFix is null ? "-" : row.WatchFix.TomaDescanso.ToString(),
                    RndTipo = row.WatchFix is null ? "-" : row.WatchFix.RndTipo.ToString(),
                    TipoDescanso = row.Coffee is null ? "-" : row.Coffee.Cafecito.ToString(),
                    FinDescanso = row.WatchFix is null ? "-" : row.WatchFix.FinCafe.ToString(),
                    Retiros = row.Stats.AcumuladorRetirar.ToString(),
                    Retiros_Solicitados = row.Stats.RetireRequests.ToString(),
                    Tiempo_Acumulado_Ocupación_Ayudante = row.Stats.HelperOcupiedAcum.ToString(),
                    Tiempo_Acumulado_Ocupación_Relojero = row.Stats.RelojeroOcupacionAcum.ToString(),
                    Clientes = ParseClients(row.Clients)
                }).ToList()
            };
            dataGridViewFromRowToRow.DataSource = bindingQueuesSource;
        }
        public string ParseClients(List<Cliente> clients)
        {
            string clientes = "";
            foreach (Cliente client in clients)
            {
                clientes += " | Orden: " + client.Id + " - Estado: " + client.EstadoCliente + " - Razon: " + client.TipoAtencion;
            }
            return clientes;
        }

        //Eventos
        private void BotonSimular(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                QueueSimulation queueSimulation = new QueueSimulation();
                CargarTabla(queueSimulation.crearQueues(GenerarParametros()));
            } 
        }
        private void textBoxTiempoSimulacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbers(e);
        }
        private void textBoxIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbers(e);
        }
        private void textBoxCantidadIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbers(e);
        }
        private void textBoxPComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxPEntregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxPRetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxLlegadaClientesD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxLlegadaClientesH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxTiempoCompraD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxTiempoCompraH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxTiempoArregloD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void textBoxTiempoArregloH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void txtProbCafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }
        private void txtDemoraCafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlV.AllowOnlyNumbersAndDigits(e);
        }

        private void labelQuantityIterations_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTiempoArregloD_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFixParentesis_Click(object sender, EventArgs e)
        {

        }

        private void labelFixComa_Click(object sender, EventArgs e)
        {

        }

        private void labelFix_Click(object sender, EventArgs e)
        {

        }

        private void labelRetireP_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPRetirar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadIteraciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTiempoArrelgoH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

