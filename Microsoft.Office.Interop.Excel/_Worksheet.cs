using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("000208D8-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _Worksheet
	{
		[DispId(148)]
		Application Application
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(148)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(110)]
		string Name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(110)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(110)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(238)]
		Range Cells
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(238)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(241)]
		Range Columns
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(241)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(197)]
		Range Range
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(197)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(412)]
		Range UsedRange
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(412)]
			[LCIDConversion(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		void _VtblGap1_10();

		void _VtblGap2_32();

		void _VtblGap3_5();

		void _VtblGap4_41();

		void _VtblGap5_16();

		void _VtblGap6_23();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1928)]
		[LCIDConversion(7)]
		void PasteSpecial([In] [MarshalAs(UnmanagedType.Struct)] object Format = null, [In] [MarshalAs(UnmanagedType.Struct)] object Link = null, [In] [MarshalAs(UnmanagedType.Struct)] object DisplayAsIcon = null, [In] [MarshalAs(UnmanagedType.Struct)] object IconFileName = null, [In] [MarshalAs(UnmanagedType.Struct)] object IconIndex = null, [In] [MarshalAs(UnmanagedType.Struct)] object IconLabel = null, [In] [MarshalAs(UnmanagedType.Struct)] object NoHTMLFormatting = null);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2029)]
		void Protect([In] [MarshalAs(UnmanagedType.Struct)] object Password = null, [In] [MarshalAs(UnmanagedType.Struct)] object DrawingObjects = null, [In] [MarshalAs(UnmanagedType.Struct)] object Contents = null, [In] [MarshalAs(UnmanagedType.Struct)] object Scenarios = null, [In] [MarshalAs(UnmanagedType.Struct)] object UserInterfaceOnly = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingCells = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingColumns = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowFormattingRows = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingColumns = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingRows = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowInsertingHyperlinks = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowDeletingColumns = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowDeletingRows = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowSorting = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowFiltering = null, [In] [MarshalAs(UnmanagedType.Struct)] object AllowUsingPivotTables = null);
	}
}
