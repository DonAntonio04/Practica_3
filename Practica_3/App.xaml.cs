﻿using Practica_3.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Critografo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
