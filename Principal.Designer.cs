
namespace iDAQ3___Mai2021
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numVi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVf = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numCiclos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPreTrat = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numIncremento = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTxVarredura = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numResistor = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btLer = new System.Windows.Forms.Button();
            this.panPainel = new System.Windows.Forms.Panel();
            this.lbAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreTrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncremento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistor)).BeginInit();
            this.panPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tensão Inicial:";
            // 
            // numVi
            // 
            this.numVi.DecimalPlaces = 2;
            this.numVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVi.Location = new System.Drawing.Point(212, 20);
            this.numVi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            this.numVi.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147352576});
            this.numVi.Name = "numVi";
            this.numVi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numVi.Size = new System.Drawing.Size(120, 32);
            this.numVi.TabIndex = 1;
            this.numVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numVi.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numVi.ValueChanged += new System.EventHandler(this.numVi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "V";
            // 
            // numVf
            // 
            this.numVf.DecimalPlaces = 2;
            this.numVf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVf.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numVf.Location = new System.Drawing.Point(212, 85);
            this.numVf.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numVf.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numVf.Name = "numVf";
            this.numVf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numVf.Size = new System.Drawing.Size(120, 32);
            this.numVf.TabIndex = 4;
            this.numVf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVf.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numVf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVf.ValueChanged += new System.EventHandler(this.numVf_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tensão Final:";
            // 
            // numCiclos
            // 
            this.numCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCiclos.Location = new System.Drawing.Point(212, 143);
            this.numCiclos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCiclos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCiclos.Name = "numCiclos";
            this.numCiclos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numCiclos.Size = new System.Drawing.Size(120, 32);
            this.numCiclos.TabIndex = 7;
            this.numCiclos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número de Ciclos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "s";
            // 
            // numPreTrat
            // 
            this.numPreTrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPreTrat.Location = new System.Drawing.Point(212, 203);
            this.numPreTrat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numPreTrat.Name = "numPreTrat";
            this.numPreTrat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numPreTrat.Size = new System.Drawing.Size(120, 32);
            this.numPreTrat.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(194, 30);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Pré Tratamento:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "mV";
            // 
            // numIncremento
            // 
            this.numIncremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIncremento.Location = new System.Drawing.Point(564, 20);
            this.numIncremento.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIncremento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIncremento.Name = "numIncremento";
            this.numIncremento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numIncremento.Size = new System.Drawing.Size(120, 32);
            this.numIncremento.TabIndex = 13;
            this.numIncremento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIncremento.ValueChanged += new System.EventHandler(this.numIncremento_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Incremento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(690, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "ms";
            // 
            // numDelay
            // 
            this.numDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelay.Location = new System.Drawing.Point(564, 85);
            this.numDelay.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numDelay.Size = new System.Drawing.Size(120, 32);
            this.numDelay.TabIndex = 16;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.ValueChanged += new System.EventHandler(this.numDelay_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 15;
            this.label10.Text = "Delay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(433, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Taxa de varredura:";
            // 
            // lbTxVarredura
            // 
            this.lbTxVarredura.AutoSize = true;
            this.lbTxVarredura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxVarredura.Location = new System.Drawing.Point(624, 145);
            this.lbTxVarredura.Name = "lbTxVarredura";
            this.lbTxVarredura.Size = new System.Drawing.Size(60, 26);
            this.lbTxVarredura.TabIndex = 19;
            this.lbTxVarredura.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(690, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "mV/s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(690, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 26);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ohms";
            // 
            // numResistor
            // 
            this.numResistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResistor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numResistor.Location = new System.Drawing.Point(564, 203);
            this.numResistor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numResistor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numResistor.Name = "numResistor";
            this.numResistor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numResistor.Size = new System.Drawing.Size(120, 32);
            this.numResistor.TabIndex = 22;
            this.numResistor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(460, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 26);
            this.label14.TabIndex = 21;
            this.label14.Text = "Resistor:";
            // 
            // btLer
            // 
            this.btLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLer.Location = new System.Drawing.Point(10, 318);
            this.btLer.Name = "btLer";
            this.btLer.Size = new System.Drawing.Size(220, 61);
            this.btLer.TabIndex = 24;
            this.btLer.Text = "Ler";
            this.btLer.UseVisualStyleBackColor = true;
            this.btLer.Click += new System.EventHandler(this.btLer_Click);
            // 
            // panPainel
            // 
            this.panPainel.Controls.Add(this.label13);
            this.panPainel.Controls.Add(this.numResistor);
            this.panPainel.Controls.Add(this.label14);
            this.panPainel.Controls.Add(this.label12);
            this.panPainel.Controls.Add(this.lbTxVarredura);
            this.panPainel.Controls.Add(this.label11);
            this.panPainel.Controls.Add(this.label9);
            this.panPainel.Controls.Add(this.numDelay);
            this.panPainel.Controls.Add(this.label10);
            this.panPainel.Controls.Add(this.label7);
            this.panPainel.Controls.Add(this.numIncremento);
            this.panPainel.Controls.Add(this.label8);
            this.panPainel.Controls.Add(this.checkBox1);
            this.panPainel.Controls.Add(this.label5);
            this.panPainel.Controls.Add(this.numPreTrat);
            this.panPainel.Controls.Add(this.numCiclos);
            this.panPainel.Controls.Add(this.label6);
            this.panPainel.Controls.Add(this.label3);
            this.panPainel.Controls.Add(this.numVf);
            this.panPainel.Controls.Add(this.label4);
            this.panPainel.Controls.Add(this.label2);
            this.panPainel.Controls.Add(this.numVi);
            this.panPainel.Controls.Add(this.label1);
            this.panPainel.Location = new System.Drawing.Point(10, 20);
            this.panPainel.Name = "panPainel";
            this.panPainel.Size = new System.Drawing.Size(780, 253);
            this.panPainel.TabIndex = 25;
            // 
            // lbAviso
            // 
            this.lbAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.Location = new System.Drawing.Point(269, 298);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(520, 95);
            this.lbAviso.TabIndex = 26;
            this.lbAviso.Text = "Aguarde! O aparelho está realizando a leitura com os parâmetros especificados. Ao" +
    " final, será possível salvar os dados ou descartá-los.";
            this.lbAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.panPainel);
            this.Controls.Add(this.btLer);
            this.Name = "Principal";
            this.Text = "Voltametria Cíclica com iDAQ-6009";
            ((System.ComponentModel.ISupportInitialize)(this.numVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreTrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncremento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistor)).EndInit();
            this.panPainel.ResumeLayout(false);
            this.panPainel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCiclos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPreTrat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numIncremento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTxVarredura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numResistor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btLer;
        private System.Windows.Forms.Panel panPainel;
        private System.Windows.Forms.Label lbAviso;
    }
}

