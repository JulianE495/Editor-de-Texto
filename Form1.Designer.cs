namespace Editor_de_Texto
{
    partial class frTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTextEditor));
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMenuArchivo = new System.Windows.Forms.Button();
            this.pnArchivoSubMenu = new System.Windows.Forms.Panel();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveFileAs = new System.Windows.Forms.Button();
            this.btnMenuFormato = new System.Windows.Forms.Button();
            this.pnFormatoSubMenu = new System.Windows.Forms.Panel();
            this.btnTextStyle = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnInicio = new System.Windows.Forms.Panel();
            this.pnEditorTexto = new System.Windows.Forms.Panel();
            this.txtTextEdit = new System.Windows.Forms.RichTextBox();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.pnLeftSide.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnArchivoSubMenu.SuspendLayout();
            this.pnFormatoSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnInicio.SuspendLayout();
            this.pnEditorTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnLeftSide.Controls.Add(this.pnFormatoSubMenu);
            this.pnLeftSide.Controls.Add(this.btnMenuFormato);
            this.pnLeftSide.Controls.Add(this.pnArchivoSubMenu);
            this.pnLeftSide.Controls.Add(this.btnMenuArchivo);
            this.pnLeftSide.Controls.Add(this.btnInicio);
            this.pnLeftSide.Controls.Add(this.pnLogo);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(175, 530);
            this.pnLeftSide.TabIndex = 0;
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(175, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(175, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMenuArchivo
            // 
            this.btnMenuArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnMenuArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuArchivo.FlatAppearance.BorderSize = 0;
            this.btnMenuArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuArchivo.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuArchivo.ForeColor = System.Drawing.Color.White;
            this.btnMenuArchivo.Location = new System.Drawing.Point(0, 140);
            this.btnMenuArchivo.Name = "btnMenuArchivo";
            this.btnMenuArchivo.Size = new System.Drawing.Size(175, 40);
            this.btnMenuArchivo.TabIndex = 2;
            this.btnMenuArchivo.Text = "Archivo";
            this.btnMenuArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuArchivo.UseVisualStyleBackColor = false;
            this.btnMenuArchivo.Click += new System.EventHandler(this.btnMenuArchivo_Click);
            // 
            // pnArchivoSubMenu
            // 
            this.pnArchivoSubMenu.Controls.Add(this.btnSaveFileAs);
            this.pnArchivoSubMenu.Controls.Add(this.btnSaveFile);
            this.pnArchivoSubMenu.Controls.Add(this.btnOpenFile);
            this.pnArchivoSubMenu.Controls.Add(this.btnNewFile);
            this.pnArchivoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnArchivoSubMenu.Location = new System.Drawing.Point(0, 180);
            this.pnArchivoSubMenu.Name = "pnArchivoSubMenu";
            this.pnArchivoSubMenu.Size = new System.Drawing.Size(175, 162);
            this.pnArchivoSubMenu.TabIndex = 3;
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnNewFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFile.ForeColor = System.Drawing.Color.White;
            this.btnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFile.Image")));
            this.btnNewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewFile.Location = new System.Drawing.Point(0, 0);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(175, 40);
            this.btnNewFile.TabIndex = 3;
            this.btnNewFile.Text = "Nuevo";
            this.btnNewFile.UseVisualStyleBackColor = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(175, 40);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Abrir";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSaveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFile.Location = new System.Drawing.Point(0, 80);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(175, 40);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "Guardar";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFileAs
            // 
            this.btnSaveFileAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSaveFileAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveFileAs.FlatAppearance.BorderSize = 0;
            this.btnSaveFileAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFileAs.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveFileAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFileAs.Image")));
            this.btnSaveFileAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFileAs.Location = new System.Drawing.Point(0, 120);
            this.btnSaveFileAs.Name = "btnSaveFileAs";
            this.btnSaveFileAs.Size = new System.Drawing.Size(175, 40);
            this.btnSaveFileAs.TabIndex = 6;
            this.btnSaveFileAs.Text = "Guardar Como";
            this.btnSaveFileAs.UseVisualStyleBackColor = false;
            // 
            // btnMenuFormato
            // 
            this.btnMenuFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnMenuFormato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFormato.FlatAppearance.BorderSize = 0;
            this.btnMenuFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFormato.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFormato.ForeColor = System.Drawing.Color.White;
            this.btnMenuFormato.Location = new System.Drawing.Point(0, 342);
            this.btnMenuFormato.Name = "btnMenuFormato";
            this.btnMenuFormato.Size = new System.Drawing.Size(175, 40);
            this.btnMenuFormato.TabIndex = 4;
            this.btnMenuFormato.Text = "Formato";
            this.btnMenuFormato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFormato.UseVisualStyleBackColor = false;
            this.btnMenuFormato.Click += new System.EventHandler(this.btnMenuFormato_Click);
            // 
            // pnFormatoSubMenu
            // 
            this.pnFormatoSubMenu.Controls.Add(this.btnTextStyle);
            this.pnFormatoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFormatoSubMenu.Location = new System.Drawing.Point(0, 382);
            this.pnFormatoSubMenu.Name = "pnFormatoSubMenu";
            this.pnFormatoSubMenu.Size = new System.Drawing.Size(175, 83);
            this.pnFormatoSubMenu.TabIndex = 5;
            // 
            // btnTextStyle
            // 
            this.btnTextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnTextStyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextStyle.FlatAppearance.BorderSize = 0;
            this.btnTextStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextStyle.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextStyle.ForeColor = System.Drawing.Color.White;
            this.btnTextStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnTextStyle.Image")));
            this.btnTextStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextStyle.Location = new System.Drawing.Point(0, 0);
            this.btnTextStyle.Name = "btnTextStyle";
            this.btnTextStyle.Size = new System.Drawing.Size(175, 40);
            this.btnTextStyle.TabIndex = 7;
            this.btnTextStyle.Text = "Fuente";
            this.btnTextStyle.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(175, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnInicio
            // 
            this.pnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnInicio.Controls.Add(this.pbMainLogo);
            this.pnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInicio.Location = new System.Drawing.Point(175, 0);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(685, 530);
            this.pnInicio.TabIndex = 1;
            // 
            // pnEditorTexto
            // 
            this.pnEditorTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnEditorTexto.Controls.Add(this.txtTextEdit);
            this.pnEditorTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEditorTexto.Location = new System.Drawing.Point(175, 0);
            this.pnEditorTexto.Name = "pnEditorTexto";
            this.pnEditorTexto.Size = new System.Drawing.Size(685, 530);
            this.pnEditorTexto.TabIndex = 2;
            // 
            // txtTextEdit
            // 
            this.txtTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextEdit.Location = new System.Drawing.Point(0, 0);
            this.txtTextEdit.Name = "txtTextEdit";
            this.txtTextEdit.Size = new System.Drawing.Size(685, 530);
            this.txtTextEdit.TabIndex = 0;
            this.txtTextEdit.Text = "";
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMainLogo.Image")));
            this.pbMainLogo.Location = new System.Drawing.Point(62, 40);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(566, 462);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainLogo.TabIndex = 0;
            this.pbMainLogo.TabStop = false;
            // 
            // frTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 530);
            this.Controls.Add(this.pnInicio);
            this.Controls.Add(this.pnEditorTexto);
            this.Controls.Add(this.pnLeftSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnLeftSide.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnArchivoSubMenu.ResumeLayout(false);
            this.pnFormatoSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnInicio.ResumeLayout(false);
            this.pnEditorTexto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.Panel pnFormatoSubMenu;
        private System.Windows.Forms.Button btnTextStyle;
        private System.Windows.Forms.Button btnMenuFormato;
        private System.Windows.Forms.Panel pnArchivoSubMenu;
        private System.Windows.Forms.Button btnSaveFileAs;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnMenuArchivo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnInicio;
        private System.Windows.Forms.Panel pnEditorTexto;
        private System.Windows.Forms.PictureBox pbMainLogo;
        private System.Windows.Forms.RichTextBox txtTextEdit;
    }
}

