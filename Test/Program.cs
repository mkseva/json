/*
 * Created by SharpDevelop.
 * User: PhpDev
 * Date: 13.05.2013
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			JSONLib.JSONObject jo = new JSONLib.JSONObject();
			JSONLib.JSONObject jo2 = new JSONLib.JSONObject();
			jo.put("key" , 45);
			
			jo.put("key2" , "simple \n\"string\"");
			jo2.put("name", 353);
			jo.put("onk", jo2);
			
			Console.WriteLine("Object is: " + jo.ToString());
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}