## Themer
> A **WinForm** framework to style your background design with various **blur/glass** effects.

# Themes
Take a look at **background** themes you can apply with **Themer**.

<details>
	<summary><b>Video for All</b></summary>
	
<br>

https://user-images.githubusercontent.com/85416153/170999867-67a69405-e232-4574-92b9-0d2e8fc8de14.mp4
	
</details>

<details>
<summary>Acrylic</summary>

<br>

[![Acrylic](https://media.discordapp.net/attachments/977582992014856273/980579146075893810/unknown.png)](https://media.discordapp.net/attachments/977582992014856273/980579146075893810/unknown.png)

</details>

<details>
<summary>Aero Glass</summary>

<br>

[![Aero Glass](https://media.discordapp.net/attachments/977582992014856273/980578913187156008/unknown.png)](https://media.discordapp.net/attachments/977582992014856273/980578913187156008/unknown.png)

</details>

<details>
<summary>Transparent</summary>

<br>

[![Transparent](https://media.discordapp.net/attachments/977582992014856273/980580156945100800/unknown.png)](https://media.discordapp.net/attachments/977582992014856273/980580156945100800/unknown.png)

</details>


### Applying to your Form
> Grab [release](https://github.com/arshx86/Themer/releases) build, add **DLL** to your project.

```csharp
private ThemerApplier _themer;

protected override void OnLoad(EventArgs e)
{
	_themer = new ThemerApplier(this.Handle); // create new instance
	_themer.Apply(Themes.Acrylic); // apply theme
	_themer.Apply(Themes.Disabled); // remove theme
}

```
Note: you can **change**/**delete** this theme any time you want. But before setting first time make sure you're setting in the **OnLoad** or **OnPaint** events of the form. Don't try to inject in constructor. 
You should have the **form handle** of form you want to **theme** it. 

## Multiple Forms
> **Themer** supports more than one form, you can inject like above, with **handle** of form.

# How?
> We using [Desktop Window Manager](https://docs.microsoft.com/en-us/windows/win32/dwm/reference) to interact with **form's window**. We don't use **pen** or **graphics** to brush form's window. With native ways, **WindowCompositionAttributeData** attribute are helps to interact and getting **in** to window. Brushing made with **AccentPolicy**.

### Notes
> The **background** effect of **aero glass - acrylic** will be changed dynamically when you change **Back Color** of the form.
> **Themer** won't effect your **form** components. It just interacts with **window**, so you don't need to do anything.

### Contributing
> Feel free to add new themes (despite this is the all themes as far as i know) and creating **PR's**. 

