namespace WindowsForms
{
    partial class frmPoupanca
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorPoupanca = new System.Windows.Forms.Label();
            this.txtValorPoupanca = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblExibirValorPoupanca = new System.Windows.Forms.Label();
            this.pnlExibirValorPoupanca = new System.Windows.Forms.Panel();
            this.pnlExibirValorPoupanca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcule o rendimento de determinado valor na poupança";
            // 
            // lblValorPoupanca
            // 
            this.lblValorPoupanca.AutoSize = true;
            this.lblValorPoupanca.Location = new System.Drawing.Point(37, 108);
            this.lblValorPoupanca.Name = "lblValorPoupanca";
            this.lblValorPoupanca.Size = new System.Drawing.Size(92, 13);
            this.lblValorPoupanca.TabIndex = 1;
            this.lblValorPoupanca.Text = "Valor depositado: ";
            // 
            // txtValorPoupanca
            // 
            this.txtValorPoupanca.Location = new System.Drawing.Point(135, 105);
            this.txtValorPoupanca.Name = "txtValorPoupanca";
            this.txtValorPoupanca.Size = new System.Drawing.Size(100, 20);
            this.txtValorPoupanca.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 145);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblExibirValorPoupanca
            // 
            this.lblExibirValorPoupanca.AutoSize = true;
            this.lblExibirValorPoupanca.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibirValorPoupanca.Location = new System.Drawing.Point(91, 40);
            this.lblExibirValorPoupanca.Name = "lblExibirValorPoupanca";
            this.lblExibirValorPoupanca.Size = new System.Drawing.Size(0, 26);
            this.lblExibirValorPoupanca.TabIndex = 0;
            this.lblExibirValorPoupanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlExibirValorPoupanca
            // 
            this.pnlExibirValorPoupanca.Controls.Add(this.lblExibirValorPoupanca);
            this.pnlExibirValorPoupanca.Location = new System.Drawing.Point(181, 183);
            this.pnlExibirValorPoupanca.Name = "pnlExibirValorPoupanca";
            this.pnlExibirValorPoupanca.Size = new System.Drawing.Size(200, 100);
            this.pnlExibirValorPoupanca.TabIndex = 2;
            this.pnlExibirValorPoupanca.Visible = false;
            // 
            // frmPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 317);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorPoupanca);
            this.Controls.Add(this.lblValorPoupanca);
            this.Controls.Add(this.pnlExibirValorPoupanca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPoupanca";
            this.Text = "frmPoupanca";
            this.pnlExibirValorPoupanca.ResumeLayout(false);
            this.pnlExibirValorPoupanca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorPoupanca;
        private System.Windows.Forms.TextBox txtValorPoupanca;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblExibirValorPoupanca;
        private System.Windows.Forms.Panel pnlExibirValorPoupanca;
    }
}