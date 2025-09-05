namespace SISTEMA_PYMES_03
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.dgarticulos = new System.Windows.Forms.DataGridView();
            this.txtmaximo = new System.Windows.Forms.TextBox();
            this.txtminimo = new System.Windows.Forms.TextBox();
            this.txtpventa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpcompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigoproveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgarticulos
            // 
            this.dgarticulos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgarticulos.Location = new System.Drawing.Point(32, 185);
            this.dgarticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgarticulos.Name = "dgarticulos";
            this.dgarticulos.Size = new System.Drawing.Size(832, 235);
            this.dgarticulos.TabIndex = 37;
            this.dgarticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgarticulos_CellClick);
            this.dgarticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgarticulos_CellContentClick);
            // 
            // txtmaximo
            // 
            this.txtmaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaximo.Location = new System.Drawing.Point(440, 139);
            this.txtmaximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmaximo.Name = "txtmaximo";
            this.txtmaximo.Size = new System.Drawing.Size(150, 34);
            this.txtmaximo.TabIndex = 32;
            this.txtmaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaximo_KeyPress);
            // 
            // txtminimo
            // 
            this.txtminimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminimo.Location = new System.Drawing.Point(267, 139);
            this.txtminimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(165, 34);
            this.txtminimo.TabIndex = 31;
            this.txtminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtminimo_KeyPress);
            // 
            // txtpventa
            // 
            this.txtpventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpventa.Location = new System.Drawing.Point(627, 49);
            this.txtpventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(237, 34);
            this.txtpventa.TabIndex = 27;
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "MÁXIMO:";
            // 
            // txtpcompra
            // 
            this.txtpcompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpcompra.Location = new System.Drawing.Point(363, 49);
            this.txtpcompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(255, 34);
            this.txtpcompra.TabIndex = 28;
            this.txtpcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpcompra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "MÍNIMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "PRECIO DE VENTA:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(153, 49);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(201, 34);
            this.txtdescripcion.TabIndex = 30;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRECIO DE COMPRA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "DESCRIPCIÓN:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(16, 49);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(113, 34);
            this.txtcodigo.TabIndex = 29;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "CÓDIGO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "CÓDIGO PROVEEDOR:";
            // 
            // txtcodigoproveedor
            // 
            this.txtcodigoproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproveedor.Location = new System.Drawing.Point(599, 139);
            this.txtcodigoproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigoproveedor.Name = "txtcodigoproveedor";
            this.txtcodigoproveedor.Size = new System.Drawing.Size(265, 34);
            this.txtcodigoproveedor.TabIndex = 39;
            this.txtcodigoproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigopproveedor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 32);
            this.label8.TabIndex = 40;
            this.label8.Text = "EXISTENCIA:";
            // 
            // txtexistencia
            // 
            this.txtexistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(32, 139);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(226, 34);
            this.txtexistencia.TabIndex = 41;
            this.txtexistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexistencia_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(679, 449);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(185, 94);
            this.btnsalir.TabIndex = 34;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(459, 449);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(185, 94);
            this.btneliminar.TabIndex = 36;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.BorderSize = 2;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(247, 449);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(185, 94);
            this.btnmodificar.TabIndex = 33;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnguardar.FlatAppearance.BorderSize = 2;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(32, 449);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(185, 94);
            this.btnguardar.TabIndex = 35;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SISTEMA_PYMES_03.Properties.Resources.Formulario_fondo;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcodigoproveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgarticulos);
            this.Controls.Add(this.txtmaximo);
            this.Controls.Add(this.txtminimo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtpventa);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpcompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGO DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmArticulos_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgarticulos;
        private System.Windows.Forms.TextBox txtmaximo;
        private System.Windows.Forms.TextBox txtminimo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtpventa;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpcompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigoproveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtexistencia;
    }
}