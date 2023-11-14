namespace PRACTICA
{
    partial class Form1
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
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lSabor = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tFormula = new System.Windows.Forms.TextBox();
            this.tLaboratorio = new System.Windows.Forms.TextBox();
            this.tPatente = new System.Windows.Forms.TextBox();
            this.bMostrar = new System.Windows.Forms.Button();
            this.tMostrar = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bActualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bRegistrar
            // 
            this.bRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrar.Location = new System.Drawing.Point(12, 423);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(121, 35);
            this.bRegistrar.TabIndex = 0;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(737, 423);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(116, 35);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lNombre.Location = new System.Drawing.Point(37, 97);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(100, 25);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // lSabor
            // 
            this.lSabor.AutoSize = true;
            this.lSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSabor.Location = new System.Drawing.Point(37, 148);
            this.lSabor.Name = "lSabor";
            this.lSabor.Size = new System.Drawing.Size(104, 25);
            this.lSabor.TabIndex = 3;
            this.lSabor.Text = "Formula:";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(37, 197);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(139, 25);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Laboratorio:";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.Location = new System.Drawing.Point(39, 244);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(100, 25);
            this.lCantidad.TabIndex = 5;
            this.lCantidad.Text = "Patente:";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(225, 97);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(248, 31);
            this.tNombre.TabIndex = 6;
            this.tNombre.Text = " ";
            // 
            // tFormula
            // 
            this.tFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFormula.Location = new System.Drawing.Point(225, 148);
            this.tFormula.Name = "tFormula";
            this.tFormula.Size = new System.Drawing.Size(248, 31);
            this.tFormula.TabIndex = 7;
            this.tFormula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tLaboratorio
            // 
            this.tLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLaboratorio.Location = new System.Drawing.Point(225, 197);
            this.tLaboratorio.Name = "tLaboratorio";
            this.tLaboratorio.Size = new System.Drawing.Size(248, 31);
            this.tLaboratorio.TabIndex = 8;
            // 
            // tPatente
            // 
            this.tPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPatente.Location = new System.Drawing.Point(225, 244);
            this.tPatente.Name = "tPatente";
            this.tPatente.Size = new System.Drawing.Size(248, 31);
            this.tPatente.TabIndex = 9;
            // 
            // bMostrar
            // 
            this.bMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMostrar.Location = new System.Drawing.Point(156, 423);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(126, 35);
            this.bMostrar.TabIndex = 10;
            this.bMostrar.Text = "Mostrar.";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // tMostrar
            // 
            this.tMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMostrar.Location = new System.Drawing.Point(502, 37);
            this.tMostrar.Multiline = true;
            this.tMostrar.Name = "tMostrar";
            this.tMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tMostrar.Size = new System.Drawing.Size(351, 238);
            this.tMostrar.TabIndex = 11;
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(304, 424);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(119, 34);
            this.bBuscar.TabIndex = 12;
            this.bBuscar.Text = "Buscar.";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(225, 37);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(248, 31);
            this.tBuscar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.Location = new System.Drawing.Point(444, 424);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(134, 34);
            this.bActualizar.TabIndex = 15;
            this.bActualizar.Text = "Actualizar.";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad:";
            // 
            // tPrecio
            // 
            this.tPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrecio.Location = new System.Drawing.Point(225, 287);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(248, 31);
            this.tPrecio.TabIndex = 19;
            // 
            // tCantidad
            // 
            this.tCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCantidad.Location = new System.Drawing.Point(225, 340);
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(248, 31);
            this.tCantidad.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 470);
            this.Controls.Add(this.tCantidad);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tMostrar);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.tPatente);
            this.Controls.Add(this.tLaboratorio);
            this.Controls.Add(this.tFormula);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lSabor);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bRegistrar);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lSabor;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tFormula;
        private System.Windows.Forms.TextBox tLaboratorio;
        private System.Windows.Forms.TextBox tPatente;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.TextBox tMostrar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.TextBox tCantidad;
    }
}

