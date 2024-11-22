using AppEscuela_3.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscuela_3
{
    public partial class Form1 : Form
    {
        
        public int indexListaAlumnos = 0; //Variable global para
        //el index del Alumno seleccionado del GroupBox_Alumnos
        public int indexListaMaestros = 0;

        List<Alumno> listaAlumno = new List<Alumno>(); //Lista de alumnos
        //donde se almacenan cada que se presiona el boton

        List<Maestro> listaMaestro = new List<Maestro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            B1.Enabled = false;
            //Activacion de Elementos
                GB1.Visible = true;
                //TextBox y NumericUpDown
                TB_Nombre.Visible = true;
                NUD_Edad.Visible = true;
                TB_Clave.Visible = true;
                
                //Labels de Nombre, Edad y Clave
                L_Nombre.Visible = true;
                L_Edad.Visible = true;
                L_Clave.Visible = true;
                
        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        //RadioButton Alumno inicial
        private void RB_Alumno_CheckedChanged(object sender, EventArgs e)
        {
            B_CrearPersona.Text = "Crear alumno";
            B_CrearPersona.Visible = true;
            NUD_Materias.Visible = true;
            L_NumMaterias.Visible = true;
            L_GB_Personas.Visible = true;
            L_GB_Personas.Text = "Alumnos";
            CB_Alumnos.Visible = true;
            CB_Maestros.Visible = false;

            L_ContadorMaestros.Visible = false;
            L_ContadorAlumnos.Visible = true;

            B_ExportarAlumnos.Visible = true;

            GB_Alumno.Visible = true;
            GB_Maestro.Visible = false;

        }

        //Radio Button Maestro Inicial
        private void RB_Maestro_CheckedChanged(object sender, EventArgs e)
        {
            B_CrearPersona.Text = "Crear maestro";
            B_CrearPersona.Visible = true;
            L_GB_Personas.Visible = true;
            L_GB_Personas.Text = "Maestros";
            CB_Alumnos.Visible = false;
            CB_Maestros.Visible = true;

            L_NumMaterias.Visible = false;

            L_ContadorAlumnos.Visible = false;
            L_ContadorMaestros.Visible = true;

            B_ExportarAlumnos.Visible = true;

            GB_Alumno.Visible = false;
            GB_Maestro.Visible = true;
        }

        private void GB_Alumno_Enter(object sender, EventArgs e)
        {

        }

        private void B_CrearMateria_Click(object sender, EventArgs e)
        {
            if(listaAlumno.Count == 0)
            {
                L_CrearMat.Text = "Debes crear al menos un alumno!";
                L_CrearMat.ForeColor = Color.Red;  
                L_CrearMat.Visible = true;
            } else
            {
                GB_CrearAlumno.Visible = true;
            }
            
        }

        private void TB_NombreMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_ConfirmarCrearMat_Click(object sender, EventArgs e)
        {
            if(TB_NombreMateria.Text.Length == 0)
            {
                L_CreacionDeMateriaExitosa.ForeColor = Color.Red;
                L_CreacionDeMateriaExitosa.Text = "Faltan datos!";
                L_CreacionDeMateriaExitosa.Visible = true;
            } else
            {
                if (TB_ClaveMateria.Text.Length == 0)
                {
                    L_CreacionDeMateriaExitosa.ForeColor = Color.Red;
                    L_CreacionDeMateriaExitosa.Text = "Faltan datos!";
                    L_CreacionDeMateriaExitosa.Visible = true;
                } else
                {
                    if (TB_Calificacion.Text.Length == 0)
                    {
                        L_CreacionDeMateriaExitosa.ForeColor = Color.Red;
                        L_CreacionDeMateriaExitosa.Text = "Faltan datos!";
                        L_CreacionDeMateriaExitosa.Visible = true;
                    } else
                    {
                        Materia nuevaMateria = new Materia(TB_NombreMateria.Text, (int)NUD_Creditos.Value,
                            float.Parse(TB_Calificacion.Text), TB_ClaveMateria.Text);
                      
                        //listaAlumno[indexListaAlumnos].CrearMateria(TB_Nombre.Text, (int)NUD_Creditos.Value,
                        //  float.Parse(TB_Calificacion.Text), TB_ClaveMateria.Text);
                        List<Materia> listaDeMaterias = listaAlumno[indexListaAlumnos].ListaMaterias;
                        listaDeMaterias.Add(nuevaMateria);
                        

                        
                        Materia ultimaMateria = listaDeMaterias[listaDeMaterias.Count - 1];
                        CB_Materias.Items.Add(ultimaMateria.NombreMateria);
                        listaAlumno[indexListaAlumnos].ListaMaterias = listaDeMaterias;
                    }
                }
            }
        }

        private void NUD_Creditos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B_CrearPersona_Click(object sender, EventArgs e)
        {
            if(TB_Nombre.Text.Length == 0)
            {
                L_ConfirmacionPersona.Text = "Faltan datos!";
                L_ConfirmacionPersona.ForeColor = Color.Red;
                L_ConfirmacionPersona.Visible = true;
            } else
            {
                if((int)NUD_Edad.Value < 15)
                {
                    L_ConfirmacionPersona.Text = "Edad minima es 15!";
                    L_ConfirmacionPersona.ForeColor = Color.Red;
                    L_ConfirmacionPersona.Visible = true;
                } else
                {
                    if(TB_Clave.Text.Length == 0)
                    {
                        L_ConfirmacionPersona.Text = "Faltan datos!";
                        L_ConfirmacionPersona.ForeColor = Color.Red;
                        L_ConfirmacionPersona.Visible = true;
                    } else
                    {
                        if((int)NUD_Materias.Value > 8)
                        {
                            L_ConfirmacionPersona.Text = "No puede llevar mas de 8 materias!";
                            L_ConfirmacionPersona.ForeColor = Color.Red;
                            L_ConfirmacionPersona.Visible = true;
                        } else
                        {
                            if (RB_Alumno.Checked == true)
                            {
                                Alumno nuevoAlumno = new Alumno(TB_Nombre.Text, TB_Clave.Text, (int)NUD_Edad.Value,
                           (int)NUD_Materias.Value);
                                listaAlumno.Add(nuevoAlumno);
                                L_ContadorAlumnos.Text = listaAlumno.Count.ToString();

                                CB_Alumnos.Items.Add(nuevoAlumno.Nombre);

                                GB_Alumno.Visible = true;
                            } else
                            {
                                if (RB_Maestro.Checked == true)
                                {
                                    Maestro nuevoMaestro = new Maestro(TB_Nombre.Text, TB_Clave.Text, (int)NUD_Edad.Value);
                                    listaMaestro.Add(nuevoMaestro);
                                    L_ContadorMaestros.Text = listaMaestro.Count.ToString();

                                    CB_Maestros.Items.Add(nuevoMaestro.Nombre);
                                }
                            }
                           
                        }
                        
                    }
                }
            }
        }

        private void CB_Alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexListaAlumnos = CB_Alumnos.SelectedIndex;
            CB_Materias.Items.Clear();
            foreach (Materia materia in listaAlumno[indexListaAlumnos].ListaMaterias)
            {
                CB_Materias.Items.Add(materia.NombreMateria);
            }
        }

        private void B_ExportarAlumnos_Click(object sender, EventArgs e)
        {
            if(RB_Alumno.Checked == true )
            {
                if (listaAlumno.Count == 0)
                {
                    L_Exportar.ForeColor = Color.Red;
                    L_Exportar.Text = "Debes crear al menos un Alumno!";
                    L_Exportar.Visible = true;
                }
                else
                {
                    string rutaBaseDatos = "C:/Users/oscar/BaseDatosAlumnos.txt";
                    using (StreamWriter BaseDatos = new StreamWriter(rutaBaseDatos))
                    {
                        foreach (Alumno nuevoAlumno in listaAlumno)
                        {
                            BaseDatos.WriteLine($"Nombre: {nuevoAlumno.Nombre} Clave: {nuevoAlumno.Clave}" +
                                $" Edad: {nuevoAlumno.Edad}");
                            List<Materia> listaDeMaterias = nuevoAlumno.ListaMaterias;
                            BaseDatos.WriteLine($"Promedio: {nuevoAlumno.Promedio}");

                            BaseDatos.WriteLine($"");
                            BaseDatos.WriteLine($"Materias de {nuevoAlumno.Nombre}");

                            foreach(Materia materia in listaDeMaterias)
                            {
                                
                                BaseDatos.WriteLine($"Materia: {materia.NombreMateria}");
                                BaseDatos.WriteLine($"Calificacion: {materia.Calificacion}");
                                BaseDatos.WriteLine($"");
                            }

                            BaseDatos.WriteLine($"");
                            
                        }
                    }
                }
            } else
            {
                if(RB_Maestro.Checked == true)
                {
                    if (listaMaestro.Count == 0)
                    {
                        L_Exportar.ForeColor = Color.Red;
                        L_Exportar.Text = "Debes crear al menos un Maestro!";
                        L_Exportar.Visible = true;
                    }
                    else
                    {
                        string rutaBaseDatos = "C:/Users/oscar/BaseDatosMaestros.txt";
                        using (StreamWriter BaseDatos = new StreamWriter(rutaBaseDatos))
                        {
                            foreach (Maestro nuevoMaestro in listaMaestro)
                            {
                                BaseDatos.WriteLine($"Nombre: {nuevoMaestro.Nombre} Clave: {nuevoMaestro.Clave}" +
                                    $" Edad: {nuevoMaestro.Edad} Categoria: {nuevoMaestro.Categoria}");
                            }
                        }
                    }
                }
            }
           
            
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void B_CalcularSalario_Click(object sender, EventArgs e)
        {
            if(listaMaestro.Count == 0)
            {
                L_CalcularSalario.ForeColor = Color.Red;
                L_CalcularSalario.Text = "Debes crear al menos un maestro!";
                L_CalcularSalario.Visible = true;
            } else
            {
                GB_CalcularSalario.Visible = true;
            }
        }

        private void CB_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CB_Categoria.SelectedIndex;
            listaMaestro[indexListaMaestros].Categoria = CB_Categoria.Items[i].ToString();

            if (CB_Categoria.Items[CB_Categoria.SelectedIndex].ToString() == "Hora clase")
            {
                NUD_HorasClase.Visible = true;
                L_HorasClase.Visible = false;
            } else
            {
                if (CB_Categoria.Items[CB_Categoria.SelectedIndex].ToString() == "Medio tiempo")
                {
                    NUD_HorasClase.Visible = false;
                    L_HorasClase.Visible = false;
                }
                if (CB_Categoria.Items[CB_Categoria.SelectedIndex].ToString() == "Tiempo completo")
                {
                    NUD_HorasClase.Visible = false;
                    L_HorasClase.Visible = false;
                }
            }
        }

        private void CB_Maestros_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexListaMaestros = CB_Maestros.SelectedIndex;
        }


        private void B_CalcularPromedio_Click_1(object sender, EventArgs e)
        {
            listaAlumno[indexListaAlumnos].CalcularPromedio();
        }

        private void NUD_HorasClase_ValueChanged(object sender, EventArgs e)
        {
            listaMaestro[indexListaMaestros].HorasClase = (int)NUD_HorasClase.Value;
        }

        private void B_ConfirmarCalcularSalario_Click(object sender, EventArgs e)
        {
            if(TB_SueldoBase.Text == "")
            {
                L_ConfirmarCalcularSalario.Text = "No puede omitir el sueldo base!";
                L_ConfirmarCalcularSalario.ForeColor = Color.Red;
                L_ConfirmarCalcularSalario.Visible = true;
            } else
            {
                if(CB_Categoria)
            }
        }
    }
}
