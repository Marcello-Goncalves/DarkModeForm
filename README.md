# DarkModeForm

This is a Simple Exemple of how a Dark Mode Can be Implemented to a Desktop Program Created With [Microsoft's](https://github.com/microsoft) [WinForms](https://github.com/dotnet/winforms) Using the [DotNet Framework 4.8.1](https://github.com/dotnet)  and the [C#](https://github.com/dotnet/csharplang) Programming Language.

<br>

The Program Consists of a Simple **Form** with 3 *RadioButton* Controls:
  - ***Light*** &emsp;- Applies *Windows'* **Light Theme's** *BackColor* And *ForeColor* (#FFFFFF & #000000 Respectively).
  - ***Dark***  &emsp;- Applies *Windows'* **Dark Theme's** *BackColor* And *ForeColor*  (#202020 & #FFFFFF Respectively).
  But Also Calls The [DarkTitleBar Class](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/DarkTitleBar.cs) (More on it Below).
  - ***System***&ensp;- Calls The *Status( )* Method From the [SystemTheme Class](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/DarkTitleBar.cs) in order to Identify the OS's Use of a Light or Dark Theme.

<br>

  ![Light](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/dark_mode_form_light.jpg "Light")

  ![Dark](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/dark_mode_form_dark.jpg "Dark")


<br>

## The *DarkTitleBar* Class

The [DarkTitleBar Class](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/DarkTitleBar.cs) Applies a Black Color (***F000000***) To the TitleBar (*e.g.* the Dark Mode of Apps like [PowerShell](https://github.com/PowerShell/PowerShell) or [PowerToys](https://github.com/microsoft/PowerToys)).

The Credit of This Class' Code Development Goes to [Jonas Kohl](https://github.com/jonaskohl) as Displayed on his [***Answer***](https://stackoverflow.com/a/62811758) to [This Thread](https://stackoverflow.com/questions/57124243/winforms-dark-title-bar-on-windows-10) on [StackOverflow](https://stackoverflow.com/)
and can be Further Observed on His [DarkModeEnabler](https://github.com/jonaskohl/DarkModeEnabler/blob/main/MainForm.cs) **Repository**.

But also To [Jonas](https://stackoverflow.com/users/5968320/jonas) for [Adapting it to a Class](https://stackoverflow.com/a/72623340/20433559) and Reinforcing the Need For an [AppManifest](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/app.manifest) to be Added To The Solution and The Line of Code ***Referring to the Operating System*** (in This Repo's Case Windows 10 and 11) to be ***Uncommented***.

This is Being Targeted to ***Windows 10 and Newer*** Systems Since Older Versions Are No Longer Maintained.

<br>

## The *SystemTheme* Class

The [SystemTheme class](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/DarkTitleBar.cs) Retrives The ***AppsUseLightTheme*** DWORD From The **Registry** in order to Detect the OS's Current Theme and Apply The Respective Changes to The Application´s **Form**.

This Class Must Be Also Credited To Another Fellow Developer, [Rena821](https://github.com/rena821) as seen in His [***Answer***](https://stackoverflow.com/a/72172926)
to [This Thread](https://stackoverflow.com/questions/51334674/how-to-detect-windows-10-light-dark-mode-in-win32-application) on [StackOverflow](https://stackoverflow.com/).

<br>

## Credits

Besides The Due Accreditation to [Jonas Kohl](https://github.com/jonaskohl), [Jonas](https://stackoverflow.com/users/5968320/jonas) and [Rena821](https://github.com/rena821)'s Work, I also Used A [Modified Version](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/Resources/bulb2.png) of [This Icon](https://www.flaticon.com/free-icon/idea_436303?term=light%20bulb&page=1&position=16&page=1&position=16&related_id=436303&origin=tag) [Designed by Freepik Company, S.L from Flaticon](https://media.flaticon.com/license/license.pdf) as the **Main Icon** of the Application.

![Bulb](https://github.com/Marcello-Goncalves/DarkModeForm/blob/master/DarkModeForm/Resources/bulb2.png "Bulb")

<br>

## Closing Thoughts

This is Obviously not an Elaborate Application but rather a Simple Implementation of a Feature that is Common and Convenient on more Modern/Complex UI Frameworks, Applied to Windows Forms.

This Repo is intended To make it Easier and Clearer to apply this feature in Other *WinForms* Projects and Serve As Documentation.

<br>
