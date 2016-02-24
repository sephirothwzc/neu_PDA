using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace neu_PDA
{
	public partial class MenuPage : ContentPage
	{


		public MenuPage()
		{
			InitializeComponent();

			EmployeeView.ItemsSource = new string[]{
				"mono",
				"monodroid",
				"monotouch",
				"monorail",
				"monodevelop",
				"monotone",
				"monopoly",
				"monomodal",
				"mononucleosis"
			};
		}
	}
}

