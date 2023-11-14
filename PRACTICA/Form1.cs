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
            SqlConnection conexion = new SqlConnection("server=DESKTOP-43NST12;uid=sa;password=Diamante24;database=SABRITAS");
            conexion.Open();
            string nombre = tNombre.Text;
            string sabor = tSabor.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string consulta = "INSERT INTO producto (nombre,sabor,precio,cantidad)VALUES('" + nombre + "','" + sabor + "','" + precio + "','" + cantidad + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registraron los datos correctamente");

            tNombre.Text = "";
            tSabor.Text = "";
            tPrecio.Text = "";
            tCantidad.Text = "";
            conexion.Close();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            tMostrar.Text = "";

            SqlConnection conexion = new SqlConnection("server= DESKTOP-JJDTS2L\\SQLDISTRIBUIDAS;uid=sa;password=12345;database=SABRITAS");
            conexion.Open();
            string nombre = tNombre.Text;
            string sabor = tSabor.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string consulta = "SELECT * FROM PRODUCTO";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader valores = comando.ExecuteReader();
            while (valores.Read()) {
                tMostrar.AppendText(valores["nombre"].ToString());
                tMostrar.AppendText("/");
                tMostrar.AppendText(valores["Sabor"].ToString());
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
            SqlConnection conexion = new SqlConnection("server= DESKTOP-JJDTS2L\\SQLDISTRIBUIDAS;uid=sa;password=12345;database=SABRITAS");
            conexion.Open();
            string ID_PRODUCTO = tBuscar.Text;
            
            string consulta = "SELECT * FROM producto WHERE ID_PRODUCTO="+ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader valores = comando.ExecuteReader();
            if (valores.Read())
            {
                tNombre.Text=valores["nombre"].ToString();
                tSabor.Text = valores["sabor"].ToString();
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
            SqlConnection conexion = new SqlConnection("server= DESKTOP-JJDTS2L\\SQLDISTRIBUIDAS;uid=sa;password=12345;database=SABRITAS");
            conexion.Open();
            string nombre = tNombre.Text;
            string sabor = tSabor.Text;
            string precio = tPrecio.Text;
            string cantidad = tCantidad.Text;
            string ID_PRODUCTO = tBuscar.Text;
            string consulta = "UPDATE PRODUCTO SET nombre='"+nombre+"',sabor='"+sabor+"',precio='"+precio+"',cantidad='"+cantidad+"' WHERE ID_PRODUCTO="+ ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int valores;
            valores=comando.ExecuteNonQuery();
            if (valores == 1)
            {
                MessageBox.Show("Datos actualizados");
                tNombre.Text = "";
                tSabor.Text = "";
                tPrecio.Text = "";
                tCantidad.Text = "";
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
            SqlConnection conexion = new SqlConnection("server= DESKTOP-JJDTS2L\\SQLDISTRIBUIDAS;uid=sa;password=12345;database=SABRITAS");
            conexion.Open();
            string ID_PRODUCTO = tBuscar.Text;
            string consulta = "DELETE FROM producto WHERE ID_PRODUCTO="+ID_PRODUCTO;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int valores;
            valores = comando.ExecuteNonQuery();
            if (valores == 1)
            {
                MessageBox.Show("Datos eliminados");
                tNombre.Text = "";
                tSabor.Text = "";
                tPrecio.Text = "";
                tCantidad.Text = "";
            }
            else
            {
                MessageBox.Show("Datos no eliminados");
                conexion.Close();
            }
        }
    }
}
