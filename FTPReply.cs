using System;

namespace FTPLib{
	/// <summary>  Encapsulates the FTP server reply
	///  
	/// </summary>
	/// <author>       Bruce Blackshaw
	/// </author>
	/// <version>      $Revision: 1.1 $
	/// 
	/// </version>
	public class FTPReply {
		/// <summary>  Getter for reply code
		///  
		/// </summary>
		/// <returns> server's reply code
		/// 
		/// </returns>
		public string ReplyCode {
			get {
				return replyCode;
			}			
		}

		/// <summary>  Getter for reply text
		/// 
		/// </summary>
		/// <returns> server's reply text
		/// 
		/// </returns>
		public string ReplyText {
			get {
				return replyText;
			}			
		}
		
		/// <summary>  Revision control id
		/// </summary>
		private static string cvsId = "@(#)$Id: FTPReply.cs,v 1.1 2003/05/17 12:33:13 bruceb Exp $";
		
		/// <summary>  Reply code
		/// </summary>
		private string replyCode;
		
		/// <summary>  Reply text
		/// </summary>
		private string replyText;
		
		
		/// <summary>  
		/// Constructor. Only to be constructed
		/// by this package, hence internal access
		/// </summary>
		/// <param name="replyCode"> the server's reply code
		/// </param>
		/// <param name="replyText"> the server's reply text
		/// 
		/// </param>
		internal FTPReply(string replyCode, string replyText) {
			this.replyCode = replyCode;
			this.replyText = replyText;
		}
		
		
	}
}
