﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using Newtonsoft.Json;
using ZXing.Net.Mobile.Forms;

namespace neu_PDA
{
	public partial class Login : ContentPage
	{
		public string url = @"http://219.143.238.188:8710/Web/Module/Barcode/PDAService.asmx";

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			App.Current.MainPage = new P_demo();
		}

		public Login()
		{
			InitializeComponent();

			//初始化上下文

			//Uri uri = new Uri("http://58.211.118.189:8710/Web/Webservice/MES/WS_MESPPService.asmx/GetMESWcProTimeJson");
			//IDictionary<string, string> datas = new Dictionary<string, string>();


			//datas.Add("post", "10000");
			//datas.Add("commoit", JsonConvert.SerializeObject(new MESWcProTime
			//{
			//	ROW_ID = "",
			//	BUFFER1 = "111"
			//}));

			//var str = GetCLR.webclient.WebRequest<List<MESWcProTime>>(uri, datas);
			//this.SplashTitle.Text = str.FirstOrDefault().ROW_ID;

			this.barcode.Clicked += (object sender, EventArgs e) => 
			{
				string turl = url + "/CheckUser";
				IDictionary<string, string> cudata = new Dictionary<string, string>();
				cudata.Add("plant", "1000");
				cudata.Add("userID", "bcsupport");
				cudata.Add("password", "123");

				UserDto user = GetCLR.webclient.WebRequest<UserDto>(new Uri(turl), cudata);
				DisplayAlert("", user.UserName, "yes");
			};
		}
	}
}

