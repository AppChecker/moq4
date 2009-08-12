﻿//Copyright (c) 2007. Clarius Consulting, Manas Technology Solutions, InSTEDD
//http://code.google.com/p/moq/
//All rights reserved.

//Redistribution and use in source and binary forms, 
//with or without modification, are permitted provided 
//that the following conditions are met:

//    * Redistributions of source code must retain the 
//    above copyright notice, this list of conditions and 
//    the following disclaimer.

//    * Redistributions in binary form must reproduce 
//    the above copyright notice, this list of conditions 
//    and the following disclaimer in the documentation 
//    and/or other materials provided with the distribution.

//    * Neither the name of Clarius Consulting, Manas Technology Solutions or InSTEDD nor the 
//    names of its contributors may be used to endorse 
//    or promote products derived from this software 
//    without specific prior written permission.

//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
//CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
//INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
//MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
//DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
//CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
//SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
//BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
//SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
//INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
//WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
//NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
//OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
//SUCH DAMAGE.

//[This is the BSD license, see
// http://www.opensource.org/licenses/bsd-license.php]

using System;
using System.ComponentModel;
using Moq.Language.Flow;

namespace Moq.Language
{
	/// <summary>
	/// Defines the <c>Callback</c> verb and overloads.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ICallback : IHideObjectMembers
	{
		/// <summary>
		/// Specifies a callback to invoke when the method is called.
		/// </summary>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// The following example specifies a callback to set a boolean 
		/// value that can be used later:
		/// <code>
		/// bool called = false;
		/// mock.Setup(x => x.Execute())
		///     .Callback(() => called = true);
		/// </code>
		/// </example>
		ICallbackResult Callback(Action action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T">Argument type of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation argument value. 
		/// <para>
		/// Notice how the specific string argument is retrieved by simply declaring 
		/// it as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(It.IsAny&lt;string&gt;()))
		///     .Callback((string command) => Console.WriteLine(command));
		/// </code>
		/// </example>
		ICallbackResult Callback<T>(Action<T> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;()))
		///     .Callback((string arg1, string arg2) => Console.WriteLine(arg1 + arg2));
		/// </code>
		/// </example>
		ICallbackResult Callback<T1, T2>(Action<T1, T2> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">Type of the third argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;int&gt;()))
		///     .Callback((string arg1, string arg2, int arg3) => Console.WriteLine(arg1 + arg2 + arg3));
		/// </code>
		/// </example>
		ICallbackResult Callback<T1, T2, T3>(Action<T1, T2, T3> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">Type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">Type of the fourth argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;int&gt;(),
		///                      It.IsAny&lt;bool&gt;()))
		///     .Callback((string arg1, string arg2, int arg3, bool arg4) => Console.WriteLine(arg1 + arg2 + arg3 + arg4));
		/// </code>
		/// </example>
		ICallbackResult Callback<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action);
	}

	/// <summary>
	/// Defines the <c>Callback</c> verb and overloads for callbacks on 
	/// setups that return a value.
	/// </summary>
	/// <typeparam name="TMock">Mocked type.</typeparam>
	/// <typeparam name="TResult">Type of the return value of the setup.</typeparam>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ICallback<TMock, TResult> : IHideObjectMembers
		where TMock : class
	{
		/// <summary>
		/// Specifies a callback to invoke when the method is called.
		/// </summary>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// The following example specifies a callback to set a boolean 
		/// value that can be used later:
		/// <code>
		/// bool called = false;
		/// mock.Setup(x => x.Execute())
		///     .Callback(() => called = true)
		///     .Returns(true);
		/// </code>
		/// Note that in the case of value-returning methods, after the <c>Callback</c> 
		/// call you can still specify the return value.
		/// </example>
		IReturnsThrows<TMock, TResult> Callback(Action action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T">Type of the argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation argument value. 
		/// <para>
		/// Notice how the specific string argument is retrieved by simply declaring 
		/// it as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(It.IsAny&lt;string&gt;()))
		///     .Callback((string command) => Console.WriteLine(command))
		///     .Returns(true);
		/// </code>
		/// </example>
		IReturnsThrows<TMock, TResult> Callback<T>(Action<T> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;()))
		///     .Callback((string arg1, string arg2) => Console.WriteLine(arg1 + arg2))
		///     .Returns(true);
		/// </code>
		/// </example>
		IReturnsThrows<TMock, TResult> Callback<T1, T2>(Action<T1, T2> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">Type of the third argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;int&gt;()))
		///     .Callback((string arg1, string arg2, int arg3) => Console.WriteLine(arg1 + arg2 + arg3))
		///     .Returns(true);
		/// </code>
		/// </example>
		IReturnsThrows<TMock, TResult> Callback<T1, T2, T3>(Action<T1, T2, T3> action);
		
		/// <summary>
		/// Specifies a callback to invoke when the method is called that receives the original
		/// arguments.
		/// </summary>
		/// <typeparam name="T1">Type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">Type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">Type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">Type of the fourth argument of the invoked method.</typeparam>
		/// <param name="action">Callback method to invoke.</param>
		/// <example>
		/// Invokes the given callback with the concrete invocation arguments values. 
		/// <para>
		/// Notice how the specific arguments are retrieved by simply declaring 
		/// them as part of the lambda expression for the callback:
		/// </para>
		/// <code>
		/// mock.Setup(x => x.Execute(
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;string&gt;(), 
		///                      It.IsAny&lt;int&gt;(),
		///                      It.IsAny&lt;bool&gt;()))
		///     .Callback((string arg1, string arg2, int arg3, bool arg4) => Console.WriteLine(arg1 + arg2 + arg3 + arg4))
		///     .Returns(true);
		/// </code>
		/// </example>
		IReturnsThrows<TMock, TResult> Callback<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action);
	}
}
