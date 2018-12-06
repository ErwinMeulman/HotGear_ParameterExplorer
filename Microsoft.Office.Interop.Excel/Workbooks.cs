using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[DefaultMember("_Default")]
	[Guid("000208DB-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface Workbooks : IEnumerable
	{
		void _VtblGap1_3();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(181)]
		[LCIDConversion(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Workbook Add([In] [MarshalAs(UnmanagedType.Struct)] object Template = null);

		void _VtblGap2_8();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1923)]
		[LCIDConversion(15)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Workbook Open([In] [MarshalAs(UnmanagedType.BStr)] string Filename, [In] [MarshalAs(UnmanagedType.Struct)] object UpdateLinks = null, [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnly = null, [In] [MarshalAs(UnmanagedType.Struct)] object Format = null, [In] [MarshalAs(UnmanagedType.Struct)] object Password = null, [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword = null, [In] [MarshalAs(UnmanagedType.Struct)] object IgnoreReadOnlyRecommended = null, [In] [MarshalAs(UnmanagedType.Struct)] object Origin = null, [In] [MarshalAs(UnmanagedType.Struct)] object Delimiter = null, [In] [MarshalAs(UnmanagedType.Struct)] object Editable = null, [In] [MarshalAs(UnmanagedType.Struct)] object Notify = null, [In] [MarshalAs(UnmanagedType.Struct)] object Converter = null, [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru = null, [In] [MarshalAs(UnmanagedType.Struct)] object Local = null, [In] [MarshalAs(UnmanagedType.Struct)] object CorruptLoad = null);
	}
}
