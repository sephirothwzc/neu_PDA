﻿using System;
using System.Collections.Generic; 

namespace neu_PDA
{
	public interface IWebClient_clr
	{
		T WebRequest<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF8") where T : new();
	}

	public class GetCLR
	{ 
		public static IWebClient_clr webclient { get; set; }

		public GetCLR(IWebClient_clr wc)
		{
			GetCLR.webclient = wc;
		}
	}
}

