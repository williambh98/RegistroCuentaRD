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
    public partial class Cuenta : Form
    {
        private RepositorioBase<Cuentas> repositorio;
        public Cuenta()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IDnumericUpDown1.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MontonumericUpDown.Value = 0;
        }
        public Cuentas Llenaclase()
        {
            Cuentas cuentas = new Cuentas();
            cuentas.CuentaID = Convert.ToInt32(IDnumericUpDown1.Value);
            cuentas.Descripcion =DescripciontextBox.Text;
            cuentas.Monto = Convert.ToDouble(MontonumericUpDown.Value);

            return cuentas;
        }


        public void LlenarCampo(Cuentas cuentas)
        {
            IDnumericUpDown1.Value = cuentas.CuentaID;
            DescripciontextBox.Text = cuentas.Descripcion;
            MontonumericUpDown.Value = Convert.ToDecimal(cuentas.Monto);
        }


        private bool ExiteEnLaDb()
        {
            repositorio = new RepositorioBase<Cuentas>();
            Cuentas cuentas = repositorio.Buscar((int)IDnumericUpDown1.Value);
            return (cuentas != null);
        }

        public bool GValidar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo vacio por por favor digite el dato");
                paso = false;
            }
            if (MontonumericUpDown.Value == 0)
            {
                errorProvider1.SetError(MontonumericUpDown, "Llenar campo");
                paso = false;
            }
            return paso;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Cuentas>();
            Cuentas cuentas;
            bool paso = false;

            cuentas = Llenaclase();
            if (!GValidar())
                return;
            if (IDnumericUpDown1.Value >= 0)
                paso = repositorio.Guardar(cuentas);
            else
            {
                if (!ExiteEnLaDb())
                    MessageBox.Show("No Exite No es Modificable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            paso = repositorio.Modificar(cuentas);

            if (paso)
            {
                MessageBox.Show("Guardado con Exito", "Guardo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Guado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Cuentas>();
            int.TryParse(IDnumericUpDown1.Text, out id);
            if (!ExiteEnLaDb())
            {
                errorProvider1.SetError(IDnumericUpDown1, "No Exite!!");
                IDnumericUpDown1.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Elimino");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Cuentas>();
            Cuentas cuentas = new Cuentas();
            int.TryParse(IDnumericUpDown1.Text, out id);
            cuentas = repositorio.Buscar(id);

            if (cuentas != null)
            {
                MessageBox.Show("Cuenta Encotrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampo(cuentas);
            }
            else
                MessageBox.Show("No encontrado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoCuenta tp = new TipoCuenta();
            tp.Show();

        }
    }
}
