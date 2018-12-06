using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("00020893-0000-0000-C000-000000000046")]
	[InterfaceType(2)]
	[TypeIdentifier]
	public interface Window
	{
		[DispId(650)]
		bool FreezePanes
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(650)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(650)]
			set;
		}

		[DispId(660)]
		int SplitRow
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(660)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(660)]
			set;
		}

		void _VtblGap1_33();

		void _VtblGap2_31();
	}
}
