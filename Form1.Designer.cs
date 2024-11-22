namespace AppEscuela_3
{
    partial class Form1
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
            this.B1 = new System.Windows.Forms.Button();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.RB_Maestro = new System.Windows.Forms.RadioButton();
            this.RB_Alumno = new System.Windows.Forms.RadioButton();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Clave = new System.Windows.Forms.TextBox();
            this.NUD_Edad = new System.Windows.Forms.NumericUpDown();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Edad = new System.Windows.Forms.Label();
            this.L_Clave = new System.Windows.Forms.Label();
            this.GB_Alumno = new System.Windows.Forms.GroupBox();
            this.GB_CrearAlumno = new System.Windows.Forms.GroupBox();
            this.L_CreacionDeMateriaExitosa = new System.Windows.Forms.Label();
            this.B_ConfirmarCrearMat = new System.Windows.Forms.Button();
            this.L_NombreMateria = new System.Windows.Forms.Label();
            this.L_ClaveMateria = new System.Windows.Forms.Label();
            this.L_Calificacion = new System.Windows.Forms.Label();
            this.L_Creditos = new System.Windows.Forms.Label();
            this.TB_NombreMateria = new System.Windows.Forms.TextBox();
            this.TB_ClaveMateria = new System.Windows.Forms.TextBox();
            this.TB_Calificacion = new System.Windows.Forms.TextBox();
            this.NUD_Creditos = new System.Windows.Forms.NumericUpDown();
            this.CB_Materias = new System.Windows.Forms.ComboBox();
            this.B_CalcularPromedio = new System.Windows.Forms.Button();
            this.B_CrearMateria = new System.Windows.Forms.Button();
            this.B_CrearPersona = new System.Windows.Forms.Button();
            this.L_ConfirmacionPersona = new System.Windows.Forms.Label();
            this.L_NumMaterias = new System.Windows.Forms.Label();
            this.NUD_Materias = new System.Windows.Forms.NumericUpDown();
            this.CB_Alumnos = new System.Windows.Forms.ComboBox();
            this.L_GB_Personas = new System.Windows.Forms.Label();
            this.CB_Maestros = new System.Windows.Forms.ComboBox();
            this.L_ContadorAlumnos = new System.Windows.Forms.Label();
            this.B_ExportarAlumnos = new System.Windows.Forms.Button();
            this.L_Exportar = new System.Windows.Forms.Label();
            this.L_ContadorMaestros = new System.Windows.Forms.Label();
            this.GB_Maestro = new System.Windows.Forms.GroupBox();
            this.GB_CalcularSalario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.B_ConfirmarCalcularSalario = new System.Windows.Forms.Button();
            this.L_Salario = new System.Windows.Forms.Label();
            this.TB_SueldoBase = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.B_CalcularSalario = new System.Windows.Forms.Button();
            this.L_CrearMateria = new System.Windows.Forms.Label();
            this.L_CrearMat = new System.Windows.Forms.Label();
            this.L_CalcularSalario = new System.Windows.Forms.Label();
            this.NUD_HorasClase = new System.Windows.Forms.NumericUpDown();
            this.L_HorasClase = new System.Windows.Forms.Label();
            this.L_ConfirmarCalcularSalario = new System.Windows.Forms.Label();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Edad)).BeginInit();
            this.GB_Alumno.SuspendLayout();
            this.GB_CrearAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Creditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Materias)).BeginInit();
            this.GB_Maestro.SuspendLayout();
            this.GB_CalcularSalario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HorasClase)).BeginInit();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 12);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(206, 70);
            this.B1.TabIndex = 0;
            this.B1.Text = "Haga click para crear una persona";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.RB_Maestro);
            this.GB1.Controls.Add(this.RB_Alumno);
            this.GB1.Location = new System.Drawing.Point(12, 88);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(264, 100);
            this.GB1.TabIndex = 1;
            this.GB1.TabStop = false;
            this.GB1.Text = "Seleccione el tipo de persona";
            this.GB1.Visible = false;
            this.GB1.Enter += new System.EventHandler(this.GB1_Enter);
            // 
            // RB_Maestro
            // 
            this.RB_Maestro.AutoSize = true;
            this.RB_Maestro.Location = new System.Drawing.Point(18, 55);
            this.RB_Maestro.Name = "RB_Maestro";
            this.RB_Maestro.Size = new System.Drawing.Size(92, 24);
            this.RB_Maestro.TabIndex = 1;
            this.RB_Maestro.TabStop = true;
            this.RB_Maestro.Text = "Maestro";
            this.RB_Maestro.UseVisualStyleBackColor = true;
            this.RB_Maestro.CheckedChanged += new System.EventHandler(this.RB_Maestro_CheckedChanged);
            // 
            // RB_Alumno
            // 
            this.RB_Alumno.AutoSize = true;
            this.RB_Alumno.Location = new System.Drawing.Point(18, 25);
            this.RB_Alumno.Name = "RB_Alumno";
            this.RB_Alumno.Size = new System.Drawing.Size(88, 24);
            this.RB_Alumno.TabIndex = 0;
            this.RB_Alumno.TabStop = true;
            this.RB_Alumno.Text = "Alumno";
            this.RB_Alumno.UseVisualStyleBackColor = true;
            this.RB_Alumno.CheckedChanged += new System.EventHandler(this.RB_Alumno_CheckedChanged);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(126, 194);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(150, 26);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.Visible = false;
            // 
            // TB_Clave
            // 
            this.TB_Clave.Location = new System.Drawing.Point(126, 258);
            this.TB_Clave.Name = "TB_Clave";
            this.TB_Clave.Size = new System.Drawing.Size(150, 26);
            this.TB_Clave.TabIndex = 4;
            this.TB_Clave.Visible = false;
            // 
            // NUD_Edad
            // 
            this.NUD_Edad.Location = new System.Drawing.Point(203, 226);
            this.NUD_Edad.Name = "NUD_Edad";
            this.NUD_Edad.Size = new System.Drawing.Size(73, 26);
            this.NUD_Edad.TabIndex = 5;
            this.NUD_Edad.Visible = false;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(49, 194);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(69, 20);
            this.L_Nombre.TabIndex = 6;
            this.L_Nombre.Text = "Nombre:";
            this.L_Nombre.Visible = false;
            // 
            // L_Edad
            // 
            this.L_Edad.AutoSize = true;
            this.L_Edad.Location = new System.Drawing.Point(49, 228);
            this.L_Edad.Name = "L_Edad";
            this.L_Edad.Size = new System.Drawing.Size(51, 20);
            this.L_Edad.TabIndex = 7;
            this.L_Edad.Text = "Edad:";
            this.L_Edad.Visible = false;
            // 
            // L_Clave
            // 
            this.L_Clave.AutoSize = true;
            this.L_Clave.Location = new System.Drawing.Point(49, 258);
            this.L_Clave.Name = "L_Clave";
            this.L_Clave.Size = new System.Drawing.Size(52, 20);
            this.L_Clave.TabIndex = 8;
            this.L_Clave.Text = "Clave:";
            this.L_Clave.Visible = false;
            // 
            // GB_Alumno
            // 
            this.GB_Alumno.Controls.Add(this.L_CrearMat);
            this.GB_Alumno.Controls.Add(this.L_CrearMateria);
            this.GB_Alumno.Controls.Add(this.GB_CrearAlumno);
            this.GB_Alumno.Controls.Add(this.CB_Materias);
            this.GB_Alumno.Controls.Add(this.B_CalcularPromedio);
            this.GB_Alumno.Controls.Add(this.B_CrearMateria);
            this.GB_Alumno.Location = new System.Drawing.Point(282, 12);
            this.GB_Alumno.Name = "GB_Alumno";
            this.GB_Alumno.Size = new System.Drawing.Size(506, 426);
            this.GB_Alumno.TabIndex = 9;
            this.GB_Alumno.TabStop = false;
            this.GB_Alumno.Text = "Alumno";
            this.GB_Alumno.Visible = false;
            this.GB_Alumno.Enter += new System.EventHandler(this.GB_Alumno_Enter);
            // 
            // GB_CrearAlumno
            // 
            this.GB_CrearAlumno.Controls.Add(this.L_CreacionDeMateriaExitosa);
            this.GB_CrearAlumno.Controls.Add(this.B_ConfirmarCrearMat);
            this.GB_CrearAlumno.Controls.Add(this.L_NombreMateria);
            this.GB_CrearAlumno.Controls.Add(this.L_ClaveMateria);
            this.GB_CrearAlumno.Controls.Add(this.L_Calificacion);
            this.GB_CrearAlumno.Controls.Add(this.L_Creditos);
            this.GB_CrearAlumno.Controls.Add(this.TB_NombreMateria);
            this.GB_CrearAlumno.Controls.Add(this.TB_ClaveMateria);
            this.GB_CrearAlumno.Controls.Add(this.TB_Calificacion);
            this.GB_CrearAlumno.Controls.Add(this.NUD_Creditos);
            this.GB_CrearAlumno.Location = new System.Drawing.Point(179, 101);
            this.GB_CrearAlumno.Name = "GB_CrearAlumno";
            this.GB_CrearAlumno.Size = new System.Drawing.Size(293, 238);
            this.GB_CrearAlumno.TabIndex = 12;
            this.GB_CrearAlumno.TabStop = false;
            this.GB_CrearAlumno.Text = "Crear alumno";
            this.GB_CrearAlumno.Visible = false;
            // 
            // L_CreacionDeMateriaExitosa
            // 
            this.L_CreacionDeMateriaExitosa.AutoSize = true;
            this.L_CreacionDeMateriaExitosa.Location = new System.Drawing.Point(120, 164);
            this.L_CreacionDeMateriaExitosa.Name = "L_CreacionDeMateriaExitosa";
            this.L_CreacionDeMateriaExitosa.Size = new System.Drawing.Size(0, 20);
            this.L_CreacionDeMateriaExitosa.TabIndex = 12;
            this.L_CreacionDeMateriaExitosa.Visible = false;
            // 
            // B_ConfirmarCrearMat
            // 
            this.B_ConfirmarCrearMat.Location = new System.Drawing.Point(100, 187);
            this.B_ConfirmarCrearMat.Name = "B_ConfirmarCrearMat";
            this.B_ConfirmarCrearMat.Size = new System.Drawing.Size(100, 35);
            this.B_ConfirmarCrearMat.TabIndex = 11;
            this.B_ConfirmarCrearMat.Text = "Crear";
            this.B_ConfirmarCrearMat.UseVisualStyleBackColor = true;
            this.B_ConfirmarCrearMat.Click += new System.EventHandler(this.B_ConfirmarCrearMat_Click);
            // 
            // L_NombreMateria
            // 
            this.L_NombreMateria.AutoSize = true;
            this.L_NombreMateria.Location = new System.Drawing.Point(31, 25);
            this.L_NombreMateria.Name = "L_NombreMateria";
            this.L_NombreMateria.Size = new System.Drawing.Size(69, 20);
            this.L_NombreMateria.TabIndex = 7;
            this.L_NombreMateria.Text = "Nombre:";
            // 
            // L_ClaveMateria
            // 
            this.L_ClaveMateria.AutoSize = true;
            this.L_ClaveMateria.Location = new System.Drawing.Point(31, 58);
            this.L_ClaveMateria.Name = "L_ClaveMateria";
            this.L_ClaveMateria.Size = new System.Drawing.Size(52, 20);
            this.L_ClaveMateria.TabIndex = 8;
            this.L_ClaveMateria.Text = "Clave:";
            // 
            // L_Calificacion
            // 
            this.L_Calificacion.AutoSize = true;
            this.L_Calificacion.Location = new System.Drawing.Point(31, 90);
            this.L_Calificacion.Name = "L_Calificacion";
            this.L_Calificacion.Size = new System.Drawing.Size(93, 20);
            this.L_Calificacion.TabIndex = 9;
            this.L_Calificacion.Text = "Calificacion:";
            // 
            // L_Creditos
            // 
            this.L_Creditos.AutoSize = true;
            this.L_Creditos.Location = new System.Drawing.Point(31, 123);
            this.L_Creditos.Name = "L_Creditos";
            this.L_Creditos.Size = new System.Drawing.Size(72, 20);
            this.L_Creditos.TabIndex = 10;
            this.L_Creditos.Text = "Creditos:";
            // 
            // TB_NombreMateria
            // 
            this.TB_NombreMateria.Location = new System.Drawing.Point(134, 25);
            this.TB_NombreMateria.Name = "TB_NombreMateria";
            this.TB_NombreMateria.Size = new System.Drawing.Size(113, 26);
            this.TB_NombreMateria.TabIndex = 3;
            this.TB_NombreMateria.TextChanged += new System.EventHandler(this.TB_NombreMateria_TextChanged);
            // 
            // TB_ClaveMateria
            // 
            this.TB_ClaveMateria.Location = new System.Drawing.Point(134, 58);
            this.TB_ClaveMateria.Name = "TB_ClaveMateria";
            this.TB_ClaveMateria.Size = new System.Drawing.Size(113, 26);
            this.TB_ClaveMateria.TabIndex = 4;
            // 
            // TB_Calificacion
            // 
            this.TB_Calificacion.Location = new System.Drawing.Point(134, 90);
            this.TB_Calificacion.Name = "TB_Calificacion";
            this.TB_Calificacion.Size = new System.Drawing.Size(113, 26);
            this.TB_Calificacion.TabIndex = 5;
            // 
            // NUD_Creditos
            // 
            this.NUD_Creditos.Location = new System.Drawing.Point(147, 123);
            this.NUD_Creditos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUD_Creditos.Name = "NUD_Creditos";
            this.NUD_Creditos.Size = new System.Drawing.Size(100, 26);
            this.NUD_Creditos.TabIndex = 6;
            this.NUD_Creditos.ValueChanged += new System.EventHandler(this.NUD_Creditos_ValueChanged);
            // 
            // CB_Materias
            // 
            this.CB_Materias.FormattingEnabled = true;
            this.CB_Materias.Location = new System.Drawing.Point(6, 112);
            this.CB_Materias.Name = "CB_Materias";
            this.CB_Materias.Size = new System.Drawing.Size(138, 28);
            this.CB_Materias.TabIndex = 2;
            // 
            // B_CalcularPromedio
            // 
            this.B_CalcularPromedio.Location = new System.Drawing.Point(147, 25);
            this.B_CalcularPromedio.Name = "B_CalcularPromedio";
            this.B_CalcularPromedio.Size = new System.Drawing.Size(156, 45);
            this.B_CalcularPromedio.TabIndex = 1;
            this.B_CalcularPromedio.Text = "Calcular promedio";
            this.B_CalcularPromedio.UseVisualStyleBackColor = true;
            this.B_CalcularPromedio.Click += new System.EventHandler(this.B_CalcularPromedio_Click_1);
            // 
            // B_CrearMateria
            // 
            this.B_CrearMateria.Location = new System.Drawing.Point(6, 25);
            this.B_CrearMateria.Name = "B_CrearMateria";
            this.B_CrearMateria.Size = new System.Drawing.Size(135, 45);
            this.B_CrearMateria.TabIndex = 0;
            this.B_CrearMateria.Text = "Crear materia";
            this.B_CrearMateria.UseVisualStyleBackColor = true;
            this.B_CrearMateria.Click += new System.EventHandler(this.B_CrearMateria_Click);
            // 
            // B_CrearPersona
            // 
            this.B_CrearPersona.Location = new System.Drawing.Point(12, 469);
            this.B_CrearPersona.Name = "B_CrearPersona";
            this.B_CrearPersona.Size = new System.Drawing.Size(133, 43);
            this.B_CrearPersona.TabIndex = 10;
            this.B_CrearPersona.Text = "Crear Alumno";
            this.B_CrearPersona.UseVisualStyleBackColor = true;
            this.B_CrearPersona.Visible = false;
            this.B_CrearPersona.Click += new System.EventHandler(this.B_CrearPersona_Click);
            // 
            // L_ConfirmacionPersona
            // 
            this.L_ConfirmacionPersona.AutoSize = true;
            this.L_ConfirmacionPersona.Location = new System.Drawing.Point(8, 446);
            this.L_ConfirmacionPersona.Name = "L_ConfirmacionPersona";
            this.L_ConfirmacionPersona.Size = new System.Drawing.Size(102, 20);
            this.L_ConfirmacionPersona.TabIndex = 11;
            this.L_ConfirmacionPersona.Text = "Faltan datos!";
            this.L_ConfirmacionPersona.Visible = false;
            // 
            // L_NumMaterias
            // 
            this.L_NumMaterias.AutoSize = true;
            this.L_NumMaterias.Location = new System.Drawing.Point(49, 290);
            this.L_NumMaterias.Name = "L_NumMaterias";
            this.L_NumMaterias.Size = new System.Drawing.Size(74, 20);
            this.L_NumMaterias.TabIndex = 13;
            this.L_NumMaterias.Text = "Materias:";
            this.L_NumMaterias.Visible = false;
            // 
            // NUD_Materias
            // 
            this.NUD_Materias.Location = new System.Drawing.Point(203, 290);
            this.NUD_Materias.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUD_Materias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Materias.Name = "NUD_Materias";
            this.NUD_Materias.Size = new System.Drawing.Size(73, 26);
            this.NUD_Materias.TabIndex = 14;
            this.NUD_Materias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Materias.Visible = false;
            // 
            // CB_Alumnos
            // 
            this.CB_Alumnos.FormattingEnabled = true;
            this.CB_Alumnos.Location = new System.Drawing.Point(12, 363);
            this.CB_Alumnos.Name = "CB_Alumnos";
            this.CB_Alumnos.Size = new System.Drawing.Size(172, 28);
            this.CB_Alumnos.TabIndex = 15;
            this.CB_Alumnos.Visible = false;
            this.CB_Alumnos.SelectedIndexChanged += new System.EventHandler(this.CB_Alumnos_SelectedIndexChanged);
            // 
            // L_GB_Personas
            // 
            this.L_GB_Personas.AutoSize = true;
            this.L_GB_Personas.Location = new System.Drawing.Point(8, 340);
            this.L_GB_Personas.Name = "L_GB_Personas";
            this.L_GB_Personas.Size = new System.Drawing.Size(0, 20);
            this.L_GB_Personas.TabIndex = 16;
            // 
            // CB_Maestros
            // 
            this.CB_Maestros.FormattingEnabled = true;
            this.CB_Maestros.Location = new System.Drawing.Point(12, 363);
            this.CB_Maestros.Name = "CB_Maestros";
            this.CB_Maestros.Size = new System.Drawing.Size(172, 28);
            this.CB_Maestros.TabIndex = 17;
            this.CB_Maestros.Visible = false;
            this.CB_Maestros.SelectedIndexChanged += new System.EventHandler(this.CB_Maestros_SelectedIndexChanged);
            // 
            // L_ContadorAlumnos
            // 
            this.L_ContadorAlumnos.AutoSize = true;
            this.L_ContadorAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_ContadorAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ContadorAlumnos.Location = new System.Drawing.Point(190, 360);
            this.L_ContadorAlumnos.Name = "L_ContadorAlumnos";
            this.L_ContadorAlumnos.Size = new System.Drawing.Size(28, 31);
            this.L_ContadorAlumnos.TabIndex = 18;
            this.L_ContadorAlumnos.Text = "0";
            this.L_ContadorAlumnos.Visible = false;
            // 
            // B_ExportarAlumnos
            // 
            this.B_ExportarAlumnos.Location = new System.Drawing.Point(164, 469);
            this.B_ExportarAlumnos.Name = "B_ExportarAlumnos";
            this.B_ExportarAlumnos.Size = new System.Drawing.Size(205, 43);
            this.B_ExportarAlumnos.TabIndex = 19;
            this.B_ExportarAlumnos.Text = "Exportar a texto";
            this.B_ExportarAlumnos.UseVisualStyleBackColor = true;
            this.B_ExportarAlumnos.Visible = false;
            this.B_ExportarAlumnos.Click += new System.EventHandler(this.B_ExportarAlumnos_Click);
            // 
            // L_Exportar
            // 
            this.L_Exportar.AutoSize = true;
            this.L_Exportar.Location = new System.Drawing.Point(160, 446);
            this.L_Exportar.Name = "L_Exportar";
            this.L_Exportar.Size = new System.Drawing.Size(0, 20);
            this.L_Exportar.TabIndex = 20;
            this.L_Exportar.Visible = false;
            // 
            // L_ContadorMaestros
            // 
            this.L_ContadorMaestros.AutoSize = true;
            this.L_ContadorMaestros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_ContadorMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ContadorMaestros.Location = new System.Drawing.Point(190, 359);
            this.L_ContadorMaestros.Name = "L_ContadorMaestros";
            this.L_ContadorMaestros.Size = new System.Drawing.Size(28, 31);
            this.L_ContadorMaestros.TabIndex = 21;
            this.L_ContadorMaestros.Text = "0";
            this.L_ContadorMaestros.Visible = false;
            // 
            // GB_Maestro
            // 
            this.GB_Maestro.Controls.Add(this.L_CalcularSalario);
            this.GB_Maestro.Controls.Add(this.GB_CalcularSalario);
            this.GB_Maestro.Controls.Add(this.button2);
            this.GB_Maestro.Controls.Add(this.B_CalcularSalario);
            this.GB_Maestro.Location = new System.Drawing.Point(282, 12);
            this.GB_Maestro.Name = "GB_Maestro";
            this.GB_Maestro.Size = new System.Drawing.Size(506, 426);
            this.GB_Maestro.TabIndex = 13;
            this.GB_Maestro.TabStop = false;
            this.GB_Maestro.Text = "Maestro";
            this.GB_Maestro.Visible = false;
            // 
            // GB_CalcularSalario
            // 
            this.GB_CalcularSalario.Controls.Add(this.L_ConfirmarCalcularSalario);
            this.GB_CalcularSalario.Controls.Add(this.L_HorasClase);
            this.GB_CalcularSalario.Controls.Add(this.NUD_HorasClase);
            this.GB_CalcularSalario.Controls.Add(this.label2);
            this.GB_CalcularSalario.Controls.Add(this.label1);
            this.GB_CalcularSalario.Controls.Add(this.CB_Categoria);
            this.GB_CalcularSalario.Controls.Add(this.B_ConfirmarCalcularSalario);
            this.GB_CalcularSalario.Controls.Add(this.L_Salario);
            this.GB_CalcularSalario.Controls.Add(this.TB_SueldoBase);
            this.GB_CalcularSalario.Location = new System.Drawing.Point(179, 101);
            this.GB_CalcularSalario.Name = "GB_CalcularSalario";
            this.GB_CalcularSalario.Size = new System.Drawing.Size(293, 238);
            this.GB_CalcularSalario.TabIndex = 12;
            this.GB_CalcularSalario.TabStop = false;
            this.GB_CalcularSalario.Text = "Calcular salario";
            this.GB_CalcularSalario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Items.AddRange(new object[] {
            "Hora clase",
            "Medio tiempo",
            "Tiempo completo"});
            this.CB_Categoria.Location = new System.Drawing.Point(109, 59);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(138, 28);
            this.CB_Categoria.TabIndex = 2;
            this.CB_Categoria.SelectedIndexChanged += new System.EventHandler(this.CB_Categoria_SelectedIndexChanged);
            // 
            // B_ConfirmarCalcularSalario
            // 
            this.B_ConfirmarCalcularSalario.Location = new System.Drawing.Point(100, 187);
            this.B_ConfirmarCalcularSalario.Name = "B_ConfirmarCalcularSalario";
            this.B_ConfirmarCalcularSalario.Size = new System.Drawing.Size(100, 35);
            this.B_ConfirmarCalcularSalario.TabIndex = 11;
            this.B_ConfirmarCalcularSalario.Text = "Calcular";
            this.B_ConfirmarCalcularSalario.UseVisualStyleBackColor = true;
            this.B_ConfirmarCalcularSalario.Click += new System.EventHandler(this.B_ConfirmarCalcularSalario_Click);
            // 
            // L_Salario
            // 
            this.L_Salario.AutoSize = true;
            this.L_Salario.Location = new System.Drawing.Point(6, 32);
            this.L_Salario.Name = "L_Salario";
            this.L_Salario.Size = new System.Drawing.Size(102, 20);
            this.L_Salario.TabIndex = 7;
            this.L_Salario.Text = "Sueldo base:";
            // 
            // TB_SueldoBase
            // 
            this.TB_SueldoBase.Location = new System.Drawing.Point(134, 25);
            this.TB_SueldoBase.Name = "TB_SueldoBase";
            this.TB_SueldoBase.Size = new System.Drawing.Size(113, 26);
            this.TB_SueldoBase.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // B_CalcularSalario
            // 
            this.B_CalcularSalario.Location = new System.Drawing.Point(6, 25);
            this.B_CalcularSalario.Name = "B_CalcularSalario";
            this.B_CalcularSalario.Size = new System.Drawing.Size(135, 45);
            this.B_CalcularSalario.TabIndex = 0;
            this.B_CalcularSalario.Text = "Calcular salario";
            this.B_CalcularSalario.UseVisualStyleBackColor = true;
            this.B_CalcularSalario.Click += new System.EventHandler(this.B_CalcularSalario_Click);
            // 
            // L_CrearMateria
            // 
            this.L_CrearMateria.AutoSize = true;
            this.L_CrearMateria.Location = new System.Drawing.Point(6, 73);
            this.L_CrearMateria.Name = "L_CrearMateria";
            this.L_CrearMateria.Size = new System.Drawing.Size(0, 20);
            this.L_CrearMateria.TabIndex = 13;
            // 
            // L_CrearMat
            // 
            this.L_CrearMat.AutoSize = true;
            this.L_CrearMat.Location = new System.Drawing.Point(12, 76);
            this.L_CrearMat.Name = "L_CrearMat";
            this.L_CrearMat.Size = new System.Drawing.Size(0, 20);
            this.L_CrearMat.TabIndex = 13;
            // 
            // L_CalcularSalario
            // 
            this.L_CalcularSalario.AutoSize = true;
            this.L_CalcularSalario.Location = new System.Drawing.Point(6, 76);
            this.L_CalcularSalario.Name = "L_CalcularSalario";
            this.L_CalcularSalario.Size = new System.Drawing.Size(0, 20);
            this.L_CalcularSalario.TabIndex = 14;
            // 
            // NUD_HorasClase
            // 
            this.NUD_HorasClase.Location = new System.Drawing.Point(191, 93);
            this.NUD_HorasClase.Name = "NUD_HorasClase";
            this.NUD_HorasClase.Size = new System.Drawing.Size(56, 26);
            this.NUD_HorasClase.TabIndex = 14;
            this.NUD_HorasClase.Visible = false;
            this.NUD_HorasClase.ValueChanged += new System.EventHandler(this.NUD_HorasClase_ValueChanged);
            // 
            // L_HorasClase
            // 
            this.L_HorasClase.AutoSize = true;
            this.L_HorasClase.Location = new System.Drawing.Point(6, 93);
            this.L_HorasClase.Name = "L_HorasClase";
            this.L_HorasClase.Size = new System.Drawing.Size(97, 20);
            this.L_HorasClase.TabIndex = 15;
            this.L_HorasClase.Text = "Horas clase:";
            this.L_HorasClase.Visible = false;
            // 
            // L_ConfirmarCalcularSalario
            // 
            this.L_ConfirmarCalcularSalario.AutoSize = true;
            this.L_ConfirmarCalcularSalario.Location = new System.Drawing.Point(96, 164);
            this.L_ConfirmarCalcularSalario.Name = "L_ConfirmarCalcularSalario";
            this.L_ConfirmarCalcularSalario.Size = new System.Drawing.Size(0, 20);
            this.L_ConfirmarCalcularSalario.TabIndex = 16;
            this.L_ConfirmarCalcularSalario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 524);
            this.Controls.Add(this.L_Exportar);
            this.Controls.Add(this.B_ExportarAlumnos);
            this.Controls.Add(this.L_GB_Personas);
            this.Controls.Add(this.NUD_Materias);
            this.Controls.Add(this.L_NumMaterias);
            this.Controls.Add(this.L_ConfirmacionPersona);
            this.Controls.Add(this.B_CrearPersona);
            this.Controls.Add(this.L_Clave);
            this.Controls.Add(this.L_Edad);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.NUD_Edad);
            this.Controls.Add(this.TB_Clave);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.CB_Maestros);
            this.Controls.Add(this.L_ContadorMaestros);
            this.Controls.Add(this.L_ContadorAlumnos);
            this.Controls.Add(this.CB_Alumnos);
            this.Controls.Add(this.GB_Maestro);
            this.Controls.Add(this.GB_Alumno);
            this.Name = "Form1";
            this.Text = "Haga click para crear persona";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Edad)).EndInit();
            this.GB_Alumno.ResumeLayout(false);
            this.GB_Alumno.PerformLayout();
            this.GB_CrearAlumno.ResumeLayout(false);
            this.GB_CrearAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Creditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Materias)).EndInit();
            this.GB_Maestro.ResumeLayout(false);
            this.GB_Maestro.PerformLayout();
            this.GB_CalcularSalario.ResumeLayout(false);
            this.GB_CalcularSalario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HorasClase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.RadioButton RB_Maestro;
        private System.Windows.Forms.RadioButton RB_Alumno;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Clave;
        private System.Windows.Forms.NumericUpDown NUD_Edad;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Edad;
        private System.Windows.Forms.Label L_Clave;
        private System.Windows.Forms.GroupBox GB_Alumno;
        private System.Windows.Forms.Button B_CalcularPromedio;
        private System.Windows.Forms.Button B_CrearMateria;
        private System.Windows.Forms.ComboBox CB_Materias;
        private System.Windows.Forms.TextBox TB_ClaveMateria;
        private System.Windows.Forms.TextBox TB_NombreMateria;
        private System.Windows.Forms.NumericUpDown NUD_Creditos;
        private System.Windows.Forms.TextBox TB_Calificacion;
        private System.Windows.Forms.Label L_Creditos;
        private System.Windows.Forms.Label L_Calificacion;
        private System.Windows.Forms.Label L_ClaveMateria;
        private System.Windows.Forms.Label L_NombreMateria;
        private System.Windows.Forms.Button B_ConfirmarCrearMat;
        private System.Windows.Forms.GroupBox GB_CrearAlumno;
        private System.Windows.Forms.Label L_CreacionDeMateriaExitosa;
        private System.Windows.Forms.Button B_CrearPersona;
        private System.Windows.Forms.Label L_ConfirmacionPersona;
        private System.Windows.Forms.Label L_NumMaterias;
        private System.Windows.Forms.NumericUpDown NUD_Materias;
        private System.Windows.Forms.ComboBox CB_Alumnos;
        private System.Windows.Forms.Label L_GB_Personas;
        private System.Windows.Forms.ComboBox CB_Maestros;
        private System.Windows.Forms.Label L_ContadorAlumnos;
        private System.Windows.Forms.Button B_ExportarAlumnos;
        private System.Windows.Forms.Label L_Exportar;
        private System.Windows.Forms.Label L_ContadorMaestros;
        private System.Windows.Forms.GroupBox GB_Maestro;
        private System.Windows.Forms.GroupBox GB_CalcularSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ConfirmarCalcularSalario;
        private System.Windows.Forms.Label L_Salario;
        private System.Windows.Forms.TextBox TB_SueldoBase;
        private System.Windows.Forms.ComboBox CB_Categoria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_CalcularSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_CrearMateria;
        private System.Windows.Forms.Label L_CrearMat;
        private System.Windows.Forms.Label L_CalcularSalario;
        private System.Windows.Forms.Label L_HorasClase;
        private System.Windows.Forms.NumericUpDown NUD_HorasClase;
        private System.Windows.Forms.Label L_ConfirmarCalcularSalario;
    }
}

