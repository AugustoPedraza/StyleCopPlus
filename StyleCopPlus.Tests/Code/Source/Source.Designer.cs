﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StyleCopPlus.Tests.Code {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Source {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Source() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StyleCopPlus.Tests.Code.Source.Source", typeof(Source).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		private int m_field = 5;
        ///
        ///		public Class1()
        ///		{
        ///			int a = 10;
        ///		}
        ///
        ///		public Class1(
        ///			int x,
        ///			int y)
        ///			: this() {
        ///			int a = 10;
        ///			int b = 20;
        ///			int c = 30; }
        ///
        ///		~Class1() { int a = 10; }
        ///
        ///		public int Property
        ///		{
        ///			get { int a = 10;  return 0; }
        ///
        ///			set
        ///			{
        ///
        ///				int a = 10;
        ///				m_field = value;
        ///
        ///			}
        ///		}
        ///
        ///		public int this[int x]
        ///		{
        ///			get {
        ///				return 0; }
        ///
        ///			set {
        ///				m_field = value; }
        ///		}
        ///
        ///		 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ElementsSize {
            get {
                return ResourceManager.GetString("ElementsSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		public void Method1(
        ///			int x,
        ///			int y)
        ///		{
        ///			int a = 10;
        ///			int b = 10
        ///				+ (20 + 30
        ///					- 40);
        ///		}
        ///	}
        ///}
        ///.
        /// </summary>
        internal static string GetByLine {
            get {
                return ResourceManager.GetString("GetByLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.Threading;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		private int m_field = 5;
        ///
        ///		public Class1()
        ///		{
        ///			try
        ///			{
        ///lab1:			m_field = 6;
        ///			}
        ///			catch (Exception ex)
        ///			{
        ///				throw;
        ///			}
        ///
        ///			for (int i = 0; i &lt; 10; i++)
        ///			{
        ///lab2:			m_field = 6;
        ///			}
        ///
        ///			foreach (string s in new[] { &quot;1&quot;, &quot;2&quot; })
        ///			{
        ///lab3:			m_field = 6;
        ///			}
        ///
        ///			using (MemoryStream ms = new MemoryStream())
        ///			{
        ///lab4:			m_field = 6;
        ///			}
        ///
        ///			goto lab [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Labels {
            get {
                return ResourceManager.GetString("Labels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.Threading;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		private int m_field = 5;
        ///
        ///		public Class1()
        ///		{
        ///			try
        ///			{
        ///				int a1, a2 = 10, a3 = 20;
        ///				const int b1 = 30, b2 = 40;
        ///
        ///				m_field = 6;
        ///			}
        ///			catch (OutOfMemoryException ex1)
        ///			{
        ///				throw;
        ///			}
        ///			catch (Exception ex2)
        ///			{
        ///				throw;
        ///			}
        ///
        ///			for (int
        ///				i1,
        ///				i2 = 0,
        ///				i3 = 1;
        ///				i2 &lt; 10;
        ///				i2++)
        ///			for (int j1, j2 = 0,
        ///				j3 = 1;
        ///				j2 &lt; 10 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LocalDeclarations {
            get {
                return ResourceManager.GetString("LocalDeclarations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Threading;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public delegate bool Delegate1(int x, int y);
        ///
        ///	public class Class1
        ///	{
        ///		public Class1(
        ///			IEnumerable&lt;int&gt; list,
        ///			IComparable&lt;string&gt; comparer)
        ///		{
        ///			Delegate1 del = delegate(
        ///				int a,
        ///				int b)
        ///				{ return a == b; };
        ///
        ///			Delegate1 lambda = (
        ///				a,
        ///				b) =&gt; a == b;
        ///
        ///			new Delegate1(delegate(
        ///				int a,
        ///				int b)
        ///				{ return a == b; }).GetHashCode();
        ///
        ///			new Delega [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Parameters {
            get {
                return ResourceManager.GetString("Parameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		public void FalseMethodIsNotPrivate(object sender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		private void FalseFirstArgumentIsNotObject(NotObject sender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		private void FalseFirstArgumentHasWrongName(object notSender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		private void FalseSecondArgumentIsNotEventArgs(object sender, EventArgsWrong e)
        ///		{
        ///		}
        ///
        ///		private void FalseSecondArgumentHasWrongName(object sender, EventArgs notE)
        ///		{
        /// </summary>
        internal static string PrivateEventHandlers {
            get {
                return ResourceManager.GetString("PrivateEventHandlers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		private void FalseMethodIsNotProtected(object sender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		protected void FalseFirstArgumentIsNotObject(NotObject sender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		protected void FalseFirstArgumentHasWrongName(object notSender, EventArgs e)
        ///		{
        ///		}
        ///
        ///		protected void FalseSecondArgumentIsNotEventArgs(object sender, EventArgsWrong e)
        ///		{
        ///		}
        ///
        ///		protected void FalseSecondArgumentHasWrongName(object sender, EventArgs  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProtectedEventHandlers {
            get {
                return ResourceManager.GetString("ProtectedEventHandlers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public class Class1
        ///	{
        ///		public void FalseUsualMethod()
        ///		{
        ///		}
        ///
        ///		[SomeAttribute]
        ///		public void FalseUnkownAttribute()
        ///		{
        ///		}
        ///
        ///		#region MSTest methods
        ///
        ///		[TestMethod]
        ///		public void TrueMSTestMethod()
        ///		{
        ///		}
        ///
        ///		[TestMethod()]
        ///		public void TrueMSTestMethodParenthesis()
        ///		{
        ///		}
        ///
        ///		[TestMethod(&quot;A&quot;)]
        ///		public void TrueMSTestMethodParameter()
        ///		{
        ///		}
        ///
        ///		[TestMethod(&quot;A&quot;, &quot;B&quot; = 2)]
        ///		public void TrueMSTestMethodParameters()
        ///		{
        ///	 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestMethods {
            get {
                return ResourceManager.GetString("TestMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Collections.Generic;
        ///
        ///namespace StyleCopPlus.Tests
        ///{
        ///	public delegate TOutput Delegate1&lt;
        ///		TInput,
        ///		TOutput&gt;(TInput args)
        ///		where TInput : IEnumerable&lt;int&gt;
        ///		where TOutput : IEnumerable&lt;int&gt;;
        ///
        ///	public delegate TOutput Delegate2&lt;
        ///		in TInput,
        ///		out TOutput&gt;(TInput args)
        ///		where TInput : IEnumerable&lt;int&gt;
        ///		where TOutput : IEnumerable&lt;int&gt;;
        ///
        ///	public delegate bool Delegate3&lt;in TInput&gt;(TInput args)
        ///		where TInput : IEnumerable&lt;byte&gt;;
        ///
        ///	public delegate TOutput Delegate4&lt;out TOutpu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TypeParameters {
            get {
                return ResourceManager.GetString("TypeParameters", resourceCulture);
            }
        }
    }
}