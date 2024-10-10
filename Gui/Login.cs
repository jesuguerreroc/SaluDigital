using System.Runtime.InteropServices;

namespace Gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "USUARIO")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.DarkBlue;
            }
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "USUARIO";
                textBox_usuario.ForeColor = Color.DimGray;
            }

        }

        private void textBox_contrasena_Enter(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "CONTRASEÑA")
            {
                textBox_contrasena.Text = "";
                textBox_contrasena.ForeColor = Color.DarkBlue;
                textBox_contrasena.UseSystemPasswordChar = true;

            }

        }

        private void textBox_contrasena_Leave(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "")
            {
                textBox_contrasena.Text = "CONTRASEÑA";
                textBox_contrasena.ForeColor = Color.DimGray;
                textBox_contrasena.UseSystemPasswordChar = false;

            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Iniciodesesion();

        }

        private void Iniciodesesion()
        {

            string usuario = textBox_usuario.Text;
            string contrasena = textBox_contrasena.Text;

            if (usuario == "USUARIO" || contrasena == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }


            string rutaArchivo = @"C:\Users\jesug\source\repos\Gui\Gui\usuarios.txt";

            try
            {
                var lineas = System.IO.File.ReadAllLines(rutaArchivo);
                bool usuarioValido = false;

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(';');
                    if (datos.Length >= 4)
                    {
                        string usuarioArchivo = datos[2];
                        string contrasenaArchivo = datos[3];

                        if (usuarioArchivo == usuario && contrasenaArchivo == contrasena)
                        {
                            usuarioValido = true;
                            break;
                        }
                    }
                }

                if (usuarioValido)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los datos: {ex.Message}");
            }
        }

        private void btn_registrar_usuario_Click(object sender, EventArgs e)
        {
            Registrarse registro = new Registrarse(); 
            registro.Show();
            this.Hide();
        }

        private static Login instance;
        public static Login GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Login();
            }
            return instance;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
