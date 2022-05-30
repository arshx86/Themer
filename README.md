## Themer
> A **WinForm** framework to style your background design with various **blur/glass** effects.

https://user-images.githubusercontent.com/85416153/170999867-67a69405-e232-4574-92b9-0d2e8fc8de14.mp4

### Themes
Take a look at **background** themes you can apply with **Themer**.

### Acrylic
> Classic blur effect, but casts the lights and colors more.
![](https://media.discordapp.net/attachments/977582992014856273/980579146075893810/unknown.png)
### Aero Glass
> A glass effect like blur. Color can be changed with **Forms background color**.
![](https://media.discordapp.net/attachments/977582992014856273/980578913187156008/unknown.png)
### Transparent
> Full transparent window. You can see the background purely.
![](https://media.discordapp.net/attachments/977582992014856273/980580156945100800/unknown.png)

### Injecting to your form
> Themer is **dll library**, so it's static and not a component or something like this. It makes all things remotely.
> Add the **DLL** to project that you downloaded from **releases**. Import using state of `Themer.Framework`. DLL is static and you don't need to import anything else except that.
> This example will inject **acrylic** style into your form. Just pickup the theme you want!
```csharp
private Framework.Themer _themer;

protected override void OnLoad(EventArgs e)
{
	_themer = new Themer.Framework.Themer(this.Handle); // handle of form
        _themer.Set(Themes.Acrylic);
        // base.OnLoad(e);
}
```
Note: you can **change**/**delete** this theme any time you want. But before setting first time make sure you're setting in the **OnLoad** or **OnPaint** events of the form. Don't try to inject in constructor. 
You should have the **form handle** of form you want to **theme** it. 

## Removing Theme
```csharp
_themer.Set(Themes.Disabled);
```
will remove the current theme and dispose from the **DMI**.

## Multiple Forms
> You can select which forms gonna be stylized, you just need to **handle** of the form that you want to stylize it.

# How?
> We using [Desktop Window Manager](https://docs.microsoft.com/en-us/windows/win32/dwm/reference) to interact with **form's window**. We don't use **pen** or **graphics** to brush form's window. With native ways, **WindowCompositionAttributeData** attribute are helps to interact and getting **in** to window. Brushing made with **AccentPolicy**.

### Notes
> The **background** effect of **aero glass - acrylic** will be changed dynamically when you change **Back Color** of the form.
> **Themer** won't effect your **form** components. It just interacts with **window**, so you don't need to do anything.

### Contributing
> Feel free to add new themes (despite this is the all themes as far as i know) and creating **PR's**. 

