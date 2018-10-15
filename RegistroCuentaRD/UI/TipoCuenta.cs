using RegistroCuentaRD.BLL;
using RegistroCuentaRD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCuentaRD.UI
{
    public partial class TipoCuenta : Form
    {
        RepositorioBase<TiposCuentas> repositorio;
        public TipoCuenta()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        public TiposCuentas LlenaClase()
        {
            TiposCuentas tiposDeCuentas = new TiposCuentas();
            tiposDeCuentas.TipoID = Convert.ToInt32(IDnumericUpDown.Value);
            tiposDeCuentas.Descripcion = DescripciontextBox.Text;
            return tiposDeCuentas;
        }
        public void Llenacampo(TiposCuentas tiposDeCuentas)
        {
            IDnumericUpDown.Value = tiposDeCuentas.TipoID;
            DescripciontextBox.Text = tiposDeCuentas.Descripcion;
        }
        private bool ExiteEnlaDB()
        {
            repositorio = new RepositorioBase<TiposCuentas>();
            TiposCuentas tiposDeCuentas = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (tiposDeCuentas != null);

        }


        public bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))

                errorProvider1.SetError(DescripciontextBox, "Expacio en blanco");
            paso = false;


            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<TiposCuentas>();

            TiposCuentas tiposDeCuentas;
            bool paso = false;
            tiposDeCuentas = LlenaClase();
            if (!Validar())
                return;

            if (IDnumericUpDown.Value >= 0)
            {

                paso = repositorio.Guardar(tiposDeCuentas);

            }
            else
            {
                if (!ExiteEnlaDB())
                {
                    MessageBox.Show("no exite ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(tiposDeCuentas);
            }
            if (paso)
            {
                MessageBox.Show("Guardo Correctamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show(" no Guardo !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>();
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExiteEnlaDB())
            {
                errorProvider1.SetError(IDnumericUpDown, "No exite");
                IDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Elimino con Exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>();
            TiposCuentas tiposDeCuentas = new TiposCuentas();
            int.TryParse(IDnumericUpDown.Text, out id);
            tiposDeCuentas = repositorio.Buscar(id);

            if (tiposDeCuentas != null)
            {
                MessageBox.Show("Econtado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Llenacampo(tiposDeCuentas);
            }
            else
            {
                MessageBox.Show("No Exite!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
