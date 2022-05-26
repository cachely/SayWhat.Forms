﻿using Xamarin.Forms;
using System.Reflection;

namespace SayWhat.Forms.Demo
{
    public partial class App : Application
    {
        public static string CurrentCulture = "en-US";
        
        public App()
        {
            InitializeComponent();

            //Initialization
            Utilities.SayWhat.Settings.Initialize(Assembly.GetAssembly(typeof(MainPage)), "SayWhat.Forms.Demo.Resources.AppResources", CurrentCulture);
            MainPage = new MainPage();
        }

        public static void UpdateCulture()
        {
            CurrentCulture = CurrentCulture.Equals("en-US") ? "es-US" : "en-US";
            Utilities.SayWhat.Settings.UpdateCulture(CurrentCulture);
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
