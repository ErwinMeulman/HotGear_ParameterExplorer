using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("000208DA-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _Workbook
	{
		[DispId(485)]
		Sheets Sheets
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(485)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(494)]
		Sheets Worksheets
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(494)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		void _VtblGap1_20();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(3)]
		[DispId(277)]
		void Close([In] [MarshalAs(UnmanagedType.Struct)] object SaveChanges = null, [In] [MarshalAs(UnmanagedType.Struct)] object Filename = null, [In] [MarshalAs(UnmanagedType.Struct)] object RouteWorkbook = null);

		void _VtblGap2_84();

		void _VtblGap3_18();

		void _VtblGap4_40();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1925)]
		[LCIDConversion(12)]
		void SaveAs([In] [MarshalAs(UnmanagedType.Struct)] object Filename = null, [In] [MarshalAs(UnmanagedType.Struct)] object FileFormat = null, [In] [MarshalAs(UnmanagedType.Struct)] object Password = null, [In] [MarshalAs(UnmanagedType.Struct)] object WriteResPassword = null, [In] [MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended = null, [In] [MarshalAs(UnmanagedType.Struct)] object CreateBackup = null, [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange, [In] [MarshalAs(UnmanagedType.Struct)] object ConflictResolution = null, [In] [MarshalAs(UnmanagedType.Struct)] object AddToMru = null, [In] [MarshalAs(UnmanagedType.Struct)] object TextCodepage = null, [In] [MarshalAs(UnmanagedType.Struct)] object TextVisualLayout = null, [In] [MarshalAs(UnmanagedType.Struct)] object Local = null);
	}
}
