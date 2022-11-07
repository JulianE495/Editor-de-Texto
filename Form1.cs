using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class frTextEditor : Form
    {
        public frTextEditor()
        {
            InitializeComponent();
            ocultarSubMenu();
            ocultarPaneles();
        }

        private void ocultarSubMenu()
        {
            pnArchivoSubMenu.Visible = false;
            pnFormatoSubMenu.Visible = false;
        }
        
        private void ocultarPaneles()
        {
            pnEditorTexto.Visible = false;
            // Tu codigo aqui.......
        }

        private void mostarFileTools()
        {
            if (pnArchivoSubMenu.Visible == false)
            {
                pnArchivoSubMenu.Visible = true;
            }
            else
            {
                pnArchivoSubMenu.Visible = false;
            }
        }

        private void mostrarFormatTools()
        {
            if (pnFormatoSubMenu.Visible == false)
            {
                pnFormatoSubMenu.Visible = true;
            }
            else
            {
                pnFormatoSubMenu.Visible = false;
            }
        }

        private void panelInicio()
        {
            if (pnInicio.Visible == false) 
            {
                pnInicio.Visible = true;
                pnEditorTexto.Visible = false;
            }
        }
        private void btnMenuArchivo_Click(object sender, EventArgs e)
        {
            mostarFileTools();
            if (pnEditorTexto.Visible == false) 
            {
                pnEditorTexto.Visible = true;
                pnInicio.Visible = false;
            }
            // Tu codigo aqui......
        }

        private void btnMenuFormato_Click(object sender, EventArgs e)
        {
            mostrarFormatTools();
            // Tu codigo aqui......
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelInicio();

            // Tu codigo aqui......
        }
    }
}
