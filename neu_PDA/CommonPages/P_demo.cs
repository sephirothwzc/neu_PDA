using System;

using Xamarin.Forms;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace neu_PDA
{
	public class P_demo : MasterDetailPage
	{
		void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var newPage = new ContentPage()
			{

				Content = new StackLayout
				{
					Children =
					{
						new Label
						{
							Text=e.SelectedItem.ToString()
						}
					}
				}
			};
			//Pages.Add(e.SelectedItem.ToString(), newPage);
			this.Detail = newPage;
		}

		/// <summary>
		/// 当前打开窗体
		/// </summary>
		/// <value>The pages.</value>
		Dictionary<string, NavigationPage> Pages { get; set; }

		public P_demo()
		{
			Label header = new Label
			{
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			var itemsSource = new string[]{
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

			ListView listView = new ListView
			{
				ItemsSource = itemsSource
			};


			this.Master = new ContentPage
			{
				Title = "headerText",
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView
					}
				}
			};

			listView.ItemSelected+= ListView_ItemSelected;
			this.Detail = new NavigationPage(new MenuPage());
			//NavigateAsync(listView.SelectedItem.ToString());
		}

	}
}


