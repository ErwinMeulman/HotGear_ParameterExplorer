using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[DefaultMember("_Default")]
	[Guid("000208D5-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _Application
	{
		[DispId(759)]
		Window ActiveWindow
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(759)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(572)]
		Workbooks Workbooks
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(572)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(0)]
		string _Default
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(558)]
		bool Visible
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(558)]
			[LCIDConversion(0)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[LCIDConversion(0)]
			[DispId(558)]
			[param: In]
			set;
		}

		void _VtblGap1_10();

		void _VtblGap2_34();

		void _VtblGap3_60();

		void _VtblGap4_168();
	}
}
