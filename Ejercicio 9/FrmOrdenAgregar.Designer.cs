
namespace Ejercicio_9
{
    partial class FrmOrdenAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenAgregar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEntreda = new System.Windows.Forms.Label();
            this.lblPlato = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxEntrada = new System.Windows.Forms.ComboBox();
            this.cbxPlatoFuerte = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBebida = new System.Windows.Forms.Label();
            this.lblPostre = new System.Windows.Forms.Label();
            this.cbxBebida = new System.Windows.Forms.ComboBox();
            this.cbxPostre = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEntreda, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlato, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxEntrada, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxPlatoFuerte, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBebida, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPostre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxBebida, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxPostre, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(118, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 32);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEntreda
            // 
            this.lblEntreda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntreda.AutoSize = true;
            this.lblEntreda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntreda.Location = new System.Drawing.Point(124, 120);
            this.lblEntreda.Name = "lblEntreda";
            this.lblEntreda.Size = new System.Drawing.Size(102, 32);
            this.lblEntreda.TabIndex = 1;
            this.lblEntreda.Text = "Entrada";
            // 
            // lblPlato
            // 
            this.lblPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlato.AutoSize = true;
            this.lblPlato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlato.Location = new System.Drawing.Point(73, 180);
            this.lblPlato.Name = "lblPlato";
            this.lblPlato.Size = new System.Drawing.Size(153, 32);
            this.lblPlato.TabIndex = 2;
            this.lblPlato.Text = "Plato Fuerte";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // cbxEntrada
            // 
            this.cbxEntrada.FormattingEnabled = true;
            this.cbxEntrada.Location = new System.Drawing.Point(232, 123);
            this.cbxEntrada.Name = "cbxEntrada";
            this.cbxEntrada.Size = new System.Drawing.Size(182, 33);
            this.cbxEntrada.TabIndex = 6;
            // 
            // cbxPlatoFuerte
            // 
            this.cbxPlatoFuerte.FormattingEnabled = true;
            this.cbxPlatoFuerte.Location = new System.Drawing.Point(232, 183);
            this.cbxPlatoFuerte.Name = "cbxPlatoFuerte";
            this.cbxPlatoFuerte.Size = new System.Drawing.Size(182, 33);
            this.cbxPlatoFuerte.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Location = new System.Drawing.Point(3, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(223, 60);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(232, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(223, 60);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblBebida
            // 
            this.lblBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBebida.AutoSize = true;
            this.lblBebida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBebida.Location = new System.Drawing.Point(134, 300);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(92, 32);
            this.lblBebida.TabIndex = 3;
            this.lblBebida.Text = "Bebida";
            // 
            // lblPostre
            // 
            this.lblPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostre.AutoSize = true;
            this.lblPostre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPostre.Location = new System.Drawing.Point(140, 240);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(86, 32);
            this.lblPostre.TabIndex = 4;
            this.lblPostre.Text = "Postre";
            // 
            // cbxBebida
            // 
            this.cbxBebida.FormattingEnabled = true;
            this.cbxBebida.Location = new System.Drawing.Point(232, 303);
            this.cbxBebida.Name = "cbxBebida";
            this.cbxBebida.Size = new System.Drawing.Size(182, 33);
            this.cbxBebida.TabIndex = 8;
            // 
            // cbxPostre
            // 
            this.cbxPostre.FormattingEnabled = true;
            this.cbxPostre.Location = new System.Drawing.Point(232, 243);
            this.cbxPostre.Name = "cbxPostre";
            this.cbxPostre.Size = new System.Drawing.Size(182, 33);
            this.cbxPostre.TabIndex = 9;
            // 
            // FrmOrdenAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdenAgregar";
            this.Text = "Orden";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenAgregar_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrdenAgregar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEntreda;
        private System.Windows.Forms.Label lblPlato;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.Label lblPostre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxEntrada;
        private System.Windows.Forms.ComboBox cbxPlatoFuerte;
        private System.Windows.Forms.ComboBox cbxBebida;
        private System.Windows.Forms.ComboBox cbxPostre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}