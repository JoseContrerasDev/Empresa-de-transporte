using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
using System.Security.Cryptography;


namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.CLIENTEEMPRESA' Puede moverla o quitarla según sea necesario.
           // this.cLIENTEEMPRESATableAdapter.Fill(this.iNTEGRADORNETDataSet.CLIENTEEMPRESA);
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.CLIENTEINDIVIDUO' Puede moverla o quitarla según sea necesario.
           // this.cLIENTEINDIVIDUOTableAdapter.Fill(this.iNTEGRADORNETDataSet.CLIENTEINDIVIDUO);

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cLIENTEINDIVIDUOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEINDIVIDUOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTEGRADORNETDataSet);

        }
        public void Mayusucula(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
                e.Handled = true;
        }
        private void cLIENTEINDIVIDUOBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nOMBRETextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);

        }

        private void nOMBRETextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tELEFONOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void aPELLIDOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);

        }

        private void mAILTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);
        }

        private void dIRECCIONTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dIRECCIONTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Dal objedal = new Datos.Dal();
            DataSet ds1 = new DataSet();
            ds1 = objedal.BuscarLegajo(textBusqueda.Text);

            DataTable dtEmpresa = ds1.Tables[0];
            cLIENTEEMPRESADataGridView.DataSource = dtEmpresa;
        }

        private void textBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayusucula(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Dal odjdal = new Dal(); //instancio clase datos
            odjdal.AgregarEmpresa(nOMBRETextBox1.Text, cUITTextBox.Text, cONTACTOTextBox.Text, mAILTextBox1.Text, tELEFONOTextBox1.Text,
                dIRECCIONTextBox1.Text);
            
            LimpiarTextBox();

            //DataSet ds2= new DataSet();
            //ds2 = odjdal.AgregarEmpresa

            //DataTable dtEmpresa = ds1.Tables[0];
            //cLIENTEEMPRESADataGridView.DataSource = dtEmpresa;






        }


        private void LimpiarTextBox()
        {
            // Limpiar cada TextBox
            nOMBRETextBox1.Text = string.Empty;
            cUITTextBox.Text = string.Empty;
            cONTACTOTextBox.Text = string.Empty;
            mAILTextBox1.Text = string.Empty;
            tELEFONOTextBox1.Text = string.Empty;
            dIRECCIONTextBox1.Text = string.Empty;

            // Puedes agregar más TextBox según sea necesario
        }
        private void cONTACTOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e) //Boton MODIFICAR registro
        {
            DialogResult resultado = MessageBox.Show("¿Confirma los cambios?" , " Aviso " , MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Dal odjdal = new Dal(); //instancio clase datos
                ClienteEmpresa empresa = new ClienteEmpresa(nOMBRETextBox1.Text, cUITTextBox.Text, cONTACTOTextBox.Text, mAILTextBox1.Text, tELEFONOTextBox1.Text,
                    dIRECCIONTextBox1.Text);
                odjdal.ModEmpresa(empresa);

                LimpiarTextBox();

            }
               
        }

        private void cLIENTEEMPRESADataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Creacion de la tabla CLIENTE EMPRESA
        {
            if(e.RowIndex < 0)
            { 
                return;
            }
            List<string> Objedatos = new List<string>();
            for (int i=0; i < cLIENTEEMPRESADataGridView.Rows[e.RowIndex].Cells.Count; i++)
            {
                Objedatos.Add(cLIENTEEMPRESADataGridView.Rows[e.RowIndex].Cells[i].Value.ToString());
            }
            nOMBRETextBox1.Text = Objedatos[1];
            cONTACTOTextBox.Text = Objedatos[2];
            cUITTextBox.Text = Objedatos[3];
            mAILTextBox1.Text= Objedatos[4];
            tELEFONOTextBox1.Text = Objedatos[5];
            dIRECCIONTextBox1.Text = Objedatos[6];
            
        }

        private void Button2 (object sender, EventArgs e)
        {
            // Verificar si hay un texto en el campo de búsqueda
            if (!string.IsNullOrWhiteSpace(textBusqueda.Text))
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    // Intentar eliminar el registro utilizando el valor de textBusqueda.Text
                    try
                    {
                        Datos.Dal objdal = new Datos.Dal();
                        objdal.EliminarEmpresa(textBusqueda.Text);
                        MessageBox.Show("Se eliminó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de eliminar el registro
                        LimpiarTextBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo de búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void VER_Click(object sender, EventArgs e) //Boton buscar registro
        {
            Datos.Dal objedal = new Datos.Dal();
             
            DataSet ds1 = objedal.verEmpresa();

            //DataTable dtEmpresa = ds1.Tables[0];
            cLIENTEEMPRESADataGridView.DataSource = ds1.Tables[0];
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
