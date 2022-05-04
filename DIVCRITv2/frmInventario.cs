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

namespace DIVCRITv2
{
    public partial class frmInventario : Form
    {
        //static string cadena = "Server=iturbide;Database=INVENTARIO_CRIT;User Id=super;Password=super;";
        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =INVENTARIO_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";
        public string BuscarColumna; /*!< Especificación de la variable para la columna de la base de datos. */

        //Cadena 2
        public static string cadena2 = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = sa; Password = admin";

        public SqlConnection conexion = new SqlConnection(cadena);
        public string tipoUsuario; /*!< Tipo de usuario registrado(admin, usuario normal, etc.) */

        //Conexion 2
        public SqlConnection conexion2 = new SqlConnection(cadena2);
        public frmInventario()
        {
            InitializeComponent();
        }

        /**
        * Método para despejar los textBox del formulario. 
        */
        public void LimpiarCampos()
        {
            tbxNoSerie.Clear();
            tbxNoOficina.Clear();
            tbxMarca.Clear();
            tbxNombre.Clear();
            cbxArea.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;
            cbxColaborador.SelectedIndex = 0;
        }

        /**
         * Actualiza el DataGridView para mostrar los nuevos datos modificados de la tabla en la base de datos.
         */
        public void actualizarTabla()
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto', " +
                "no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dgvInventario.DataSource = dtRecord;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.AllowUserToResizeColumns = false;

            SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT nombre FROM COLABORADORES ORDER BY nombre ASC", conexion2);
            conexion2.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxColaborador.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion2.Close();

            conexion2.Open();

            SqlCommand sqlCmd2 = new SqlCommand("SELECT DISTINCT area FROM COLABORADORES ORDER BY area ASC", conexion2);
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                cbxArea.Items.Add(sqlReader2["area"].ToString());
            }

            conexion2.Close();

