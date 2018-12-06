using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("000208D7-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface Sheets : IEnumerable
	{
		[DispId(170)]
		object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(170)]
			[return: MarshalAs(UnmanagedType.IDispatch)]
			get;
		}

		[DispId(0)]
		object this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.IDispatch)]
			get;
		}

		void _VtblGap1_3();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(4)]
		[DispId(181)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Add([In] [MarshalAs(UnmanagedType.Struct)] object Before = null, [In] [MarshalAs(UnmanagedType.Struct)] object After = null, [In] [MarshalAs(UnmanagedType.Struct)] object Count = null, [In] [MarshalAs(UnmanagedType.Struct)] object Type = null);

		void _VtblGap2_4();

		void _VtblGap3_9();
	}
}
