namespace pryPerezEtapa4
{
    partial class frmEtapa4
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
            picImagen = new PictureBox();
            btnAuto = new Button();
            btnAvion = new Button();
            btnBarco = new Button();
            btnListar = new Button();
            lstListado = new ListBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Location = new Point(12, 12);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(310, 272);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(348, 207);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(79, 30);
            btnAuto.TabIndex = 2;
            btnAuto.Text = "auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(451, 207);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(79, 30);
            btnAvion.TabIndex = 7;
            btnAvion.Text = "avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(552, 207);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(79, 30);
            btnBarco.TabIndex = 8;
            btnBarco.Text = "barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.CornflowerBlue;
            btnListar.ForeColor = Color.White;
            btnListar.Location = new Point(348, 243);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(109, 41);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // lstListado
            // 
            lstListado.FormattingEnabled = true;
            lstListado.ItemHeight = 15;
            lstListado.Location = new Point(362, 12);
            lstListado.Name = "lstListado";
            lstListado.Size = new Size(246, 169);
            lstListado.TabIndex = 10;
       
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Crimson;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(522, 243);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 41);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmEtapa4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 296);
            Controls.Add(btnLimpiar);
            Controls.Add(lstListado);
            Controls.Add(btnListar);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(btnAuto);
            Controls.Add(picImagen);
            Name = "frmEtapa4";
            Text = "Etapa 4 - CREAR OBJETOS EN LISTA";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagen;
        private Button btnAuto;
        private Button btnAvion;
        private Button btnBarco;
        private Button btnListar;
        private ListBox lstListado;
        private Button btnLimpiar;
    }
}
