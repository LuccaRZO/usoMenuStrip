namespace AppExemploMenu
{
    partial class Frmcanudocomcafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmcanudocomcafe = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmpedrosilvino = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmpagodin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibir
            // 
            this.exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmcanudocomcafe,
            this.exibirFrmpedrosilvino,
            this.exibirFrmpagodin});
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(47, 20);
            this.exibir.Text = "Exibir";
            // 
            // exibirFrmcanudocomcafe
            // 
            this.exibirFrmcanudocomcafe.Name = "exibirFrmcanudocomcafe";
            this.exibirFrmcanudocomcafe.Size = new System.Drawing.Size(168, 22);
            this.exibirFrmcanudocomcafe.Text = "Canudo com café";
            // 
            // exibirFrmpedrosilvino
            // 
            this.exibirFrmpedrosilvino.Name = "exibirFrmpedrosilvino";
            this.exibirFrmpedrosilvino.Size = new System.Drawing.Size(168, 22);
            this.exibirFrmpedrosilvino.Text = "Pedro Silvino";
            // 
            // exibirFrmpagodin
            // 
            this.exibirFrmpagodin.Name = "exibirFrmpagodin";
            this.exibirFrmpagodin.Size = new System.Drawing.Size(168, 22);
            this.exibirFrmpagodin.Text = "Pagodin";
            // 
            // Frmcanudocomcafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frmcanudocomcafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmcanudocomcafe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmcanudocomcafe;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmpedrosilvino;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmpagodin;
    }
}

