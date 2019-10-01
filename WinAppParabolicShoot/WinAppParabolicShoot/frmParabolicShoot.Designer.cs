namespace WinAppParabolicShoot
{
    partial class frmParabolicShoot
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParabolicShoot));
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.lblTheta = new System.Windows.Forms.Label();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.grgInputs = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbOutputs.SuspendLayout();
            this.grgInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(56, 92);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(146, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Tiempo de vuelo (s)";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(215, 94);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(101, 20);
            this.txtTime.TabIndex = 4;
            // 
            // txtHigh
            // 
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(215, 64);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(101, 20);
            this.txtHigh.TabIndex = 3;
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(215, 28);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(101, 20);
            this.txtDistance.TabIndex = 2;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(56, 26);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(102, 20);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distancia (m)";
            // 
            // grbOutputs
            // 
            this.grbOutputs.BackColor = System.Drawing.Color.White;
            this.grbOutputs.Controls.Add(this.lblTime);
            this.grbOutputs.Controls.Add(this.txtTime);
            this.grbOutputs.Controls.Add(this.txtHigh);
            this.grbOutputs.Controls.Add(this.txtDistance);
            this.grbOutputs.Controls.Add(this.lblHigh);
            this.grbOutputs.Controls.Add(this.lblDistance);
            this.grbOutputs.Location = new System.Drawing.Point(1, 202);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(419, 143);
            this.grbOutputs.TabIndex = 12;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Enter += new System.EventHandler(this.GrbOutputs_Enter);
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(56, 62);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(78, 20);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Text = "Altura (m)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocity.Location = new System.Drawing.Point(56, 34);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(118, 20);
            this.lblVelocity.TabIndex = 0;
            this.lblVelocity.Text = "Velocidad (m/s)";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(179, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 28);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(215, 93);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(101, 20);
            this.txtTheta.TabIndex = 4;
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheta.Location = new System.Drawing.Point(56, 93);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(122, 20);
            this.lblTheta.TabIndex = 2;
            this.lblTheta.Text = "Ángulo (grados)";
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(215, 36);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(101, 20);
            this.txtVelocity.TabIndex = 1;
            // 
            // grgInputs
            // 
            this.grgInputs.BackColor = System.Drawing.Color.White;
            this.grgInputs.Controls.Add(this.txtTheta);
            this.grgInputs.Controls.Add(this.lblTheta);
            this.grgInputs.Controls.Add(this.txtVelocity);
            this.grgInputs.Controls.Add(this.lblVelocity);
            this.grgInputs.Location = new System.Drawing.Point(1, -1);
            this.grgInputs.Name = "grgInputs";
            this.grgInputs.Size = new System.Drawing.Size(419, 143);
            this.grgInputs.TabIndex = 10;
            this.grgInputs.TabStop = false;
            // 
            // grbProcess
            // 
            this.grbProcess.BackColor = System.Drawing.Color.White;
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(1, 134);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(419, 72);
            this.grbProcess.TabIndex = 11;
            this.grbProcess.TabStop = false;
            // 
            // frmParabolicShoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grgInputs);
            this.Controls.Add(this.grbProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParabolicShoot";
            this.Text = "Tiro Parabólico";
            this.Load += new System.EventHandler(this.FrmParabolicShoot_Load);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grgInputs.ResumeLayout(false);
            this.grgInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.GroupBox grgInputs;
        private System.Windows.Forms.GroupBox grbProcess;
    }
}

