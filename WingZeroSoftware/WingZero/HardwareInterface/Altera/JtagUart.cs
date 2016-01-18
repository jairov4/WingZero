using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WingZero.HardwareInterface.Altera
{
	public class JtagUart
	{
		[DllImport("Resources\\jtag_atlantic.dll", EntryPoint = "?jtagatlantic_open@@YAPAUJTAGATLANTIC@@PBDHH0@Z")]		
		public static extern int Open(int link, int device_index, int link_instance, [MarshalAs(UnmanagedType.LPStr)] string app_name);
		[DllImport("Resources\\jtag_atlantic.dll", EntryPoint = "?jtagatlantic_close@@YAXPAUJTAGATLANTIC@@@Z")]
		public static extern void Close(int link);
		[DllImport("Resources\\jtag_atlantic.dll", EntryPoint = "?jtagatlantic_write@@YAHPAUJTAGATLANTIC@@PBDI@Z")]
		public static extern int _Write(int link, [MarshalAs(UnmanagedType.LPArray)] byte[] data, int count);
		[DllImport("Resources\\jtag_atlantic.dll", EntryPoint = "?jtagatlantic_flush@@YAHPAUJTAGATLANTIC@@@Z")]
		public static extern int Flush(int link);
		[DllImport("Resources\\jtag_atlantic.dll", EntryPoint = "?jtagatlantic_read@@YAHPAUJTAGATLANTIC@@PADI@Z")]
		private static extern int _Read(int link, [Out, MarshalAs(UnmanagedType.LPArray)] byte[] buffer, int buffsize);

		public static int Write(int link, byte[] buffer) {
			int ret = _Write(link, buffer, buffer.Length);
			return ret;
		}

		public static byte[] Read(int link, int max_count)
		{
			byte[] buffer = new byte[max_count];
			int read = _Read(link, buffer, max_count);
			byte[] nbuffer = new byte[read];
			for(int i=0; i<read; i++)
			{
				nbuffer[i] = buffer[i];
			}
			return nbuffer;
		}
	}
}
