namespace Changelist
{
    partial class Changelist
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.changelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changelistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.changelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changelistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // changelistBindingSource
            // 
            this.changelistBindingSource.DataSource = typeof(Changelist.Changelist);
            // 
            // changelistBindingSource1
            // 
            this.changelistBindingSource1.DataSource = typeof(Changelist.Changelist);
            // 
            // Changelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1180, 568);
            this.Name = "Changelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.changelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changelistBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource changelistBindingSource1;
        private System.Windows.Forms.BindingSource changelistBindingSource;
    }
}

