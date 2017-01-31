using System;
using System.IO;
using FTPLib;

namespace tester{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public const string HOST = "nyczftp001";
		public const string USER_NAME = "marsftp";
		public const string PASSWORD = "d3fnrW5zD";
		public const string DIRECTORY = "outgoing";

		[STAThread]
		static void Main(string[] args){
			Console.WriteLine( new Class1().put( "c:\\test.xml", "testfile" ) );
		}

		public bool put( string localFilename, string remoteFilename) {
			bool rtn = false;
			try { 
				FTPClient ftp = new FTPClient( HOST );
				ftp.Login(USER_NAME, PASSWORD);
				ftp.Chdir( DIRECTORY );

				ftp.Put( getBytes(localFilename), DateTime.Now.ToString("yyyyMMdd") + "_" + remoteFilename );
				rtn = true;
			} catch (Exception ex) { 
				Console.WriteLine( ex.Message );
				rtn = false;
			} 
			return rtn;
		}

		private byte[] getBytes( string filename ){
			byte[] buff = new byte[ 4096 ];
			Stream strm = new FileStream( filename, FileMode.Open, FileAccess.Read );
			int read = 0;
			MemoryStream mem = new MemoryStream();
			while( (read = strm.Read( buff, 0, buff.Length )) > 0 ){
				mem.Write( buff, 0, read );
			}
			strm.Close();
			mem.Close();
			return mem.ToArray();
		}
		
		private string pathify( string path ){
			if( path == null ){path="";}
			if( !path.EndsWith( Path.DirectorySeparatorChar.ToString() ) ){
				path += Path.DirectorySeparatorChar.ToString();
			}
			return path;
		}
	}
}
