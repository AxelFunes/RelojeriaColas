namespace RelojeriaColas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProbCafe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.textBoxTiempoArrelgoH = new System.Windows.Forms.TextBox();
            this.textBoxTiempoArregloD = new System.Windows.Forms.TextBox();
            this.labelFixParentesis = new System.Windows.Forms.Label();
            this.labelFixComa = new System.Windows.Forms.Label();
            this.labelFix = new System.Windows.Forms.Label();
            this.textBoxTiempoCompraH = new System.Windows.Forms.TextBox();
            this.textBoxTiempoCompraD = new System.Windows.Forms.TextBox();
            this.labelParenthesisTime = new System.Windows.Forms.Label();
            this.labelComaTime = new System.Windows.Forms.Label();
            this.labelBuyTime = new System.Windows.Forms.Label();
            this.labelRetireP = new System.Windows.Forms.Label();
            this.labelGiveP = new System.Windows.Forms.Label();
            this.labelBuyP = new System.Windows.Forms.Label();
            this.textBoxLlegadaClientesH = new System.Windows.Forms.TextBox();
            this.textBoxLlegadaClientesD = new System.Windows.Forms.TextBox();
            this.labelParentesis = new System.Windows.Forms.Label();
            this.labelComa = new System.Windows.Forms.Label();
            this.textBoxPRetirar = new System.Windows.Forms.TextBox();
            this.labelClientsDistribution = new System.Windows.Forms.Label();
            this.textBoxCantidadIteraciones = new System.Windows.Forms.TextBox();
            this.textBoxPEntregar = new System.Windows.Forms.TextBox();
            this.textBoxIteraciones = new System.Windows.Forms.TextBox();
            this.textBoxPComprar = new System.Windows.Forms.TextBox();
            this.textBoxTiempoSimulacion = new System.Windows.Forms.TextBox();
            this.labelQuantityIterations = new System.Windows.Forms.Label();
            this.labelFromIteration = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dataGridViewFromRowToRow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLastRow = new System.Windows.Forms.DataGridView();
            this.labelStats = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Prob_ST = new System.Windows.Forms.Label();
            this.lbl_Ocup_Relojero = new System.Windows.Forms.Label();
            this.lbl_OcupAyudante = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromRowToRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLastRow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(521, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(541, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sistema de Simulacion de Colas: Relojería B - Grupo 11";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBoxParameters.Controls.Add(this.txtA);
            this.groupBoxParameters.Controls.Add(this.label6);
            this.groupBoxParameters.Controls.Add(this.txtH);
            this.groupBoxParameters.Controls.Add(this.label3);
            this.groupBoxParameters.Controls.Add(this.txtProbCafe);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.buttonSimulate);
            this.groupBoxParameters.Controls.Add(this.textBoxTiempoArrelgoH);
            this.groupBoxParameters.Controls.Add(this.textBoxTiempoArregloD);
            this.groupBoxParameters.Controls.Add(this.labelFixParentesis);
            this.groupBoxParameters.Controls.Add(this.labelFixComa);
            this.groupBoxParameters.Controls.Add(this.labelFix);
            this.groupBoxParameters.Controls.Add(this.textBoxTiempoCompraH);
            this.groupBoxParameters.Controls.Add(this.textBoxTiempoCompraD);
            this.groupBoxParameters.Controls.Add(this.labelParenthesisTime);
            this.groupBoxParameters.Controls.Add(this.labelComaTime);
            this.groupBoxParameters.Controls.Add(this.labelBuyTime);
            this.groupBoxParameters.Controls.Add(this.labelRetireP);
            this.groupBoxParameters.Controls.Add(this.labelGiveP);
            this.groupBoxParameters.Controls.Add(this.labelBuyP);
            this.groupBoxParameters.Controls.Add(this.textBoxLlegadaClientesH);
            this.groupBoxParameters.Controls.Add(this.textBoxLlegadaClientesD);
            this.groupBoxParameters.Controls.Add(this.labelParentesis);
            this.groupBoxParameters.Controls.Add(this.labelComa);
            this.groupBoxParameters.Controls.Add(this.textBoxPRetirar);
            this.groupBoxParameters.Controls.Add(this.labelClientsDistribution);
            this.groupBoxParameters.Controls.Add(this.textBoxCantidadIteraciones);
            this.groupBoxParameters.Controls.Add(this.textBoxPEntregar);
            this.groupBoxParameters.Controls.Add(this.textBoxIteraciones);
            this.groupBoxParameters.Controls.Add(this.textBoxPComprar);
            this.groupBoxParameters.Controls.Add(this.textBoxTiempoSimulacion);
            this.groupBoxParameters.Controls.Add(this.labelQuantityIterations);
            this.groupBoxParameters.Controls.Add(this.labelFromIteration);
            this.groupBoxParameters.Controls.Add(this.labelTime);
            this.groupBoxParameters.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParameters.Location = new System.Drawing.Point(16, 43);
            this.groupBoxParameters.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxParameters.Size = new System.Drawing.Size(1070, 133);
            this.groupBoxParameters.TabIndex = 3;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parámetros";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(935, 69);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 22);
            this.txtA.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(914, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "a:";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(935, 40);
            this.txtH.Margin = new System.Windows.Forms.Padding(2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(76, 22);
            this.txtH.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valor h:";
            // 
            // txtProbCafe
            // 
            this.txtProbCafe.Location = new System.Drawing.Point(935, 14);
            this.txtProbCafe.Margin = new System.Windows.Forms.Padding(2);
            this.txtProbCafe.Name = "txtProbCafe";
            this.txtProbCafe.Size = new System.Drawing.Size(76, 22);
            this.txtProbCafe.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "P() de Descanso:";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSimulate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSimulate.Location = new System.Drawing.Point(972, 91);
            this.buttonSimulate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(94, 42);
            this.buttonSimulate.TabIndex = 24;
            this.buttonSimulate.Text = "Simular";
            this.buttonSimulate.UseVisualStyleBackColor = false;
            this.buttonSimulate.Click += new System.EventHandler(this.BotonSimular);
            // 
            // textBoxTiempoArrelgoH
            // 
            this.textBoxTiempoArrelgoH.Location = new System.Drawing.Point(751, 75);
            this.textBoxTiempoArrelgoH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTiempoArrelgoH.Name = "textBoxTiempoArrelgoH";
            this.textBoxTiempoArrelgoH.Size = new System.Drawing.Size(44, 22);
            this.textBoxTiempoArrelgoH.TabIndex = 23;
            this.textBoxTiempoArrelgoH.TextChanged += new System.EventHandler(this.textBoxTiempoArrelgoH_TextChanged);
            this.textBoxTiempoArrelgoH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempoArregloH_KeyPress);
            // 
            // textBoxTiempoArregloD
            // 
            this.textBoxTiempoArregloD.Location = new System.Drawing.Point(692, 75);
            this.textBoxTiempoArregloD.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTiempoArregloD.Name = "textBoxTiempoArregloD";
            this.textBoxTiempoArregloD.Size = new System.Drawing.Size(44, 22);
            this.textBoxTiempoArregloD.TabIndex = 22;
            this.textBoxTiempoArregloD.TextChanged += new System.EventHandler(this.textBoxTiempoArregloD_TextChanged);
            this.textBoxTiempoArregloD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempoArregloD_KeyPress);
            // 
            // labelFixParentesis
            // 
            this.labelFixParentesis.AutoSize = true;
            this.labelFixParentesis.Location = new System.Drawing.Point(799, 78);
            this.labelFixParentesis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixParentesis.Name = "labelFixParentesis";
            this.labelFixParentesis.Size = new System.Drawing.Size(12, 16);
            this.labelFixParentesis.TabIndex = 21;
            this.labelFixParentesis.Text = ")";
            this.labelFixParentesis.Click += new System.EventHandler(this.labelFixParentesis_Click);
            // 
            // labelFixComa
            // 
            this.labelFixComa.AutoSize = true;
            this.labelFixComa.Location = new System.Drawing.Point(741, 78);
            this.labelFixComa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixComa.Name = "labelFixComa";
            this.labelFixComa.Size = new System.Drawing.Size(11, 16);
            this.labelFixComa.TabIndex = 20;
            this.labelFixComa.Text = ";";
            this.labelFixComa.Click += new System.EventHandler(this.labelFixComa_Click);
            // 
            // labelFix
            // 
            this.labelFix.AutoSize = true;
            this.labelFix.Location = new System.Drawing.Point(564, 78);
            this.labelFix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFix.Name = "labelFix";
            this.labelFix.Size = new System.Drawing.Size(126, 16);
            this.labelFix.TabIndex = 19;
            this.labelFix.Text = "Tiempo de arreglo: U(";
            this.labelFix.Click += new System.EventHandler(this.labelFix_Click);
            // 
            // textBoxTiempoCompraH
            // 
            this.textBoxTiempoCompraH.Location = new System.Drawing.Point(463, 73);
            this.textBoxTiempoCompraH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTiempoCompraH.Name = "textBoxTiempoCompraH";
            this.textBoxTiempoCompraH.Size = new System.Drawing.Size(44, 22);
            this.textBoxTiempoCompraH.TabIndex = 18;
            this.textBoxTiempoCompraH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempoCompraH_KeyPress);
            // 
            // textBoxTiempoCompraD
            // 
            this.textBoxTiempoCompraD.Location = new System.Drawing.Point(405, 73);
            this.textBoxTiempoCompraD.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTiempoCompraD.Name = "textBoxTiempoCompraD";
            this.textBoxTiempoCompraD.Size = new System.Drawing.Size(44, 22);
            this.textBoxTiempoCompraD.TabIndex = 17;
            this.textBoxTiempoCompraD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempoCompraD_KeyPress);
            // 
            // labelParenthesisTime
            // 
            this.labelParenthesisTime.AutoSize = true;
            this.labelParenthesisTime.Location = new System.Drawing.Point(511, 76);
            this.labelParenthesisTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParenthesisTime.Name = "labelParenthesisTime";
            this.labelParenthesisTime.Size = new System.Drawing.Size(12, 16);
            this.labelParenthesisTime.TabIndex = 16;
            this.labelParenthesisTime.Text = ")";
            // 
            // labelComaTime
            // 
            this.labelComaTime.AutoSize = true;
            this.labelComaTime.Location = new System.Drawing.Point(453, 76);
            this.labelComaTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComaTime.Name = "labelComaTime";
            this.labelComaTime.Size = new System.Drawing.Size(11, 16);
            this.labelComaTime.TabIndex = 15;
            this.labelComaTime.Text = ";";
            // 
            // labelBuyTime
            // 
            this.labelBuyTime.AutoSize = true;
            this.labelBuyTime.Location = new System.Drawing.Point(273, 76);
            this.labelBuyTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuyTime.Name = "labelBuyTime";
            this.labelBuyTime.Size = new System.Drawing.Size(129, 16);
            this.labelBuyTime.TabIndex = 14;
            this.labelBuyTime.Text = "Tiempo de compra: U(";
            // 
            // labelRetireP
            // 
            this.labelRetireP.AutoSize = true;
            this.labelRetireP.Location = new System.Drawing.Point(562, 48);
            this.labelRetireP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRetireP.Name = "labelRetireP";
            this.labelRetireP.Size = new System.Drawing.Size(76, 16);
            this.labelRetireP.TabIndex = 13;
            this.labelRetireP.Text = "P() de retiro:";
            this.labelRetireP.Click += new System.EventHandler(this.labelRetireP_Click);
            // 
            // labelGiveP
            // 
            this.labelGiveP.AutoSize = true;
            this.labelGiveP.Location = new System.Drawing.Point(273, 46);
            this.labelGiveP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGiveP.Name = "labelGiveP";
            this.labelGiveP.Size = new System.Drawing.Size(87, 16);
            this.labelGiveP.TabIndex = 12;
            this.labelGiveP.Text = "P() de entrega:";
            // 
            // labelBuyP
            // 
            this.labelBuyP.AutoSize = true;
            this.labelBuyP.Location = new System.Drawing.Point(15, 46);
            this.labelBuyP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuyP.Name = "labelBuyP";
            this.labelBuyP.Size = new System.Drawing.Size(92, 16);
            this.labelBuyP.TabIndex = 11;
            this.labelBuyP.Text = "P() de comprar:";
            // 
            // textBoxLlegadaClientesH
            // 
            this.textBoxLlegadaClientesH.Location = new System.Drawing.Point(194, 71);
            this.textBoxLlegadaClientesH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLlegadaClientesH.Name = "textBoxLlegadaClientesH";
            this.textBoxLlegadaClientesH.Size = new System.Drawing.Size(44, 22);
            this.textBoxLlegadaClientesH.TabIndex = 15;
            this.textBoxLlegadaClientesH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLlegadaClientesH_KeyPress);
            // 
            // textBoxLlegadaClientesD
            // 
            this.textBoxLlegadaClientesD.Location = new System.Drawing.Point(129, 71);
            this.textBoxLlegadaClientesD.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLlegadaClientesD.Name = "textBoxLlegadaClientesD";
            this.textBoxLlegadaClientesD.Size = new System.Drawing.Size(44, 22);
            this.textBoxLlegadaClientesD.TabIndex = 14;
            this.textBoxLlegadaClientesD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLlegadaClientesD_KeyPress);
            // 
            // labelParentesis
            // 
            this.labelParentesis.AutoSize = true;
            this.labelParentesis.Location = new System.Drawing.Point(238, 73);
            this.labelParentesis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParentesis.Name = "labelParentesis";
            this.labelParentesis.Size = new System.Drawing.Size(12, 16);
            this.labelParentesis.TabIndex = 8;
            this.labelParentesis.Text = ")";
            // 
            // labelComa
            // 
            this.labelComa.AutoSize = true;
            this.labelComa.Location = new System.Drawing.Point(180, 73);
            this.labelComa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComa.Name = "labelComa";
            this.labelComa.Size = new System.Drawing.Size(11, 16);
            this.labelComa.TabIndex = 7;
            this.labelComa.Text = ";";
            // 
            // textBoxPRetirar
            // 
            this.textBoxPRetirar.Location = new System.Drawing.Point(641, 45);
            this.textBoxPRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPRetirar.Name = "textBoxPRetirar";
            this.textBoxPRetirar.Size = new System.Drawing.Size(76, 22);
            this.textBoxPRetirar.TabIndex = 13;
            this.textBoxPRetirar.TextChanged += new System.EventHandler(this.textBoxPRetirar_TextChanged);
            this.textBoxPRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPRetirar_KeyPress);
            // 
            // labelClientsDistribution
            // 
            this.labelClientsDistribution.AutoSize = true;
            this.labelClientsDistribution.Location = new System.Drawing.Point(14, 74);
            this.labelClientsDistribution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientsDistribution.Name = "labelClientsDistribution";
            this.labelClientsDistribution.Size = new System.Drawing.Size(112, 16);
            this.labelClientsDistribution.TabIndex = 6;
            this.labelClientsDistribution.Text = "Llegada clientes: U(";
            // 
            // textBoxCantidadIteraciones
            // 
            this.textBoxCantidadIteraciones.Location = new System.Drawing.Point(692, 14);
            this.textBoxCantidadIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantidadIteraciones.Name = "textBoxCantidadIteraciones";
            this.textBoxCantidadIteraciones.Size = new System.Drawing.Size(76, 22);
            this.textBoxCantidadIteraciones.TabIndex = 5;
            this.textBoxCantidadIteraciones.TextChanged += new System.EventHandler(this.textBoxCantidadIteraciones_TextChanged);
            this.textBoxCantidadIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidadIteraciones_KeyPress);
            // 
            // textBoxPEntregar
            // 
            this.textBoxPEntregar.Location = new System.Drawing.Point(373, 42);
            this.textBoxPEntregar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPEntregar.Name = "textBoxPEntregar";
            this.textBoxPEntregar.Size = new System.Drawing.Size(76, 22);
            this.textBoxPEntregar.TabIndex = 12;
            this.textBoxPEntregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPEntregar_KeyPress);
            // 
            // textBoxIteraciones
            // 
            this.textBoxIteraciones.Location = new System.Drawing.Point(430, 12);
            this.textBoxIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIteraciones.Name = "textBoxIteraciones";
            this.textBoxIteraciones.Size = new System.Drawing.Size(76, 22);
            this.textBoxIteraciones.TabIndex = 4;
            this.textBoxIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIteraciones_KeyPress);
            // 
            // textBoxPComprar
            // 
            this.textBoxPComprar.Location = new System.Drawing.Point(114, 43);
            this.textBoxPComprar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPComprar.Name = "textBoxPComprar";
            this.textBoxPComprar.Size = new System.Drawing.Size(76, 22);
            this.textBoxPComprar.TabIndex = 9;
            this.textBoxPComprar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPComprar_KeyPress);
            // 
            // textBoxTiempoSimulacion
            // 
            this.textBoxTiempoSimulacion.Location = new System.Drawing.Point(162, 12);
            this.textBoxTiempoSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTiempoSimulacion.Name = "textBoxTiempoSimulacion";
            this.textBoxTiempoSimulacion.Size = new System.Drawing.Size(76, 22);
            this.textBoxTiempoSimulacion.TabIndex = 3;
            this.textBoxTiempoSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempoSimulacion_KeyPress);
            // 
            // labelQuantityIterations
            // 
            this.labelQuantityIterations.AutoSize = true;
            this.labelQuantityIterations.Location = new System.Drawing.Point(562, 17);
            this.labelQuantityIterations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantityIterations.Name = "labelQuantityIterations";
            this.labelQuantityIterations.Size = new System.Drawing.Size(128, 16);
            this.labelQuantityIterations.TabIndex = 2;
            this.labelQuantityIterations.Text = "Cant de iteraciones (i):";
            this.labelQuantityIterations.Click += new System.EventHandler(this.labelQuantityIterations_Click);
            // 
            // labelFromIteration
            // 
            this.labelFromIteration.AutoSize = true;
            this.labelFromIteration.Location = new System.Drawing.Point(273, 15);
            this.labelFromIteration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFromIteration.Name = "labelFromIteration";
            this.labelFromIteration.Size = new System.Drawing.Size(154, 16);
            this.labelFromIteration.TabIndex = 1;
            this.labelFromIteration.Text = "Mostrar desde iteración (j):";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(14, 15);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(148, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Tiempo de simulación (X):";
            // 
            // dataGridViewFromRowToRow
            // 
            this.dataGridViewFromRowToRow.AllowUserToAddRows = false;
            this.dataGridViewFromRowToRow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFromRowToRow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFromRowToRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFromRowToRow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewFromRowToRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFromRowToRow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFromRowToRow.Location = new System.Drawing.Point(16, 180);
            this.dataGridViewFromRowToRow.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFromRowToRow.Name = "dataGridViewFromRowToRow";
            this.dataGridViewFromRowToRow.ReadOnly = true;
            this.dataGridViewFromRowToRow.RowHeadersVisible = false;
            this.dataGridViewFromRowToRow.RowHeadersWidth = 51;
            this.dataGridViewFromRowToRow.RowTemplate.Height = 24;
            this.dataGridViewFromRowToRow.Size = new System.Drawing.Size(1473, 490);
            this.dataGridViewFromRowToRow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 672);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ultima Fila";
            // 
            // dataGridViewLastRow
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLastRow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLastRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLastRow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewLastRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLastRow.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLastRow.Location = new System.Drawing.Point(16, 698);
            this.dataGridViewLastRow.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLastRow.Name = "dataGridViewLastRow";
            this.dataGridViewLastRow.RowHeadersVisible = false;
            this.dataGridViewLastRow.RowHeadersWidth = 51;
            this.dataGridViewLastRow.RowTemplate.Height = 24;
            this.dataGridViewLastRow.Size = new System.Drawing.Size(1473, 87);
            this.dataGridViewLastRow.TabIndex = 6;
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStats.Location = new System.Drawing.Point(22, 142);
            this.labelStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(0, 16);
            this.labelStats.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ocupacion del ayudante:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lbl_Prob_ST);
            this.groupBox1.Controls.Add(this.lbl_Ocup_Relojero);
            this.groupBox1.Controls.Add(this.lbl_OcupAyudante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1155, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lbl_Prob_ST
            // 
            this.lbl_Prob_ST.AutoSize = true;
            this.lbl_Prob_ST.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prob_ST.Location = new System.Drawing.Point(162, 70);
            this.lbl_Prob_ST.Name = "lbl_Prob_ST";
            this.lbl_Prob_ST.Size = new System.Drawing.Size(33, 19);
            this.lbl_Prob_ST.TabIndex = 16;
            this.lbl_Prob_ST.Text = "____";
            // 
            // lbl_Ocup_Relojero
            // 
            this.lbl_Ocup_Relojero.AutoSize = true;
            this.lbl_Ocup_Relojero.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ocup_Relojero.Location = new System.Drawing.Point(162, 47);
            this.lbl_Ocup_Relojero.Name = "lbl_Ocup_Relojero";
            this.lbl_Ocup_Relojero.Size = new System.Drawing.Size(33, 19);
            this.lbl_Ocup_Relojero.TabIndex = 15;
            this.lbl_Ocup_Relojero.Text = "____";
            // 
            // lbl_OcupAyudante
            // 
            this.lbl_OcupAyudante.AutoSize = true;
            this.lbl_OcupAyudante.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OcupAyudante.Location = new System.Drawing.Point(162, 24);
            this.lbl_OcupAyudante.Name = "lbl_OcupAyudante";
            this.lbl_OcupAyudante.Size = new System.Drawing.Size(33, 19);
            this.lbl_OcupAyudante.TabIndex = 14;
            this.lbl_OcupAyudante.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "P() Reloj sin terminar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ocupacion del relojero:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1536, 796);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.dataGridViewLastRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFromRowToRow);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simulacion Colas Relojeria";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromRowToRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLastRow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelFromIteration;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelQuantityIterations;
        private System.Windows.Forms.TextBox textBoxCantidadIteraciones;
        private System.Windows.Forms.TextBox textBoxIteraciones;
        private System.Windows.Forms.TextBox textBoxTiempoSimulacion;
        private System.Windows.Forms.TextBox textBoxLlegadaClientesH;
        private System.Windows.Forms.TextBox textBoxLlegadaClientesD;
        private System.Windows.Forms.Label labelParentesis;
        private System.Windows.Forms.Label labelComa;
        private System.Windows.Forms.Label labelClientsDistribution;
        private System.Windows.Forms.Label labelRetireP;
        private System.Windows.Forms.Label labelGiveP;
        private System.Windows.Forms.Label labelBuyP;
        private System.Windows.Forms.TextBox textBoxPRetirar;
        private System.Windows.Forms.TextBox textBoxPEntregar;
        private System.Windows.Forms.TextBox textBoxPComprar;
        private System.Windows.Forms.TextBox textBoxTiempoCompraH;
        private System.Windows.Forms.TextBox textBoxTiempoCompraD;
        private System.Windows.Forms.Label labelParenthesisTime;
        private System.Windows.Forms.Label labelComaTime;
        private System.Windows.Forms.Label labelBuyTime;
        private System.Windows.Forms.TextBox textBoxTiempoArrelgoH;
        private System.Windows.Forms.TextBox textBoxTiempoArregloD;
        private System.Windows.Forms.Label labelFixParentesis;
        private System.Windows.Forms.Label labelFixComa;
        private System.Windows.Forms.Label labelFix;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.DataGridView dataGridViewFromRowToRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLastRow;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProbCafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Prob_ST;
        private System.Windows.Forms.Label lbl_Ocup_Relojero;
        private System.Windows.Forms.Label lbl_OcupAyudante;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label6;
    }
}

