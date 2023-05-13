using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Crud_Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            dataGridView1.DataSource = MostrarDatos();

        }

        public DataTable MostrarDatos() 
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultasql = "SELECT * FROM ALUMNO";
            SqlCommand cmd = new SqlCommand(consultasql, Conexion.Conectar());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            return dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO ALUMNO (CODIGO,NOMBRES,TELEFONO,DIRECCION) VALUES (@CODIGO,@NOMBRES,@TELEFONO,@DIRECCION) ";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", textBox1.Text);
            cmd1.Parameters.AddWithValue("@NOMBRES", textBox2.Text);
            cmd1.Parameters.AddWithValue("@TELEFONO", textBox3.Text);
            cmd1.Parameters.AddWithValue("@DIRECCION", textBox4.Text);

            cmd1.ExecuteNonQuery();
            dataGridView1.DataSource = MostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string Actualizar = "UPDATE ALUMNO SET CODIGO=@CODIGO, NOMBRES=@NOMBRES, TELEFONO=@TELEFONO, DIRECCION=@DIRECCION WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(Actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@CODIGO", textBox1.Text);
            cmd2.Parameters.AddWithValue("@NOMBRES", textBox2.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", textBox3.Text);
            cmd2.Parameters.AddWithValue("@DIRECCION", textBox4.Text);

            cmd2.ExecuteNonQuery();
            dataGridView1.DataSource = MostrarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string Eliminar = "DELETE FROM ALUMNO WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(Eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@CODIGO", textBox1.Text);
            cmd3.ExecuteNonQuery();
            dataGridView1.DataSource = MostrarDatos();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

    }
}
