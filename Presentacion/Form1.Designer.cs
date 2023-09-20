namespace Presentacion
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
            this.NombreJugador = new System.Windows.Forms.Label();
            this.TxbNomJug = new System.Windows.Forms.TextBox();
            this.CargarUsuario = new System.Windows.Forms.Button();
            this.TxBApellido = new System.Windows.Forms.TextBox();
            this.TxBFechaNacimiento = new System.Windows.Forms.TextBox();
            this.TxBUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxBIDUsuario = new System.Windows.Forms.TextBox();
            this.ModUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.ListarUsuarios = new System.Windows.Forms.Button();
            this.DeleteJuego = new System.Windows.Forms.Button();
            this.ModJuego = new System.Windows.Forms.Button();
            this.TxBIDVideojueego = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxBGeneroVideojueego = new System.Windows.Forms.TextBox();
            this.TxBEstudioVideojueego = new System.Windows.Forms.TextBox();
            this.CargarVideojuego = new System.Windows.Forms.Button();
            this.TxBNombreVideojueego = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxVideojuego = new System.Windows.Forms.ListBox();
            this.listBoxTopUsers = new System.Windows.Forms.ListBox();
            this.ListarVideojuegos = new System.Windows.Forms.Button();
            this.ListarTopUsers = new System.Windows.Forms.Button();
            this.IDJuegadorInsertScore = new System.Windows.Forms.TextBox();
            this.IDJuegoInsertScore = new System.Windows.Forms.TextBox();
            this.ScoreJugador = new System.Windows.Forms.TextBox();
            this.CargarScore = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreJugador
            // 
            this.NombreJugador.AutoSize = true;
            this.NombreJugador.Location = new System.Drawing.Point(11, 14);
            this.NombreJugador.Name = "NombreJugador";
            this.NombreJugador.Size = new System.Drawing.Size(82, 13);
            this.NombreJugador.TabIndex = 0;
            this.NombreJugador.Text = "Nombre jugador";
            // 
            // TxbNomJug
            // 
            this.TxbNomJug.Location = new System.Drawing.Point(121, 14);
            this.TxbNomJug.Name = "TxbNomJug";
            this.TxbNomJug.Size = new System.Drawing.Size(100, 20);
            this.TxbNomJug.TabIndex = 1;
            // 
            // CargarUsuario
            // 
            this.CargarUsuario.Location = new System.Drawing.Point(246, 12);
            this.CargarUsuario.Name = "CargarUsuario";
            this.CargarUsuario.Size = new System.Drawing.Size(116, 23);
            this.CargarUsuario.TabIndex = 2;
            this.CargarUsuario.Text = "Cargar Usuario";
            this.CargarUsuario.UseVisualStyleBackColor = true;
            this.CargarUsuario.Click += new System.EventHandler(this.CargarUsuario_Click);
            // 
            // TxBApellido
            // 
            this.TxBApellido.Location = new System.Drawing.Point(121, 40);
            this.TxBApellido.Name = "TxBApellido";
            this.TxBApellido.Size = new System.Drawing.Size(100, 20);
            this.TxBApellido.TabIndex = 3;
            // 
            // TxBFechaNacimiento
            // 
            this.TxBFechaNacimiento.Location = new System.Drawing.Point(121, 66);
            this.TxBFechaNacimiento.Name = "TxBFechaNacimiento";
            this.TxBFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.TxBFechaNacimiento.TabIndex = 4;
            // 
            // TxBUsuario
            // 
            this.TxBUsuario.Location = new System.Drawing.Point(121, 92);
            this.TxBUsuario.Name = "TxBUsuario";
            this.TxBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxBUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // TxBIDUsuario
            // 
            this.TxBIDUsuario.Location = new System.Drawing.Point(121, 119);
            this.TxBIDUsuario.Name = "TxBIDUsuario";
            this.TxBIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxBIDUsuario.TabIndex = 10;
            this.TxBIDUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ModUser
            // 
            this.ModUser.Location = new System.Drawing.Point(246, 64);
            this.ModUser.Name = "ModUser";
            this.ModUser.Size = new System.Drawing.Size(116, 23);
            this.ModUser.TabIndex = 11;
            this.ModUser.Text = "Modificar Usuario";
            this.ModUser.UseVisualStyleBackColor = true;
            this.ModUser.Click += new System.EventHandler(this.ModUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(246, 119);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(116, 23);
            this.DeleteUser.TabIndex = 12;
            this.DeleteUser.Text = "Eliminar Usuario";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.Location = new System.Drawing.Point(12, 221);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(209, 95);
            this.listBoxUser.TabIndex = 13;
            // 
            // ListarUsuarios
            // 
            this.ListarUsuarios.Location = new System.Drawing.Point(14, 192);
            this.ListarUsuarios.Name = "ListarUsuarios";
            this.ListarUsuarios.Size = new System.Drawing.Size(116, 23);
            this.ListarUsuarios.TabIndex = 14;
            this.ListarUsuarios.Text = "Listar Usuarios";
            this.ListarUsuarios.UseVisualStyleBackColor = true;
            this.ListarUsuarios.Click += new System.EventHandler(this.ListarUsuarios_Click);
            // 
            // DeleteJuego
            // 
            this.DeleteJuego.Location = new System.Drawing.Point(746, 71);
            this.DeleteJuego.Name = "DeleteJuego";
            this.DeleteJuego.Size = new System.Drawing.Size(116, 23);
            this.DeleteJuego.TabIndex = 27;
            this.DeleteJuego.Text = "Eliminar Juego";
            this.DeleteJuego.UseVisualStyleBackColor = true;
            this.DeleteJuego.Click += new System.EventHandler(this.DeleteJuego_Click);
            // 
            // ModJuego
            // 
            this.ModJuego.Location = new System.Drawing.Point(746, 42);
            this.ModJuego.Name = "ModJuego";
            this.ModJuego.Size = new System.Drawing.Size(116, 23);
            this.ModJuego.TabIndex = 26;
            this.ModJuego.Text = "Modificar Juego";
            this.ModJuego.UseVisualStyleBackColor = true;
            this.ModJuego.Click += new System.EventHandler(this.ModJuego_Click);
            // 
            // TxBIDVideojueego
            // 
            this.TxBIDVideojueego.Location = new System.Drawing.Point(621, 95);
            this.TxBIDVideojueego.Name = "TxBIDVideojueego";
            this.TxBIDVideojueego.Size = new System.Drawing.Size(100, 20);
            this.TxBIDVideojueego.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gennero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estudio";
            // 
            // TxBGeneroVideojueego
            // 
            this.TxBGeneroVideojueego.Location = new System.Drawing.Point(621, 68);
            this.TxBGeneroVideojueego.Name = "TxBGeneroVideojueego";
            this.TxBGeneroVideojueego.Size = new System.Drawing.Size(100, 20);
            this.TxBGeneroVideojueego.TabIndex = 20;
            // 
            // TxBEstudioVideojueego
            // 
            this.TxBEstudioVideojueego.Location = new System.Drawing.Point(621, 41);
            this.TxBEstudioVideojueego.Name = "TxBEstudioVideojueego";
            this.TxBEstudioVideojueego.Size = new System.Drawing.Size(100, 20);
            this.TxBEstudioVideojueego.TabIndex = 18;
            // 
            // CargarVideojuego
            // 
            this.CargarVideojuego.Location = new System.Drawing.Point(746, 13);
            this.CargarVideojuego.Name = "CargarVideojuego";
            this.CargarVideojuego.Size = new System.Drawing.Size(116, 23);
            this.CargarVideojuego.TabIndex = 17;
            this.CargarVideojuego.Text = "Cargar Juego";
            this.CargarVideojuego.UseVisualStyleBackColor = true;
            this.CargarVideojuego.Click += new System.EventHandler(this.CargarVideojuego_Click);
            // 
            // TxBNombreVideojueego
            // 
            this.TxBNombreVideojueego.Location = new System.Drawing.Point(621, 15);
            this.TxBNombreVideojueego.Name = "TxBNombreVideojueego";
            this.TxBNombreVideojueego.Size = new System.Drawing.Size(100, 20);
            this.TxBNombreVideojueego.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre Videojuego";
            // 
            // listBoxVideojuego
            // 
            this.listBoxVideojuego.FormattingEnabled = true;
            this.listBoxVideojuego.Location = new System.Drawing.Point(585, 221);
            this.listBoxVideojuego.Name = "listBoxVideojuego";
            this.listBoxVideojuego.Size = new System.Drawing.Size(209, 95);
            this.listBoxVideojuego.TabIndex = 28;
            // 
            // listBoxTopUsers
            // 
            this.listBoxTopUsers.FormattingEnabled = true;
            this.listBoxTopUsers.Location = new System.Drawing.Point(286, 322);
            this.listBoxTopUsers.Name = "listBoxTopUsers";
            this.listBoxTopUsers.Size = new System.Drawing.Size(209, 95);
            this.listBoxTopUsers.TabIndex = 29;
            // 
            // ListarVideojuegos
            // 
            this.ListarVideojuegos.Location = new System.Drawing.Point(585, 192);
            this.ListarVideojuegos.Name = "ListarVideojuegos";
            this.ListarVideojuegos.Size = new System.Drawing.Size(116, 23);
            this.ListarVideojuegos.TabIndex = 30;
            this.ListarVideojuegos.Text = "Listar Videojuegos";
            this.ListarVideojuegos.UseVisualStyleBackColor = true;
            this.ListarVideojuegos.Click += new System.EventHandler(this.ListarVideojuegos_Click);
            // 
            // ListarTopUsers
            // 
            this.ListarTopUsers.Location = new System.Drawing.Point(286, 293);
            this.ListarTopUsers.Name = "ListarTopUsers";
            this.ListarTopUsers.Size = new System.Drawing.Size(116, 23);
            this.ListarTopUsers.TabIndex = 31;
            this.ListarTopUsers.Text = "Listar Top3 Usuarios";
            this.ListarTopUsers.UseVisualStyleBackColor = true;
            this.ListarTopUsers.Click += new System.EventHandler(this.ListarTopUsers_Click);
            // 
            // IDJuegadorInsertScore
            // 
            this.IDJuegadorInsertScore.Location = new System.Drawing.Point(338, 192);
            this.IDJuegadorInsertScore.Name = "IDJuegadorInsertScore";
            this.IDJuegadorInsertScore.Size = new System.Drawing.Size(100, 20);
            this.IDJuegadorInsertScore.TabIndex = 32;
            // 
            // IDJuegoInsertScore
            // 
            this.IDJuegoInsertScore.Location = new System.Drawing.Point(338, 218);
            this.IDJuegoInsertScore.Name = "IDJuegoInsertScore";
            this.IDJuegoInsertScore.Size = new System.Drawing.Size(100, 20);
            this.IDJuegoInsertScore.TabIndex = 33;
            // 
            // ScoreJugador
            // 
            this.ScoreJugador.Location = new System.Drawing.Point(338, 244);
            this.ScoreJugador.Name = "ScoreJugador";
            this.ScoreJugador.Size = new System.Drawing.Size(100, 20);
            this.ScoreJugador.TabIndex = 34;
            // 
            // CargarScore
            // 
            this.CargarScore.Location = new System.Drawing.Point(444, 192);
            this.CargarScore.Name = "CargarScore";
            this.CargarScore.Size = new System.Drawing.Size(124, 23);
            this.CargarScore.TabIndex = 35;
            this.CargarScore.Text = "Cargar Puntuacion";
            this.CargarScore.UseVisualStyleBackColor = true;
            this.CargarScore.Click += new System.EventHandler(this.CargarScore_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID jugador";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID Videojuego";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Punntiacion Jugador";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 453);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CargarScore);
            this.Controls.Add(this.ScoreJugador);
            this.Controls.Add(this.IDJuegoInsertScore);
            this.Controls.Add(this.IDJuegadorInsertScore);
            this.Controls.Add(this.ListarTopUsers);
            this.Controls.Add(this.ListarVideojuegos);
            this.Controls.Add(this.listBoxTopUsers);
            this.Controls.Add(this.listBoxVideojuego);
            this.Controls.Add(this.DeleteJuego);
            this.Controls.Add(this.ModJuego);
            this.Controls.Add(this.TxBIDVideojueego);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxBGeneroVideojueego);
            this.Controls.Add(this.TxBEstudioVideojueego);
            this.Controls.Add(this.CargarVideojuego);
            this.Controls.Add(this.TxBNombreVideojueego);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListarUsuarios);
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.ModUser);
            this.Controls.Add(this.TxBIDUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBUsuario);
            this.Controls.Add(this.TxBFechaNacimiento);
            this.Controls.Add(this.TxBApellido);
            this.Controls.Add(this.CargarUsuario);
            this.Controls.Add(this.TxbNomJug);
            this.Controls.Add(this.NombreJugador);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label NombreJugador;
        private System.Windows.Forms.TextBox TxbNomJug;
        private System.Windows.Forms.Button CargarUsuario;
        private System.Windows.Forms.TextBox TxBApellido;
        private System.Windows.Forms.TextBox TxBFechaNacimiento;
        private System.Windows.Forms.TextBox TxBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxBIDUsuario;
        private System.Windows.Forms.Button ModUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button ListarUsuarios;
        private System.Windows.Forms.Button DeleteJuego;
        private System.Windows.Forms.Button ModJuego;
        private System.Windows.Forms.TextBox TxBIDVideojueego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxBGeneroVideojueego;
        private System.Windows.Forms.TextBox TxBEstudioVideojueego;
        private System.Windows.Forms.Button CargarVideojuego;
        private System.Windows.Forms.TextBox TxBNombreVideojueego;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxVideojuego;
        private System.Windows.Forms.ListBox listBoxTopUsers;
        private System.Windows.Forms.Button ListarVideojuegos;
        private System.Windows.Forms.Button ListarTopUsers;
        private System.Windows.Forms.TextBox IDJuegadorInsertScore;
        private System.Windows.Forms.TextBox IDJuegoInsertScore;
        private System.Windows.Forms.TextBox ScoreJugador;
        private System.Windows.Forms.Button CargarScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

