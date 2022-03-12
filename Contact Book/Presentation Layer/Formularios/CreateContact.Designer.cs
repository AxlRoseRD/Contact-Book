
namespace Presentation_Layer.Formularios
{
    partial class CreateContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateContact));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbMovil = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbGenero = new System.Windows.Forms.TextBox();
            this.txtbBirthDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEstadoCiivl = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(22, 170);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(157, 24);
            this.txtbNombre.TabIndex = 2;
            this.txtbNombre.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTelefono.Location = new System.Drawing.Point(22, 277);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(157, 24);
            this.txtbTelefono.TabIndex = 3;
            this.txtbTelefono.Enter += new System.EventHandler(this.txtbTelefono_Enter);
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDireccion.Location = new System.Drawing.Point(22, 348);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(157, 24);
            this.txtbDireccion.TabIndex = 4;
            this.txtbDireccion.Enter += new System.EventHandler(this.txtbDireccion_Enter);
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(22, 313);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(157, 24);
            this.txtbEmail.TabIndex = 7;
            this.txtbEmail.Enter += new System.EventHandler(this.txtbEmail_Enter);
            // 
            // txtbMovil
            // 
            this.txtbMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMovil.Location = new System.Drawing.Point(22, 241);
            this.txtbMovil.Name = "txtbMovil";
            this.txtbMovil.Size = new System.Drawing.Size(157, 24);
            this.txtbMovil.TabIndex = 6;
            this.txtbMovil.Enter += new System.EventHandler(this.txtbMovil_Enter);
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.Location = new System.Drawing.Point(22, 205);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(157, 24);
            this.txtbApellido.TabIndex = 5;
            this.txtbApellido.Enter += new System.EventHandler(this.txtbApellido_Enter);
            // 
            // txtbGenero
            // 
            this.txtbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGenero.Location = new System.Drawing.Point(227, 205);
            this.txtbGenero.Name = "txtbGenero";
            this.txtbGenero.Size = new System.Drawing.Size(140, 24);
            this.txtbGenero.TabIndex = 10;
            this.txtbGenero.Enter += new System.EventHandler(this.txtbGenero_Enter);
            // 
            // txtbBirthDate
            // 
            this.txtbBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.txtbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBirthDate.Location = new System.Drawing.Point(227, 170);
            this.txtbBirthDate.Name = "txtbBirthDate";
            this.txtbBirthDate.Size = new System.Drawing.Size(140, 24);
            this.txtbBirthDate.TabIndex = 8;
            this.txtbBirthDate.Enter += new System.EventHandler(this.txtbBirthDate_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 42);
            this.panel1.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(345, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 42);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxEstadoCiivl
            // 
            this.comboBoxEstadoCiivl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(154)))));
            this.comboBoxEstadoCiivl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstadoCiivl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstadoCiivl.FormattingEnabled = true;
            this.comboBoxEstadoCiivl.Items.AddRange(new object[] {
            "Casado",
            "Divorciado",
            "Soltero",
            "Viudo"});
            this.comboBoxEstadoCiivl.Location = new System.Drawing.Point(227, 241);
            this.comboBoxEstadoCiivl.Name = "comboBoxEstadoCiivl";
            this.comboBoxEstadoCiivl.Size = new System.Drawing.Size(140, 26);
            this.comboBoxEstadoCiivl.TabIndex = 13;
            this.comboBoxEstadoCiivl.Text = "Estado civil";
            // 
            // CreateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(389, 441);
            this.Controls.Add(this.comboBoxEstadoCiivl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbGenero);
            this.Controls.Add(this.txtbBirthDate);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbMovil);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateContact";
            this.Text = "Create new contact";
            this.Load += new System.EventHandler(this.CreateContact_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbMovil;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbGenero;
        private System.Windows.Forms.TextBox txtbBirthDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxEstadoCiivl;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}