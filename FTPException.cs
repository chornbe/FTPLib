using System;

namespace FTPLib{
	/// <summary>  
	/// FTP specific exceptions	
	/// </summary>
	/// <author>      
	/// Bruce Blackshaw
	/// </author>
	/// <version>     
	/// $Revision: 1.1 $
	/// </version>
	public class FTPException:System.Exception {
		/// <summary>   
		/// Get the reply code if it exists
		/// </summary>
		/// <returns>  
		/// reply if it exists, -1 otherwise
		/// </returns>
		public int ReplyCode {
			get {
				return replyCode;
			}
			
		}
		
		/// <summary>  
		/// Revision control id
		/// </summary>
		private static string cvsId = "@(#)$Id: FTPException.cs,v 1.1 2003/05/17 12:33:13 bruceb Exp $";
		
		
		/// <summary>  Integer reply code
		/// </summary>
		private int replyCode = - 1;
		
		/// <summary>   
		/// Constructor. Delegates to super.
		/// </summary>
		/// <param name="msg">  Message that the user will be
		/// able to retrieve
		/// 
		/// </param>
		public FTPException(string msg):base(msg) {
		}
		
		/// <summary>  
		/// Constructor. Permits setting of reply code
		/// </summary>
		/// <param name="msg">       
		/// message that the user will be able to retrieve
		/// </param>
		/// <param name="replyCode"> string form of reply code
		/// 
		/// </param>
		public FTPException(string msg, string replyCode):base(msg) {			
			// extract reply code if possible
			try {
				this.replyCode = System.Int32.Parse(replyCode);
			}
			catch (System.FormatException) {
				this.replyCode = - 1;
			}
		}
		
		
	}
}
