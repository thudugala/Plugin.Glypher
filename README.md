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

|Package|Wiki|Nuget|
| ------------------- | :-----------: | :------------------: | 
|`Plugin.Glypher.FontAwesome5Free`|[Font Awesome 5 Free](../../wiki/Font-Awesome-5-Free)|[![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.FontAwesome5Free.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher.FontAwesome5Free/)|
|`Plugin.Glypher.FontAwesome5Pro`|[Font Awesome 5 Pro](../../wiki/Font-Awesome-5-Pro)|[![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.FontAwesome5Pro.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher.FontAwesome5Pro/)|
|`Plugin.Glypher.WeatherIcons`|[Weather Icons](../../wiki/Weather-Icons)|[![NuGet](https://img.shields.io/nuget/v/Plugin.Glypher.WeatherIcons.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Glypher.WeatherIcons/)|

# SourceLink Support

In Visual Studio, confirm that SourceLink is enabled. 
Also, Turn off "Just My Code" since, well, this isn't your code.

https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink

# Limitations

`Plugin.Glypher.FontAwesome5Pro`, `Plugin.Glypher.FontAwesome5Free`, `Plugin.Glypher.WeatherIcons` Only support iOS and Android for the moment. 

# Contributing

Contributions are welcome.  Feel free to file issues and pull requests on the repo and they'll be reviewed as time permits.

## Icon

Thank you for the Icon by Yannick Lung (https://www.iconfinder.com/icons/314770/document_font_icon)
