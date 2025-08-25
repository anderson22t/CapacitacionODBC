using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionODBC
{
    public partial class principal : Form
    {
        Conexion cn = new Conexion();
        public principal()
        {
            InitializeComponent();
        }

        void agregarEmpleado()
        {
            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + txtNombre.Text + "', '" + txtPuesto.Text + "', '" + txtDepartamento.Text + "')";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarEmpleado();
            txtDepartamento.Clear();
            txtNombre.Clear();
            txtPuesto.Clear();
        }
    }
}
