using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Newtonsoft.Json;
using BLL;
using DAL;

namespace Windows_App_Project {
    public partial class FrmLogin : Form
    {
        private ApiBigFood _cliente = null;

        private HttpClient _api = null;

        public FrmLogin()
        {
            InitializeComponent();

            _cliente = new ApiBigFood();

            _api = _cliente.IniciarApi();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion(this.txtUser.Text,this.txtPass.Text);
        }

        private async void IniciarSesion(string U,string C)
        {
            if (VerificarCampos()==false)
            {
                MessageBox.Show("Debe de rellenar bien los campos");
            }
            else
            {
                User usuarios = new User()
                {
                    id = 0,
                    login = U,
                    password = C,
                    fechaRegistro = DateTime.Now,
                    estado = ""
                };

                var json = JsonConvert.SerializeObject(usuarios);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _api.PostAsync($"Usuarios/Autentificar", content);

                if (response.IsSuccessStatusCode)
                {
                    string mensaje = await response.Content.ReadAsStringAsync();
                    AutorizacionResponse dJason = JsonConvert.DeserializeObject<AutorizacionResponse>(mensaje);
                    FrmMain.token = dJason.Token;
                    FrmMain.Usuario = U;

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Las credenciales no son correctas: {response.StatusCode}");
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
            }
        }

        private bool VerificarCampos()
        {
            if (this.txtUser.Text == string.Empty&& this.txtPass.Text ==string.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
