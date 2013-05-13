/*
 * Created by SharpDevelop.
 * User: PhpDev
 * Date: 13.05.2013
 * Time: 15:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;

namespace JSONLib
{
	/// <summary>
	/// Description of JSONHelper.
	/// </summary>
	public class JSONHelper
	{
		public JSONHelper()
		{
		}
		
		public static string replace(Match m)
		{
			string s= m.ToString();
			if(s == "\n")
			{
				return "\\n";
			}
			if(s == "\t")
			{
				return "\\t";
			}
			if(s == "\r")
			{
				return "\\r";
			}
			if(s == "\"")
			{
				return "\\\"";
			}
			if(s == "\b")
			{
				return "\\b";
			}
			if(s == "\f")
			{
				return "\\f";
			}
			return s;
		}
		
		public static string EscapeString(string s)
		{
			Regex re = new Regex("[\t\r\n\"\\\b\f]");
			return re.Replace(s, new MatchEvaluator(JSONHelper.replace));
		}
	}
}
