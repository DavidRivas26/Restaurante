
namespace Ejercicio_9
{
    partial class FrmMesa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesa));
            this.tlpMesas = new System.Windows.Forms.TableLayoutPanel();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMesas
            // 
            this.tlpMesas.ColumnCount = 2;
            this.tlpMesas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.Controls.Add(this.cbxMesa, 0, 1);
            this.tlpMesas.Controls.Add(this.label2, 0, 1);
            this.tlpMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMesas.Location = new System.Drawing.Point(0, 0);
            this.tlpMesas.Name = "tlpMesas";
            this.tlpMesas.RowCount = 2;
            this.tlpMesas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMesas.Size = new System.Drawing.Size(581, 237);
            this.tlpMesas.TabIndex = 0;
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(293, 121);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(209, 33);
            this.cbxMesa.TabIndex = 4;
            this.cbxMesa.SelectionChangeCommitted += new System.EventHandler(this.cbxMesa_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija la mesa:";
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 237);
            this.Controls.Add(this.tlpMesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMesa";
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.FrmMesa_Load);
            this.tlpMesas.ResumeLayout(false);
            this.tlpMesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMesa;
    }
}

