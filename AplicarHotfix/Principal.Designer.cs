
namespace AplicarHotfix
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPathHotfix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarMD5 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnPath);
            this.pnlTop.Controls.Add(this.txtPathHotfix);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtMD5);
            this.pnlTop.Controls.Add(this.btnAplicar);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnSelecionarMD5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(891, 123);
            this.pnlTop.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(778, 10);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(101, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "Pasta do Hotfix";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPathHotfix
            // 
            this.txtPathHotfix.Location = new System.Drawing.Point(152, 13);
            this.txtPathHotfix.Name = "txtPathHotfix";
            this.txtPathHotfix.ReadOnly = true;
            this.txtPathHotfix.Size = new System.Drawing.Size(620, 20);
            this.txtPathHotfix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasta Hotfix não oficial:";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(152, 43);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(619, 20);
            this.txtMD5.TabIndex = 6;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(777, 78);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(102, 36);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arquivo MD5 Selecionado:";
            // 
            // btnSelecionarMD5
            // 
            this.btnSelecionarMD5.Location = new System.Drawing.Point(777, 40);
            this.btnSelecionarMD5.Name = "btnSelecionarMD5";
            this.btnSelecionarMD5.Size = new System.Drawing.Size(102, 23);
            this.btnSelecionarMD5.TabIndex = 1;
            this.btnSelecionarMD5.Text = "Selecionar MD5";
            this.btnSelecionarMD5.UseVisualStyleBackColor = true;
            this.btnSelecionarMD5.Click += new System.EventHandler(this.btnSelecionarMD5_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // Principal
            // 
            this.AcceptButton = this.btnAplicar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 123);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicar hotfix não oficial";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSelecionarMD5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPathHotfix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}