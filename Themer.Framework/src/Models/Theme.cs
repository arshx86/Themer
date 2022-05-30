namespace Themer.Framework;

[EditorBrowsable(EditorBrowsableState.Always)]
public enum Theme
{
	/// <summary>
	///     Acrylic is a kind of blur theme. But vision is low when compared to blur effect. Good when to create
	///     motion-light effects.
	/// </summary>
	/// ///
	Acrylic = 0,

	/// <summary>
	///     Aero glass is translucent style. You can still see the background but might can't understand what the behind
	///     is it.
	/// </summary>
	/// ///
	AeroGlass = 1,

	/// <summary> Classic fully transparent theme. </summary>
	/// ///
	Transparent = 2,

	/// <summary> Indicates activated style should be removed and reverted to default state. </summary>
	/// ///
	None = 3
}