            cbxCampos.SelectedIndex = 0;
            try
            {
                conexion.Open();

                string consulta = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto', " +
                    "no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvInventario.ReadOnly = true;
                dgvInventario.DataSource = ds.Tables[0];

                //dgvInventario.RowHeadersVisible = false;
                dgvInventario.BackgroundColor = Color.White;
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 53)
                {
                    MessageBox.Show("No se pudo conectar con el servidor. Favor de contactar al administrador de sistemas.", "Error de conexión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(sqlEx.Number.ToString());
            }

            VerificarAgregar();
            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO PRODUCTO values ('" + tbxNoOficina.Text.Trim() + "', '" + cbxArea.Text.Trim() + "', '" + cbxColaborador.Text.Trim()
                    + "', '" + cbxTipo.Text.Trim() + "', '" + tbxNoSerie.Text.Trim() + "', '" + tbxNombre.Text.Trim() + "', '"
                    + tbxMarca.Text.Trim() + "')";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvInventario.ReadOnly = true;
                actualizarTabla();
                //dgvInventario.RowHeadersVisible = false;
                dgvInventario.BackgroundColor = Color.White;

                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Una entrada con este número de serie ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            string nombreProducto = dgvInventario.CurrentRow.Cells[6].Value.ToString();

            conexion.Open();
            var resultado = MessageBox.Show("¿Estás seguro que deseas actualizar a " + nombreProducto + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string consulta = "UPDATE PRODUCTO SET no_oficina = '" + tbxNoOficina.Text + "', area = '" + cbxArea.Text + "', colaborador = '"
                    + cbxColaborador.Text + "', tipo_producto = '" + cbxTipo.Text + "', no_serie = '" + tbxNoSerie.Text + "', nombre_producto = '"
                    + tbxNombre.Text + "', marca_producto = '" + tbxMarca.Text + "' where id = " + idProducto;
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                actualizarTabla();
            }

            conexion.Close();

            actualizarTabla();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            string nombreProducto = dgvInventario.CurrentRow.Cells[6].Value.ToString();

            conexion.Open();
            var resultado = MessageBox.Show("¿Estás seguro que deseas borrar a " + nombreProducto + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string consulta = "DELETE PRODUCTO WHERE id = " + idProducto;
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                actualizarTabla();
            }
            conexion.Close();
            LimpiarCampos();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNoOficina.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            cbxArea.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            cbxColaborador.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            cbxTipo.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();
            tbxNoSerie.Text = dgvInventario.CurrentRow.Cells[5].Value.ToString();
            tbxNombre.Text = dgvInventario.CurrentRow.Cells[6].Value.ToString();
            tbxMarca.Text = dgvInventario.CurrentRow.Cells[7].Value.ToString();

            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void tbxCampos_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto'," +
                " no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO WHERE " + BuscarColumna + " LIKE '%" + tbxCampos.Text.Trim() + "%' ORDER BY id";
            var dataAdapter = new SqlDataAdapter(consulta, conexion);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvInventario.ReadOnly = true;
            dgvInventario.DataSource = ds.Tables[0];
            conexion.Close();
        }

        private void cbxCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCampos.Text)
            {
                case "Número Oficina":
                    BuscarColumna = "no_oficina";
                    break;

                case "Área Oficina":
                    BuscarColumna = "area";
                    break;

                case "Colaborador":
                    BuscarColumna = "colaborador";
                    break;

                case "Tipo Producto":
                    BuscarColumna = "tipo_producto";
                    break;

                case "Número Serie":
                    BuscarColumna = "no_serie";
                    break;

                case "Nombre Producto":
                    BuscarColumna = "nombre_producto";
                    break;

                case "Marca Producto":
                    BuscarColumna = "marca_producto";
                    break;

                default:
                    BuscarColumna = "nombre_producto";
                    break;
            }
        }

        /**
        * METODO PARA VERIFICAR QUE TODOS LOS CAMPOS HAYAN SIDO LLENADOS ANTES DE AGREGAR
        */
        public void VerificarAgregar()
        {
            if (tbxNoOficina.Text == "" || cbxArea.Text == "" || cbxColaborador.Text == "" || cbxTipo.Text == "" || tbxNoSerie.Text == ""
             || tbxNombre.Text == "" || tbxMarca.Text == "")
            {
                
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
               /**
                * VERIFICAR SI EL NUMERO DE SERIE INTRODUCIDO EN EL CAMPO DE NUMSERIE YA EXISTE EN LA TABLA 
                */
                for (int i = 0; i < dgvInventario.Rows.Count; i++)
                {
                    if (dgvInventario.Rows[i].Cells[5].Value.ToString() == tbxNoSerie.Text.Trim())
                    {
                        btnAgregar.Enabled = false;
                        //btnActualizar.Enabled = true;
                        //btnEliminar.Enabled = true;
                        break;
                    }
                    else
                    {
                        btnAgregar.Enabled = true;
                        //btnActualizar.Enabled = true;
                        //btnEliminar.Enabled = true;
                    }
                }
                
            }
        }

        private void cbxArea_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        private void cbxColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxColaborador.Text == "")
            {
                lblAsteriscoColaborador.Visible = true;
            }
            else
            {
                lblAsteriscoColaborador.Visible = false;
            }
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxArea.Text == "")
            {
                lblAsteriscoAreaOficina.Visible = true;
            }
            else
            {
                lblAsteriscoAreaOficina.Visible = false;
            }
        }

        private void tbxNoOficina_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNoOficina.Text == "")
            {
                lblAsteriscoNoOficina.Visible = true;
            }
            else
            {
                lblAsteriscoNoOficina.Visible = false;
            }
        }

        private void cbxColaborador_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxTipo.Text == "")
            {
                lblAsteriscoTipoProd.Visible = true;
            }
            else
            {
                lblAsteriscoTipoProd.Visible = false;
            }
        }

        private void cbxNoSerie_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNoSerie.Text == "")
            {
                lblAsteriscoNoSerie.Visible = true;
            }
            else
            {
                lblAsteriscoNoSerie.Visible = false;
            }
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNombre.Text == "")
            {
                lblAsteriscoNomProd.Visible = true;
            }
            else
            {
                lblAsteriscoNomProd.Visible = false;
            }
        }

        private void tbxMarca_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxMarca.Text == "")
            {
                lblAsteriscoMarProd.Visible = true;
            }
            else
            {
                lblAsteriscoMarProd.Visible = false;
            }
        }

        private void cbxTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxTipo.Text == "")
            {
                lblAsteriscoTipoProd.Visible = true;
            }
            else
            {
                lblAsteriscoTipoProd.Visible = false;
            }
        }
    }
}
