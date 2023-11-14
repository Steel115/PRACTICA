using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRACTICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-RT7VNP0;uid=sa;password=12345;database=FARMACIA");
            conexion.Open();
            string nombre = tNombre.Text;
            string formula = tFormula.Text;
            string laboratorio = tLaboratorio.Text;
            string patente = tPatente.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string consulta = "INSERT INTO MEDICAMENTO (nombre,formula,laboratorio,patente,precio,cantidad)VALUES('" + nombre + "','" + formula + "','" + laboratorio + "','" + patente + "','"+ precio +"','"+ cantidad +"')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registraron los datos correctamente");

            tNombre.Text = "";
            tFormula.Text = "";
            tLaboratorio.Text = "";
            tPatente.Text = "";
            tPrecio.Text = "";
            tCantidad.Text = "";
            conexion.Close();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            tMostrar.Text = "";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-RT7VNP0;uid=sa;password=12345;database=FARMACIA");
            conexion.Open();
            string nombre = tNombre.Text;
            string formmula = tFormula.Text;
            string laboratorio = tLaboratorio.Text;
            string patente = tPatente.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string consulta = "SELECT * FROM MEDICAMENTO";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader valores = comando.ExecuteReader();
            while (valores.Read()) {
                tMostrar.AppendText(valores["nombre"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["formula"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["laboratorio"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["patente"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["precio"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["cantidad"].ToString());
                tMostrar.AppendText(Environment.NewLine);
            }
 
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-RT7VNP0;uid=sa;password=12345;database=FARMACIA");
            conexion.Open();
            string ID_PRODUCTO = tBuscar.Text;
            
            string consulta = "SELECT * FROM MEDICAMENTO WHERE ID_PRODUCTO="+ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader valores = comando.ExecuteReader();
            if (valores.Read())
            {
                tNombre.Text=valores["nombre"].ToString();
                tFormula.Text = valores["formula"].ToString();
                tLaboratorio.Text = valores["laboratorio"].ToString();
                tPatente.Text = valores["patente"].ToString();
                tPrecio.Text = valores["precio"].ToString();
                tCantidad.Text = valores["cantidad"].ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra el producto en existencia");
                conexion.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-RT7VNP0;uid=sa;password=12345;database=FARMACIA");
            conexion.Open();
            string nombre = tNombre.Text;
            string formula = tFormula.Text;
            string laboratorio = tLaboratorio.Text;
            string patente = tPatente.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string ID_PRODUCTO = tBuscar.Text;
            string consulta = "UPDATE MEDICAMENTO SET nombre='"+nombre+"',formula='"+formula+"',laboratorio='"+laboratorio+"',patente='"+patente+"',precio='"+precio+"',cantidad='"+cantidad+"' WHERE ID_PRODUCTO="+ ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int valores;
            valores=comando.ExecuteNonQuery();
            if (valores == 1)
            {
                MessageBox.Show("Datos actualizados");
                tNombre.Text = "";
                tFormula.Text = "";
                tLaboratorio.Text = "";
                tPatente.Text = "";
                tPrecio.Text = "";
                tCantidad.Text = "";
                tBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Datos no actualizados");
                conexion.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-RT7VNP0;uid=sa;password=12345;database=FARMACIA");
            conexion.Open();
            string ID_PRODUCTO = tBuscar.Text;
            string consulta = "DELETE FROM MEDICAMENTO WHERE ID_PRODUCTO="+ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int valores;
            valores = comando.ExecuteNonQuery();
            if (valores == 1)
            {
                MessageBox.Show("Datos eliminados");
                tNombre.Text = "";
                tFormula.Text = "";
                tLaboratorio.Text = "";
                tPatente.Text = "";
                tPrecio.Text = "";
                tCantidad.Text = "";
                tBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Datos no eliminados");
                conexion.Close();
            }
        }
    }
}
