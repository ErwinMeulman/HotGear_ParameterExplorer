using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	[ComImport]
	[CompilerGenerated]
	[Guid("00020870-0000-0000-C000-000000000046")]
	[InterfaceType(2)]
	[TypeIdentifier]
	public interface Interior
	{
		[DispId(99)]
		object Color
		{
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(99)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[DispId(99)]
			[param: In]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}

		void _VtblGap1_3();
	}
}
