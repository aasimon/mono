//
// System.Net.Mail.SmtpException.cs
//
// Author:
//	Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) Tim Coleman, 2004
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0

using System.Runtime.Serialization;

namespace System.Net.Mail {
	[Serializable]
	public class SmtpException : Exception, ISerializable
	{
		#region Fields

		SmtpStatusCode statusCode;

		#endregion // Fields

		#region Constructors

		public SmtpException ()
		{
		}

		public SmtpException (SmtpStatusCode statusCode)
		{
			StatusCode = statusCode;
		}

		public SmtpException (string message)
			: base (message)
		{
		}

		public SmtpException (SerializationInfo info, StreamingContext context)
			: base (info, context)
		{
		}

		public SmtpException (SmtpStatusCode statusCode, string message)
			: base (message)
		{
			StatusCode = statusCode;
		}

		public SmtpException (string message, Exception innerException)
			: base (message, innerException)
		{
		}

		#endregion // Constructors

		#region Properties

		public SmtpStatusCode StatusCode {
			get { return statusCode; }
			set { statusCode = value; }
		}

		#endregion // Properties

		[MonoTODO]
		public override void GetObjectData (SerializationInfo info, StreamingContext context)
		{
		}

		[MonoTODO]
		void ISerializable.GetObjectData (SerializationInfo info, StreamingContext context)
		{
		}
	}
}

#endif // NET_2_0
