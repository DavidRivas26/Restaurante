
namespace Ejercicio_9
{
    partial class FrmPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersona));
            this.tlpMesas = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.cbxPersona = new System.Windows.Forms.ComboBox();
            this.tlpMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMesas
            // 
            this.tlpMesas.ColumnCount = 2;
            this.tlpMesas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.Controls.Add(this.cbxPersona, 0, 1);
            this.tlpMesas.Controls.Add(this.lblPersonas, 0, 1);
            this.tlpMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesas.Location = new System.Drawing.Point(0, 0);
            this.tlpMesas.Name = "tlpMesas";
            this.tlpMesas.RowCount = 2;
            this.tlpMesas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.Size = new System.Drawing.Size(545, 279);
            this.tlpMesas.TabIndex = 1;
            // 
            // lblPersonas
            // 
            this.lblPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonas.Location = new System.Drawing.Point(14, 138);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(268, 32);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "Cantidad de personas:";
            // 
            // cbxPersona
            // 
            this.cbxPersona.FormattingEnabled = true;
            this.cbxPersona.Location = new System.Drawing.Point(288, 141);
            this.cbxPersona.Name = "cbxPersona";
            this.cbxPersona.Size = new System.Drawing.Size(209, 33);
            this.cbxPersona.TabIndex = 4;
            this.cbxPersona.SelectionChangeCommitted += new System.EventHandler(this.cbxMesa_SelectionChangeCommitted);
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 279);
            this.Controls.Add(this.tlpMesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersona";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.tlpMesas.ResumeLayout(false);
            this.tlpMesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMesas;
        private System.Windows.Forms.ComboBox cbxPersona;
        private System.Windows.Forms.Label lblPersonas;
    }
}