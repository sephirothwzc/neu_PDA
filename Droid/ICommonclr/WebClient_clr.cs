using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;


namespace neu_PDA.Droid
{
	public class WebClient_clr: IWebClient_clr
	{
		public WebClient_clr()
		{
			
		}

		public T WebRequest<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF8") where T : new()
		{
			string runstr = string.Empty;
			NameValueCollection param = new NameValueCollection();
			foreach (var arg in datas)
			{
				param.Add(arg.Key, arg.Value);
			}
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			if (datas != null||"POST".Equals(method))
			{
				webClient.Headers["Content-Type"] = "application/x-www-form-urlencoded";
				byte[] runbyte = webClient.UploadValues(uri, method.ToString(), param);
				runstr = Encoding.UTF8.GetString(runbyte);
			}
			else
			{
				webClient.Headers["Method"] = method.ToString();
				webClient.Headers["Content-Type"] = "application/json";
				runstr = webClient.DownloadString(uri);
			}
			return ObjectConvertJson<T>(runstr);
		}


		#region 字符串对象序列化--ObjectConvertJson
		/// <summary>
		/// 字符串对象序列化
		/// </summary>
		/// <param name="jsonstr"></param>
		/// <returns></returns>
		public static T ObjectConvertJson<T>(string jsonstr) where T : new()
		{
			try
			{
				if (string.IsNullOrEmpty(jsonstr) || jsonstr == "{}" || jsonstr == "Token String in state Start would result in an invalid JavaScript object.")
					return default(T);
				if(!typeof(T).Name.Equals("Object"))//不等于动态类型
					return JsonConvert.DeserializeObject<T>(jsonstr);

				return default(T);
				////dynamic类型转换
				//var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
				//serializer.MaxJsonLength = Int32.MaxValue;
				//serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
				//dynamic data = serializer.Deserialize<T>(jsonstr);//T为dynamic
				//return data;
			}
			catch (Exception ex)
			{
				Debug.Print(ex.Message);
				throw new NotImplementedException(jsonstr + "\r\n+" + ex.Message);
			}
		}
		#endregion

		#region 对象序列化json-ObjectToJson
		/// <summary>
		/// ObjectToJson 对象序列化 返回json
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string ObjectToJson(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
		#endregion
	}
}

