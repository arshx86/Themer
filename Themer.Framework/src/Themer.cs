using Themer.Models;

namespace Themer;

/// <summary>
///     A class to set DWM effects to current window.
/// </summary>
public class ThemerApplier
{
    private readonly IntPtr _handle;

    /// <summary> Adjustment level of the effect. The larger the number, the more effective of the style. </summary>
    /// ///
    private readonly uint adjustmentLevel = 20;

    /// <summary> Color of the effect brush. </summary>
    /// ///
    private readonly uint backgroundColor = 0x990000; // Default: Dark

    /// <summary>
    ///     Initializes <b>Themer</b> to being used.
    /// </summary>
    /// <param name="handle">
    ///     Handle of the form.
    ///     <br>
    ///         <b>Not handle of process, handle of the form.</b>
    ///     </br>
    /// </param>
    /// <param name="adjustmentLevelA">The effectivesness of the style.</param>
    /// <param name="_backgroundColorA">Color of the style.</param>
    public ThemerApplier(IntPtr handle, uint? adjustmentLevelA = null, uint? _backgroundColorA = null)
    {
        // todo: add checks
        _handle = handle;
        if (adjustmentLevelA is not null) adjustmentLevel = adjustmentLevelA.Value;
        if (_backgroundColorA is not null) backgroundColor = _backgroundColorA.Value;
    }

    /// <summary>
    ///     Initializes <b>Themer</b> to being used.
    /// </summary>
    /// <param name="handle">
    ///     Handle of the form.
    ///     <br>
    ///         <b>Not handle of process, handle of the form.</b>
    ///     </br>
    /// </param>
    public ThemerApplier(IntPtr handle)
    {
        _handle = handle;
    }

    #region Apply

    /// <summary>
    ///     Apply a <b>style</b> to window.
    /// </summary>
    /// <param name="theme">Style to be applied.</param>
    public void Set(Theme theme)
    {
        ResetDWM();
        switch (theme)
        {
            case Theme.Acrylic:
                Acrylic();
                break;
            case Theme.AeroGlass:
                AeroGlass();
                break;
            case Theme.Transparent:
                Transparent();
                break;
            case Theme.None:
                Clear();
                break;
        }
    }

    /// <summary>
    ///     Acrylic is a translucent texture, like a blur but vision is low.
    /// </summary>
    private void Acrylic()
    {
        var accent = new AccentPolicy
        {
            AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
            GradientColor = (adjustmentLevel << 0x18) | (backgroundColor & 0xFFFFFF)
        };
        var accentStructSize = Marshal.SizeOf(accent);
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
        var data = new WindowCompositionAttributeData
        {
            Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
            SizeOfData = accentStructSize,
            Data = accentPtr
        };
        SetWindowCompositionAttribute(_handle, ref data);
        Marshal.FreeHGlobal(accentPtr);
    }


    /// <summary>
    ///     Applies a glass effect, background is blurred.
    /// </summary>
    private void AeroGlass()
    {
        AccentPolicy accentPolicy = new AccentPolicy
        {
            AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND,
            AccentFlags = 0,
            GradientColor = 0,
            AnimationId = 0
        };
        WindowCompositionAttributeData data = new WindowCompositionAttributeData
        {
            Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
        };
        int accentSize = Marshal.SizeOf(accentPolicy);
        IntPtr accentPtr = Marshal.AllocHGlobal(accentSize);
        Marshal.StructureToPtr(accentPolicy, accentPtr, false);
        data.Data = accentPtr;
        data.SizeOfData = accentSize;
        int result = SetWindowCompositionAttribute(_handle, ref data);
        Marshal.FreeHGlobal(accentPtr);
    }

    /// <summary>
    ///     Applies a full transparent theme.
    /// </summary>
    private void Transparent()
    {
        var accent = new AccentPolicy
        {
            AccentState = AccentState.ACCENT_ENABLE_TRANSPARENTGRADIENT,
            GradientColor = (adjustmentLevel << 0x18) | (backgroundColor & 0xFFFFFF)
        };
        var accentStructSize = Marshal.SizeOf(accent);
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
        var data = new WindowCompositionAttributeData
        {
            Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
            SizeOfData = accentStructSize,
            Data = accentPtr
        };
        SetWindowCompositionAttribute(_handle, ref data);
        Marshal.FreeHGlobal(accentPtr);
    }

    /// <summary>
    ///     Clears all underlayed styles.
    /// </summary>
    private void Clear()
    {
        var accent = new AccentPolicy
        {
            AccentState = AccentState.ACCENT_DISABLED
        };
        var accentStructSize = Marshal.SizeOf(accent);
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
        var data = new WindowCompositionAttributeData
        {
            Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
            SizeOfData = accentStructSize,
            Data = accentPtr
        };
        SetWindowCompositionAttribute(_handle, ref data);
        Marshal.FreeHGlobal(accentPtr);
    }

    #region Helpers

    private void ResetDWM()
    {
        MARGINS mrg = new MARGINS
        {
            Bottom = 0,
            Left = 0,
            Right = 0,
            Top = 0
        };
        DwmExtendFrameIntoClientArea(_handle, ref mrg);
    }

    #endregion

    #endregion

    #region Imports

    [DllImport("user32.dll")]
    internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

    [DllImport("DwmApi.dll")]
    internal static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

    #endregion
}