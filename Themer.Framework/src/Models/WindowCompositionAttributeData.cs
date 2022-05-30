namespace Themer.Framework.Models;

[EditorBrowsable(EditorBrowsableState.Never)]
[StructLayout(LayoutKind.Sequential)]
internal struct WindowCompositionAttributeData
{
	public WindowCompositionAttribute Attribute;
	public IntPtr Data;
	public int SizeOfData;
}