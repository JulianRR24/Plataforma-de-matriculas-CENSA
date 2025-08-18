using System;
using System.Data;

public sealed class DatosMatriculasManager
{
    private static readonly DatosMatriculasManager instance = new DatosMatriculasManager();
    public DataTable DatosMatriculas { get; private set; }

    // El constructor privado asegura que no se pueda instanciar externamente
    private DatosMatriculasManager()
    {
        // Creamos la tabla de datos y definimos las columnas
        DatosMatriculas = new DataTable("Estudiantes");
        DatosMatriculas.Columns.Add("Cedula", typeof(string));
        DatosMatriculas.Columns.Add("Nombre", typeof(string));
        DatosMatriculas.Columns.Add("Apellido", typeof(string));
        DatosMatriculas.Columns.Add("Direccion", typeof(string));
        DatosMatriculas.Columns.Add("Telefono", typeof(string));
        DatosMatriculas.Columns.Add("Email", typeof(string));
        DatosMatriculas.Columns.Add("Sede", typeof(string));
        DatosMatriculas.Columns.Add("Programa", typeof(string));
        DatosMatriculas.Columns.Add("Horario", typeof(string));
        DatosMatriculas.Columns.Add("Matricula", typeof(string));
        DatosMatriculas.Columns.Add("Observaciones", typeof(string));
    }

    // Propiedad estática para acceder a la única instancia
    public static DatosMatriculasManager Instance
    {
        get
        {
            return instance;
        }
    }
}