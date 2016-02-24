using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace neu_PDA
{
	public partial class Login : ContentPage
	{

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			App.Current.MainPage = new P_demo();
		}

		public Login()
		{
			InitializeComponent();

			//初始化上下文
		}
	}
}

