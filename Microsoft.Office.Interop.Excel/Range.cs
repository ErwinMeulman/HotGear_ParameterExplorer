using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("00020846-0000-0000-C000-000000000046")]
	[InterfaceType(2)]
	[TypeIdentifier]
	public interface Range
	{
		[DispId(435)]
		Borders Borders
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(435)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(238)]
		Range Cells
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(238)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(241)]
		Range Columns
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(241)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(118)]
		int Count
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(118)]
			get;
		}

		[DispId(0)]
		object this[[In] [MarshalAs(UnmanagedType.Struct)] object RowIndex = null, [In] [MarshalAs(UnmanagedType.Struct)] object ColumnIndex = null]
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(0)]
			[param: In]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}

		[DispId(246)]
		Range EntireColumn
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(246)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(146)]
		Font Font
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(146)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(129)]
		Interior Interior
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(129)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(269)]
		object Locked
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(269)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(269)]
			[param: In]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}

		[DispId(193)]
		object NumberFormat
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(193)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(193)]
			[param: In]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}

		[DispId(258)]
		Range Rows
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(258)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(138)]
		object Text
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(138)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
		}

		[DispId(1388)]
		object Value2
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(1388)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(1388)]
			[param: In]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}

		void _VtblGap1_14();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(793)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object AutoFilter([In] [MarshalAs(UnmanagedType.Struct)] object Field = null, [In] [MarshalAs(UnmanagedType.Struct)] object Criteria1 = null, [In] XlAutoFilterOperator Operator = XlAutoFilterOperator.xlAnd, [In] [MarshalAs(UnmanagedType.Struct)] object Criteria2 = null, [In] [MarshalAs(UnmanagedType.Struct)] object VisibleDropDown = null);

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(237)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object AutoFit();

		void _VtblGap2_3();

		void _VtblGap3_1();

		void _VtblGap4_9();

		void _VtblGap5_6();

		void _VtblGap6_6();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(117)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Delete([In] [MarshalAs(UnmanagedType.Struct)] object Shift = null);

		void _VtblGap7_6();

		void _VtblGap8_8();

		void _VtblGap9_28();

		void _VtblGap10_7();

		void _VtblGap11_11();

		void _VtblGap12_28();

		void _VtblGap13_1();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(235)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Select();

		void _VtblGap14_18();

		void _VtblGap15_10();
	}
}
