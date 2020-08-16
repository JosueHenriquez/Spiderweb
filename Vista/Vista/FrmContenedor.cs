using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmContenedor : Form
    {
        protected int nivel = 1;
        public FrmContenedor()
        {
            InitializeComponent();
        }

        private void Accesos()
        {
            switch (nivel)
            {
                case 1:
                    //Administrador general (root)
                    break;
                case 2:
                    //Coordinador
                    BtnConfiguracion.Visible = false;
                    MenuConfiguracion.Visible = false;
                    break;
                case 3:
                    //Encargado de empresa
                    BtnConfiguracion.Visible = false;
                    MenuConfiguracion.Visible = false;
                    BtnAdministracion.Visible = false;
                    MenuAdministracion.Visible = false;
                    BtnReportes.Visible = false;
                    MenuReportes.Visible = false;
                    BtnCategorias.Enabled = false;
                    BtnReportes.Visible = false;
                    MenuPpalReportes.Enabled = false;
                    MenuPpalMenu.Enabled = false;
                    break;
                case 4:
                    //Asistente de encargado
                    BtnConfiguracion.Visible = false;
                    MenuConfiguracion.Visible = false;
                    BtnAdministracion.Visible = false;
                    MenuAdministracion.Visible = false;
                    BtnReportes.Visible = false;
                    MenuReportes.Visible = false;
                    BtnCategorias.Enabled = false;
                    BtnReportes.Visible = false;
                    MenuPpalReportes.Enabled = false;
                    MenuPpalMenu.Enabled = false;
                    break;
                case 5:
                    //Encargado de facturación
                    BtnConfiguracion.Visible = false;
                    MenuConfiguracion.Visible = false;
                    BtnAdministracion.Visible = false;
                    MenuAdministracion.Visible = false;
                    BtnReportes.Visible = false;
                    MenuReportes.Visible = false;
                    MenuPpalReportes.Enabled = false;
                    MenuPpalMenu.Enabled = false;
                    BtnFactDia.Enabled = false;
                    MenuFactPeriodo.Enabled = false;
                    BtnInventario.Visible = false;
                    BtnGestionProductos.Visible = false;
                    break;
                case 6:
                    //Administrador estudiantil (alumno de software)
                    BtnInventario.Visible = false;
                    MenuInventario.Visible = false;
                    BtnFacturacion.Visible = false;
                    MenuFacturacion.Visible = false;
                    BtnReportes.Visible = false;
                    MenuReportes.Visible = false;
                    BtnConfiguracion.Visible = false;
                    MenuConfiguracion.Visible = false;
                    break;
                case 7:
                    //Producción (falta definir funciones)
                    break;
                default:
                    break;
            }
        }

        void Ubicaciones()
        {
            /*switch (switch_on)
            {
                case 1:
                    //Administrador general (root)
                    break;
                case 2:
                    //Coordinador
                    break;
                case 3:
                    //Encargado de empresa
                    break;
                case 4:
                    //Asistente de encargado
                    break;
                case 5:
                    //Encargado de facturación
                    break;
                case 6:
                    //Administrador estudiantil
                    break;
                case 7:
                    //Producción
                    break;
                default:
                    break;
            }*/
        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            Accesos();
        }
    }
}
