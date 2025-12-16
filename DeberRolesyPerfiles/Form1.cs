using DeberRolesyPerfiles.Context;
using DeberRolesyPerfiles.Models;
using Microsoft.EntityFrameworkCore;

namespace DeberRolesyPerfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var codigo = textBox1.Text;
                var contrasena = textBox2.Text;

                var dbContext = new BaseAdoContext();

                var usuario = dbContext.Usuarios.FirstOrDefault(i => i.Codigo== codigo && i.Contrasena == contrasena);
                
                if (usuario == null)
                {
                    MessageBox.Show("Usuario invalido¡");
                    return;
                }
                else
                {
                     Form2 form2 = new Form2();
                    form2.usuarioregistrado = usuario;
                    form2.Show();
                    this.Hide();
                }

            }
        }

        private bool Validar()
        {
           if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("El campo usuario es obligatorio"); 
                textBox1.Focus();
                return false;

            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("El campo contraseña es obligatorio");
                textBox1.Focus();
                return false;

            }
            return true;
        }
    }
}


