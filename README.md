<img src="screenshots/icon.png" alt="icon" width="64px" >

[![Build status](https://ci.appveyor.com/api/projects/status/t28ovdlfdb1hmoys?svg=true)](https://ci.appveyor.com/project/tmt242001/plugin-glypher)

# Plugin.Glypher
This plugin extend support for font-glyphs (font-icons) in Xamarin.Forms applications.

# Usage

```XML
xmlns:fontAwesome5Free="clr-namespace:Plugin.Glypher.FontAwesome5Free;assembly=Plugin.Glypher.FontAwesome5Free"
xmlns:glypher="clr-namespace:Plugin.Glypher;assembly=Plugin.Glypher"

<Label glypher:FontGlyph.Glyph="{x:Static fontAwesome5Free:GlyphList.Fab_Bluetooth}"
       FontSize="Large"
       TextColor="CornflowerBlue" />
       
<Button glypher:FontGlyph.Glyph="{x:Static fontAwesome5Free:GlyphList.Fab_Bitcoin}"
        FontSize="Large"
        TextColor="IndianRed" />
```       

# Setup

- `Plugin.Glypher` [![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher/) Available on NuGet: https://www.nuget.org/packages/Plugin.Glypher

`Plugin.Glypher` is not required to be reference if using any other package.
- Install selected nuget(s) into any .NET Standard 2.0 projects required for your app. Do not install in platform-specific projects

# Plugin.Glypher.FontAwesome5Free

- Download Fonts from https://fontawesome.com/

## .NET Standard Projest

- Reference `Plugin.Glypher.FontAwesome5Free` [![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.FontAwesome5Free.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher.FontAwesome5Free/)

```csharp
public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GlyphRegister.Current.Init(typeof(GlyphList));

            MainPage = new NavigationPage(new MainPage());
        }
    }
```

## Android Project

- Add fonts to `Assets` folder, font names must be "Font Awesome 5 Brands-Regular-400.otf", "Font Awesome 5 Free-Regular-400.otf" and "Font Awesome 5 Free-Solid-900.otf"

## iOS Project

- Add fonts to `Resources` folder, font names must be "Font Awesome 5 Brands-Regular-400.otf", "Font Awesome 5 Free-Regular-400.otf" and "Font Awesome 5 Free-Solid-900.otf"

- Modify `Info.plist` by add below code.

```XML
<key>UIAppFonts</key>
<array>
  <string>Font Awesome 5 Brands-Regular-400.otf</string>
  <string>Font Awesome 5 Free-Regular-400.otf</string>
  <string>Font Awesome 5 Free-Solid-900.otf</string>
</array>
```

# Plugin.Glypher.FontAwesome5Pro

- Download Fonts from https://fontawesome.com/

## .NET Standard Projest

- Reference `Plugin.Glypher.FontAwesome5Pro` [![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.FontAwesome5Pro.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher.FontAwesome5Pro/)

```csharp
public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GlyphRegister.Current.Init(typeof(GlyphList));

            MainPage = new NavigationPage(new MainPage());
        }
    }
```

## Android Project

- Add fonts to `Assets` folder, font names must be "Font Awesome 5 Brands-Regular-400.otf", "Font Awesome 5 Pro-Light-300.otf", "Font Awesome 5 Pro-Regular-400.otf", "Font Awesome 5 Pro-Solid-900.otf"

## iOS Project

- Add fonts to `Resources` folder, font names must be "Font Awesome 5 Brands-Regular-400.otf", "Font Awesome 5 Pro-Light-300.otf", "Font Awesome 5 Pro-Regular-400.otf", "Font Awesome 5 Pro-Solid-900.otf"

- Modify `Info.plist` by add below code.

```XML
<key>UIAppFonts</key>
<array>
  <string>Font Awesome 5 Brands-Regular-400.otf</string>
  <string>Font Awesome 5 Pro-Light-300.otf</string>
  <string>Font Awesome 5 Pro-Regular-400.otf</string>
  <string>Font Awesome 5 Pro-Solid-900.otf</string>
</array>
```

# SourceLink Support

In Visual Studio, confirm that SourceLink is enabled. 
Also, Turn off "Just My Code" since, well, this isn't your code.

https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink

# Limitations

`Plugin.Glypher.FontAwesome5Pro`, `Plugin.Glypher.FontAwesome5Free` Only support iOS and Android for the moment. 

# Contributing

Contributions are welcome.  Feel free to file issues and pull requests on the repo and they'll be reviewed as time permits.

## Icon

Thank you for the Icon by Yannick Lung (https://www.iconfinder.com/icons/314770/document_font_icon)
