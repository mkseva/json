/*
 * Created by SharpDevelop.
 * User: PhpDev
 * Date: 13.05.2013
 * Time: 14:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JSONLib
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class JSONObject
	{
		Hashtable data = new Hashtable();
		
		public void put(string keyName, object obj)
		{
			data.Add(keyName, obj);
		}
		
		private void toString(StringBuilder sb)
		{
			sb.Append("{");
			bool isFirst = true;
			foreach(String key in data.Keys)
			{
				if(!isFirst)
				{
					sb.Append(",");
				}
				else 
				{
					isFirst = false;
				}
				
				sb.Append("\"").Append(key).Append("\":");
				object obj = data[key];
				if(obj == null)
				{
					sb.Append("null");
				} 
				else if(obj is int)
				{
					sb.Append(obj.ToString());
				}
				else if(obj is string)
				{
					sb.Append("\"").Append(JSONHelper.EscapeString(obj.ToString())).Append("\"");
				}
				else if(obj is JSONObject)
				{
					((JSONObject)obj).toString(sb);
				}
			}
			sb.Append("}");
		}
		
		override
		public string ToString() 
		{
			StringBuilder sb = 	new StringBuilder();
			toString(sb);
			return sb.ToString();
		}
	}
}