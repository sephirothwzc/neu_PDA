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

namespace neu_PDA.iOS
{
	/// <summary>
	/// web服务辅助类Web client clr.
	/// </summary>
	public class WebClient_clr: IWebClient_clr
	{
		public WebClient_clr()
		{

		}

		public T WebRequest<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF-8")
		{
			var namevalues = datas.ToList().Select(d => string.Format(@"{0}:'{1}'",d.Key,d.Value)).ToArray();
			string data = "{" + string.Join(",", namevalues) + "}";

			string dwstring = string.Empty;//获取返回字符串
			using (WebClient webClient = new WebClient())
			{
				//webClient.Encoding = (Encoding)Enum.Parse(typeof(Encoding), charset);
				webClient.Headers["Method"] = method.ToString();
				webClient.Headers["Content-Type"] = string.Format(@"application/json; charset={0}",charset);
				dwstring = webClient.UploadString(uri, method, data);
				return JsonConvert.DeserializeObject<T>(dwstring);
			}
		}
	}
}

