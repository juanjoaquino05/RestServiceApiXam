﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestServiceApiXam
{
    public partial class App : Application
    {
        public static string API_KEY = "a64d390ba79b4e2bb37c89d11226414";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
