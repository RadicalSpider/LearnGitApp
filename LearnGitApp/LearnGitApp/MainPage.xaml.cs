﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnGitApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void buttomOk_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Saludo", "Hola", "Ok");
        }
    }
}
