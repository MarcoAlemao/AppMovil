using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ConsultorioUH
{
    [Activity(Label = "ConsultorioUH", MainLauncher = true, Icon = "@drawable/AppIcon")]
    public class MainActivity : Activity
    {
        

        private Button btnLogin;
        private EditText txtUser, txtPass;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUser = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPass = FindViewById<EditText>(Resource.Id.txtPassword);

            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "test" && txtPass.Text == "test")
                {
                StartActivity(typeof(MenuPrincipal));
                }
            else
            {
                Toast.MakeText(this, "Contraseña/Usuario inválido", ToastLength.Long).Show();
            }
        }
    }
}

