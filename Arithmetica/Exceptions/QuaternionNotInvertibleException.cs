﻿#region Using directives

using System;
using System.Runtime.Serialization;

#endregion

namespace Arithmetica.Exceptions
{
	/// <summary>
	/// Base class for all exceptions thrown by Arithmetica.
	/// </summary>
	[Serializable]
	public class QuaternionNotInvertibleException : MathException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuaternionNotInvertibleException"/> class.
		/// </summary>
		public QuaternionNotInvertibleException() : base() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="QuaternionNotInvertibleException"/> class with a specified error message.
		/// </summary>
		/// <param name="message">A message that describes the error.</param>
		public QuaternionNotInvertibleException(string message) : base(message) { }
		/// <summary>
		/// Initializes a new instance of the <see cref="QuaternionNotInvertibleException"/> class 
		/// with a specified error message and a reference to the inner exception that is 
		/// the cause of this exception.
		/// </summary>
		/// <param name="message">A message that describes the error.</param>
		/// <param name="inner">
		/// The exception that is the cause of the current exception. 
		/// If the innerException parameter is not a null reference, the current exception is raised 
		/// in a catch block that handles the inner exception.
		/// </param>
		public QuaternionNotInvertibleException(string message, Exception inner) : base(message, inner) { }
		/// <summary>
		/// Initializes a new instance of the <see cref="QuaternionNotInvertibleException"/> class with serialized data.
		/// </summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		protected QuaternionNotInvertibleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
