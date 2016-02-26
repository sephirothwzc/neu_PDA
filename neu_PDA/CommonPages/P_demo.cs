using System;

using Xamarin.Forms;

using System.Collections.Generic;
using System.Threading.Tasks;

using ZXing.Net.Mobile;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using ZXing;

namespace neu_PDA
{
	public class P_demo : MasterDetailPage
	{
		ZXingScannerPage scanPage;
		Page mmpage;
		/// <summary>
		/// 导航更改事件
		/// </summary>
		/// <returns>The view item selected.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

			if (this.Pages!=null && this.Pages.ContainsKey(e.SelectedItem.ToString()))
			{
				this.Detail = this.Pages[e.SelectedItem.ToString()];
				return;
			}
			if ("回主页".Equals(e.SelectedItem.ToString()))
			{
				//生成扫描窗体
				scanPage = new ZXingScannerPage();
				//绑定扫描后事件
				scanPage.OnScanResult += (result) =>
				{
					scanPage.IsScanning = false;
					//主线程回调
					Device.BeginInvokeOnMainThread(() =>
					{
						//窗体pop
						Navigation.PopAsync();
						DisplayAlert("Scanned Barcode", result.Text, "OK");
					});
				};
				this.Detail = new NavigationPage(scanPage);
				return;
			}
			var newPage = new NavigationPage(new ContentPage()
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
			});
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
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			var itemsSource = new string[]{
				"回主页",
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


			mmpage = new ContentPage
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
			this.Master = mmpage;

			listView.ItemSelected += ListView_ItemSelected;
			this.Detail = new NavigationPage(new MenuPage());
			//NavigateAsync(listView.SelectedItem.ToString());
		}

	}
}


