﻿namespace ACollahuazoS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.vLogin());

        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new Views.vInicio());
        //}
    }
}