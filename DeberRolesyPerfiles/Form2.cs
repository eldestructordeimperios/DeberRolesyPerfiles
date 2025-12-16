using DeberRolesyPerfiles.Context;
using DeberRolesyPerfiles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberRolesyPerfiles
{
    public partial class Form2 : Form
    {
        public Usuario usuarioregistrado;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = $"Login de {usuarioregistrado.Nombres}";
            cargamenuopciones();
        }

        private void cargamenuopciones()
        {
            var db = new BaseAdoContext();
            var rolesid = db.UsuarioXRoles.Where(i => i.IdUsuario == usuarioregistrado.Id)
            .Select(i => i.IdRol)
            .Distinct()
            .ToList();
            var opciones = (from oxr in db.OpcionesXRoles
                            join op in db.Opciones on oxr.IdOpcion equals op.Id
                            where rolesid.Contains(oxr.IdRol)
                            select op)
            .Distinct()
            .ToList();
            foreach (var opcion in opciones)
            {
                var item = new ToolStripMenuItem(opcion.Descripcion);
                item.Tag = opcion.NombreFormulario;
                item.Click += MenuOpcion_Click;
                tsmenu.Items.Add(item);
                
            }
        }
        private void MenuOpcion_Click(object sender, EventArgs e)
        {
            var fomName = (sender as ToolStripMenuItem).Tag.ToString();
            var tipo = Assembly.GetExecutingAssembly().GetTypes().Where(i => i.IsSubclassOf(typeof(Form)) && i.Name == fomName).FirstOrDefault();
            var frm = (Form)Activator.CreateInstance(tipo);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
