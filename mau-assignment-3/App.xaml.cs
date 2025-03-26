﻿using System.Diagnostics;

namespace mau_assignment_3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

		}

		protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}