<img src="https://github.com/AriHanan/Textify/blob/master/Resources/full%20logo.png" alt="Textify" title="Textify" align="middle" height="150" />

Textify is a text application and library that converts text to typefaces (fonts) that you can use in every chat app using Unicode and LaTeX technologies.

# Table of contents

- <a href="https://github.com/AriHanan/Textify#table-of-contents">Table of contents</a>
- <a href="https://github.com/AriHanan/Textify#app">App</a>
  - <a href="https://github.com/AriHanan/Textify#installation">Installation</a>
  - <a href="https://github.com/AriHanan/Textify#how-to-use">How to use</a>
- <a href="https://github.com/AriHanan/Textify#library">Library</a>
  - <a href="https://github.com/AriHanan/Textify#setup">Setup</a>
  - <a href="https://github.com/AriHanan/Textify#how-to-use-1">How to use</a>
    - <a href="https://github.com/AriHanan/Textify#decleration">Declaration</a>
	- <a href="https://github.com/AriHanan/Textify#convert-text">Convert text</a>
- <a href="https://github.com/AriHanan/Textify#author">Author</a>

# App

## Installation
<a href="https://github.com/AriHanan/Textify/raw/master/TextifyApp/textify/bin/Release/textify.exe">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/download.png" alt="Download" title="Download" align="right" height="65" />
</a>

`Textify/TextifyApp/textify/bin/Release/textify.exe` is a stand-alone and the only file you need.

You can also use the fance button on the right.

Once downloaded simply run.

## How to use
1. Type the text you wish to convert in the text box at the top
2. Click on the desired typeface
3. Go to your text application
4. Right click
5. Paste
6. Spanish inquasition
7. Profit

<img src="https://github.com/AriHanan/Textify/blob/master/Resources/How%20to%20use.gif" alt="This gif took 58 takes to make." title="This gif took 58 takes to make." align="middle" />

# Library

## Setup
<a href="https://github.com/AriHanan/Textify/raw/master/TextifyLib/TextifyLib/bin/Release/TextifyLib.dll">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/download.png" alt="Download" title="Download" align="right" height="65" />
</a>

The library is available at `Textify/TextifyLib/TextifyLib/bin/Release/TextifyLib.dll`.

You can also use the download button.

## How to use

### Declaration
The library can be declared with `using TextifyLib;`.

### Convert text
Text can be converted by the following line:

`TextifyLib.Typefaces.[typeface].Convert([string]);` (with [typeface] and [string] replaced with values)

EXAMPLE:
```
string text = "Yesterday I woke up sucking a lemon";
string converted = TextifyLib.Typefaces.CharFullwidth.Convert(text);

Console.WriteLine("'{0}' converted to full width is: '{1}'", text, converted);
```
outputs:

`'Yesterday I woke up sucking a lemon' converted to full width is: 'Ｙｅｓｔｅｒｄａｙ　Ｉ　ｗｏｋｅ　ｕｐ　ｓｕｃｋｉｎｇ　ａ　ｌｅｍｏｎ'`

# License
This software and library are available under the MIT license.

See LICENSE.md for the license itself.

# Author
made by the very bored developer <a href="https://github.com/AriHanan">Ari Hanan</a>.

> Textify, v1.5
