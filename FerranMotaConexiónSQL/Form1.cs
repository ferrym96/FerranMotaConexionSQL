using FerranMotaConexiónSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerranMotaConexionSQL
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data source=200.234.224.123,54321;" +
                                      "Initial Catalog=FerranMotaEmployees;" +
                                      "User ID=sa;" +
                                      "Password=Sql#123456789;";

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                CargarComboBoxPuestos();
                CargarComboBoxManagers();

                buttonConectar.Enabled = false;
                buttonDesconectar.Enabled = true;

                labelEstadoConexion.Text = "Conexión abierta";
                labelEstadoConexion.BackColor = Color.Green;
                labelEstadoConexion.ForeColor = Color.White;

                MessageBox.Show("Conexión establecida correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();

                    buttonConectar.Enabled = true;
                    buttonDesconectar.Enabled = false;

                    labelEstadoConexion.Text = "Conexión cerrada";
                    labelEstadoConexion.BackColor = Color.Red;
                    labelEstadoConexion.ForeColor = Color.White;

                    MessageBox.Show("Conexión cerrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No hay ninguna conexión abierta para cerrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar de la base de datos: " + ex.Message);
            }
        }

        private void buttonCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                InsertarEmpleado();
            }
            else
            {
                MessageBox.Show("Debe abrir la conexión antes de añadir un empleado.");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtSueldo.Text) ||
                comboPuesto.SelectedIndex == -1 ||
                comboManager.SelectedIndex == -1 ||
                comboDept.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtSueldo.Clear();
            dateTimeIncor.Value = DateTime.Now;
            comboPuesto.SelectedIndex = -1;
            comboManager.SelectedIndex = -1;
            comboDept.SelectedIndex = -1;
        }

        private void CargarComboBoxPuestos()
        {
            comboPuesto.Items.Clear();
            string queryPuestos = "SELECT job_id, job_title FROM Jobs";
            using (SqlCommand cmdPuestos = new SqlCommand(queryPuestos, connection))
            {
                using (SqlDataReader readerPuestos = cmdPuestos.ExecuteReader())
                {
                    while (readerPuestos.Read())
                    {
                        comboPuesto.Items.Add(new KeyValuePair<int, string>(readerPuestos.GetInt32(0), readerPuestos.GetString(1)));
                    }
                }
            }
        }

        private void CargarComboBoxManagers()
        {
            comboManager.Items.Clear();
            string queryManagers = "SELECT employee_id, first_name + ' ' + last_name AS manager_name FROM Employees";
            using (SqlCommand cmdManagers = new SqlCommand(queryManagers, connection))
            {
                using (SqlDataReader readerManagers = cmdManagers.ExecuteReader())
                {
                    while (readerManagers.Read())
                    {
                        comboManager.Items.Add(new KeyValuePair<int, string>(readerManagers.GetInt32(0), readerManagers.GetString(1)));
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void InsertarEmpleado()
        {
            try
            {
                if (ValidarCampos())
                {
                    Employee nuevoEmpleado = new Employee
                    {
                        First_name = txtNombre.Text,
                        Last_name = txtApellidos.Text,
                        Email = txtEmail.Text,
                        Phone_number = txtTelefono.Text,
                        Hire_date = dateTimeIncor.Value.Date,
                        Job_id = ((KeyValuePair<int, string>)comboPuesto.SelectedItem).Key,
                        Salary = Convert.ToDecimal(txtSueldo.Text),
                        Manager_id = ((KeyValuePair<int, string>)comboManager.SelectedItem).Key,
                        Department_id = comboDept.SelectedIndex + 1
                    };

                    string sql = "INSERT INTO Employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) " +
                                 "VALUES (@first_name, @last_name, @email, @phone_number, @hire_date, @job_id, @salary, @manager_id, @department_id)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = nuevoEmpleado.First_name;
                        command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = nuevoEmpleado.Last_name;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = nuevoEmpleado.Email;
                        command.Parameters.Add("@phone_number", SqlDbType.NVarChar).Value = nuevoEmpleado.Phone_number;
                        command.Parameters.Add("@hire_date", SqlDbType.Date).Value = nuevoEmpleado.Hire_date;
                        command.Parameters.Add("@job_id", SqlDbType.Int).Value = nuevoEmpleado.Job_id;
                        command.Parameters.Add("@salary", SqlDbType.Decimal).Value = nuevoEmpleado.Salary;
                        command.Parameters.Add("@manager_id", SqlDbType.Int).Value = nuevoEmpleado.Manager_id;
                        command.Parameters.Add("@department_id", SqlDbType.Int).Value = nuevoEmpleado.Department_id;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado añadido correctamente.");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo añadir el empleado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir empleado: " + ex.Message);
            }
        }

    }
}
