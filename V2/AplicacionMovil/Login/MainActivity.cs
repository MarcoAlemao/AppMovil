using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Login
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public Button btnLogin;
        public EditText txtUser, txtPass;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUser = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPass = FindViewById<EditText>(Resource.Id.txtPassword);

            btnLogin.Click += btnLogin_Click;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format("http://xamarinlogin.azurewebsites.net/api/Login?username=" + txtUser.Text + "&password=" + txtPass.Text));
            HttpResponseMessage response; ;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            response = await client.GetAsync(uri);
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'
                });
                Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
            }
            else
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'
                });
                Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
            }
        }
    }
}

