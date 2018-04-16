using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ConsultorioUH
{
    [Activity(Label = "MenuPrincipal")]
    public class MenuPrincipal : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MenuPrincipal);

            var imgBtnCita = FindViewById<ImageButton>(Resource.Id.imgCita);
            var imgBtnExp = FindViewById<ImageButton>(Resource.Id.imgExpediente);
            var imgBtnNut = FindViewById<ImageButton>(Resource.Id.imgNutricion);

            imgBtnCita.Click += btnCita_Click;
            imgBtnNut.Click += btnNutricion_Click;
            imgBtnExp.Click += btnExpediente_Click;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            {
                StartActivity(typeof(Cita));
            }
        }
        private void btnNutricion_Click(object sender, EventArgs e)
        {
            {
                StartActivity(typeof(Nutricion));
            }
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            {
                StartActivity(typeof(Expediente));
            }
        }
    }
    }
