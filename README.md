<p align="center">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/full%20logo.png" alt="Textify" title="Textify" align="middle" height="200" />
</p>

<p align="center">
	<a href="https://www.nuget.org/packages/TextifyLib/">
		<img src="https://img.shields.io/nuget/dt/TextifyLib.svg" alt="Downloads" title="Downloads"/>
		<img src="https://img.shields.io/nuget/v/TextifyLib.svg" alt="Nuget" title="Nuget"/>
	</a>
</p>

Textify is a text application and library that converts text to typefaces (fonts) that you can use in every chat app using Unicode and LaTeX technologies.

# Table of contents

- <a href="https://github.com/AriHanan/Textify#table-of-contents">Table of contents [meta]</a>
- <a href="https://github.com/AriHanan/Textify#typefaces">Typefaces</a>
- <a href="https://github.com/AriHanan/Textify#app">App</a>
  - <a href="https://github.com/AriHanan/Textify#installation">Installation</a>
  - <a href="https://github.com/AriHanan/Textify#how-to-use">How to use</a>
- <a href="https://github.com/AriHanan/Textify#library">Library</a>
  - <a href="https://github.com/AriHanan/Textify#setup">Setup</a>
  - <a href="https://github.com/AriHanan/Textify#how-to-use-1">How to use</a>
    - <a href="https://github.com/AriHanan/Textify#decleration">Declaration</a>
	- <a href="https://github.com/AriHanan/Textify#convert-text">Convert text</a>
- <a href="https://github.com/AriHanan/Textify#license">License</a>
- <a href="https://github.com/AriHanan/Textify#contact">Contact</a>
- <a href="https://github.com/AriHanan/Textify#author">Author</a>

# Typefaces
The following is a list of typefaces available on the Textify app and library.

- Serif Bold - 𝐓𝐡𝐞 𝐪𝐮𝐢𝐜𝐤 𝐛𝐫𝐨𝐰𝐧 𝐟𝐨𝐱 𝐣𝐮𝐦𝐩𝐞𝐝 𝐨𝐯𝐞𝐫 𝐭𝐡𝐞 𝐥𝐚𝐳𝐲 𝐝𝐨𝐠
- Serif Italic - 𝑇ℎ𝑒 𝑞𝑢𝑖𝑐𝑘 𝑏𝑟𝑜𝑤𝑛 𝑓𝑜𝑥 𝑗𝑢𝑚𝑝𝑒𝑑 𝑜𝑣𝑒𝑟 𝑡ℎ𝑒 𝑙𝑎𝑧𝑦 𝑑𝑜𝑔
- Serif Bold Italic - 𝑻𝒉𝒆 𝒒𝒖𝒊𝒄𝒌 𝒃𝒓𝒐𝒘𝒏 𝒇𝒐𝒙 𝒋𝒖𝒎𝒑𝒆𝒅 𝒐𝒗𝒆𝒓 𝒕𝒉𝒆 𝒍𝒂𝒛𝒚 𝒅𝒐𝒈
- Sans - 𝖳𝗁𝖾 𝗊𝗎𝗂𝖼𝗄 𝖻𝗋𝗈𝗐𝗇 𝖿𝗈𝗑 𝗃𝗎𝗆𝗉𝖾𝖽 𝗈𝗏𝖾𝗋 𝗍𝗁𝖾 𝗅𝖺𝗓𝗒 𝖽𝗈𝗀
- Sans Bold - 𝗧𝗵𝗲 𝗾𝘂𝗶𝗰𝗸 𝗯𝗿𝗼𝘄𝗻 𝗳𝗼𝘅 𝗷𝘂𝗺𝗽𝗲𝗱 𝗼𝘃𝗲𝗿 𝘁𝗵𝗲 𝗹𝗮𝘇𝘆 𝗱𝗼𝗴
- Sans Italic - 𝘛𝘩𝘦 𝘲𝘶𝘪𝘤𝘬 𝘣𝘳𝘰𝘸𝘯 𝘧𝘰𝘹 𝘫𝘶𝘮𝘱𝘦𝘥 𝘰𝘷𝘦𝘳 𝘵𝘩𝘦 𝘭𝘢𝘻𝘺 𝘥𝘰𝘨
- Sans Bold Italic - 𝙏𝙝𝙚 𝙦𝙪𝙞𝙘𝙠 𝙗𝙧𝙤𝙬𝙣 𝙛𝙤𝙭 𝙟𝙪𝙢𝙥𝙚𝙙 𝙤𝙫𝙚𝙧 𝙩𝙝𝙚 𝙡𝙖𝙯𝙮 𝙙𝙤𝙜
- Script - 𝒯𝒽ℯ 𝓆𝓊𝒾𝒸𝓀 𝒷𝓇ℴ𝓌𝓃 𝒻ℴ𝓍 𝒿𝓊𝓂𝓅ℯ𝒹 ℴ𝓋ℯ𝓇 𝓉𝒽ℯ 𝓁𝒶𝓏𝓎 𝒹ℴℊ
- Script Bold - 𝓣𝓱𝓮 𝓺𝓾𝓲𝓬𝓴 𝓫𝓻𝓸𝔀𝓷 𝓯𝓸𝔁 𝓳𝓾𝓶𝓹𝓮𝓭 𝓸𝓿𝓮𝓻 𝓽𝓱𝓮 𝓵𝓪𝔃𝔂 𝓭𝓸𝓰
- Fraktur - 𝔗𝔥𝔢 𝔮𝔲𝔦𝔠𝔨 𝔟𝔯𝔬𝔴𝔫 𝔣𝔬𝔵 𝔧𝔲𝔪𝔭𝔢𝔡 𝔬𝔳𝔢𝔯 𝔱𝔥𝔢 𝔩𝔞𝔷𝔶 𝔡𝔬𝔤
- Fraktur Bold - 𝕿𝖍𝖊 𝖖𝖚𝖎𝖈𝖐 𝖇𝖗𝖔𝖜𝖓 𝖋𝖔𝖝 𝖏𝖚𝖒𝖕𝖊𝖉 𝖔𝖛𝖊𝖗 𝖙𝖍𝖊 𝖑𝖆𝖟𝖞 𝖉𝖔𝖌
- Monospace - 𝚃𝚑𝚎　𝚚𝚞𝚒𝚌𝚔　𝚋𝚛𝚘𝚠𝚗　𝚏𝚘𝚡　𝚓𝚞𝚖𝚙𝚎𝚍　𝚘𝚟𝚎𝚛　𝚝𝚑𝚎　𝚕𝚊𝚣𝚢　𝚍𝚘𝚐
- Fullwidth - Ｔｈｅ　ｑｕｉｃｋ　ｂｒｏｗｎ　ｆｏｘ　ｊｕｍｐｅｄ　ｏｖｅｒ　ｔｈｅ　ｌａｚｙ　ｄｏｇ
- Double-Struck - 𝕋𝕙𝕖　𝕢𝕦𝕚𝕔𝕜　𝕓𝕣𝕠𝕨𝕟　𝕗𝕠𝕩　𝕛𝕦𝕞𝕡𝕖𝕕　𝕠𝕧𝕖𝕣　𝕥𝕙𝕖　𝕝𝕒𝕫𝕪　𝕕𝕠𝕘
- Inverted - ƃop ʎzɐן ǝɥʇ ɹǝʌo pǝdɯnɾ xoɟ uʍoɹq ʞɔınb ǝɥʇ
- Circled - Ⓣⓗⓔ　ⓠⓤⓘⓒⓚ　ⓑⓡⓞⓦⓝ　ⓕⓞⓧ　ⓙⓤⓜⓟⓔⓓ　ⓞⓥⓔⓡ　ⓣⓗⓔ　ⓛⓐⓩⓨ　ⓓⓞⓖ
- Circled Black - 🅣🅗🅔 🅠🅤🅘🅒🅚 🅑🅡🅞🅦🅝 🅕🅞🅧 🅙🅤🅜🅟🅔🅓 🅞🅥🅔🅡 🅣🅗🅔 🅛🅐🅩🅨 🅓🅞🅖
- Squared - 🅃🄷🄴　🅀🅄🄸🄲🄺　🄱🅁🄾🅆🄽　🄵🄾🅇　🄹🅄🄼🄿🄴🄳　🄾🅅🄴🅁　🅃🄷🄴　🄻🄰🅉🅈　🄳🄾🄶
- Squared Black - 🆃🅷🅴 🆀🆄🅸🅲🅺 🅱🆁🅾🆆🅽 🅵🅾🆇 🅹🆄🅼🅿🅴🅳 🅾🆅🅴🆁 🆃🅷🅴 🅻🅰🆉🆈 🅳🅾🅶
- Small Caps - ᴛʜᴇ Qᴜɪᴄᴋ ʙʀᴏᴡɴ ꜰᴏx ᴊᴜᴍᴩᴇᴅ ᴏᴠᴇʀ ᴛʜᴇ ʟᴀᴢY ᴅᴏɢ
- Subscript - ᵀʰᵉ qᵘⁱᶜᵏ ᵇʳᵒʷⁿ ᶠᵒˣ ʲᵘᵐᵖᵉᵈ ᵒᵛᵉʳ ᵗʰᵉ ˡᵃᶻʸ ᵈᵒᵍ
- Parenthesized - ⒯⒣⒠ ⒬⒰⒤⒞⒦ ⒝⒭⒪⒲⒩ ⒡⒪⒳ ⒥⒰⒨⒫⒠⒟ ⒪⒱⒠⒭ ⒯⒣⒠ ⒧⒜⒵⒴ ⒟⒪⒢
- ExtraThicc - ㄒ卄乇　ＱЦ丨匚ズ　乃尺σЩ刀　ቻσ乂　ﾌЦጠρ乇Ｄ　σＶ乇尺　ㄒ卄乇　ረ卂乙Ч　ＤσБ
- NumberSpeak - 7h3 qu!(k 8r0wn f0x jump3d 0v3r 7h3 142y d09
- Blank Banshee - THΣ QUIↃK BROWN FOX JUMPΣD OVΣR THΣ LΛZY DOG

App exclusives:
- Mixed - 𝒕𝚑𝙴 𝓺𝖀ⁱ𝕔𝓚 b𝘳ᵒｗｎ　𝓯𝙾x　🅙𝘶𝓶𝑝ｅ𝖣 𝑜𝑽🄴ʀ 𝑇𝗛ᴇ　𝒍ᵃ𝙯y　𝔇𝕆ｇ
- Zalgo - T̸̢̀̀͢͠͝͞͞h̵̵̶̸̨̛̀͟͝e̵͏̧̧̛͘͝͞͝ ̀͏̴̶̧̧̛͠͞q̨̛̀́͘͝͝͝͞ư̸̶̢͟͟͝͝͞i̧̨̧͟͞͠͏̛͘ç̢̛͘͢͞͏̸̧k͏̴͏̨̡́̀͟͠ ͜͟͜͠͏̢͜͝͠B̶̴́͘͟͜͞͝͠r̶̵̨̧͟͝͞͏̸ǫ̸̶̵̴̛̀͟͜ẃ̴̴̴̡́͢͠͏ņ̴̢̧̛́͘͘͘ ̸̵̴̡̧͘͝͝͠f̴̶̡̨̛͜͟͢͏o̴͏̸̨̡̧͟͏͝x̵̨̡̡̢̢͘͘͞ ̸̴̵̨́́͢͝͏j̴̧̧̢̀͢͟͢͞ừ̵̵̴͜͠͝͞ḿ̶͜͏̢̛̀͢͢p̴̢̨̨̛͘͟͢͠ȩ̴̡̨̛̛́͢͜d̛̀͘͢͟͜͟͠͠ ̨̛̛̀͘͝͝͏̡ó̵̴̢̀͜͟͜͠v̨͠͏̸̡̡͘͢͞è̴̵̡̢̢̀͜͠r̶̸̡̀͘͟͟͝͠ ̵̧̨̧́͘͢͜͟t̵̴̴̢̛̛̛͞͠ḩ̧̨̧̛̀͟͞͞e̶̶̡̨̢͘͟͞͝ ̧̨́̀̀͘͢͟͜l̸̶̴͘͏̧̛͘͠à̴̴̴̡́͞͏̀z̶̧̢̨̛͜͢͟͝ý̸̵̶͝͞͏͘͟ ̶̵̧̧̨̛͜͜͝d̸̵̵̶̢̛̛͘͜ǫ̴̧̢̡͜͢͢͞g̶̴̴̸͜͠͏̴̨
- Trademark - The quick Brown fox jumped over the lazy dog™
- NiBBa - The quick 🅱rown fox jumped over the lazy dog
- Laemon - Thæ quick brown fox jumpæd ovær thæ lazy dog‽
- Randomcase - THE QuicK BROwn FOx JUmpED ovER thE lazY DOG

# App

## Installation
<a href="https://github.com/AriHanan/Textify/releases/download/v1.5.0/TextifyApp.zip">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/download.png" alt="Download" title="Download" align="middle" height="70" />
</a>

Click on the text above to download a zip.

Extract the contents of the zip on a prefered folder, then create a shortcut for `textifyapp.exe`.

For version history go to <a href="https://github.com/AriHanan/Textify/releases">Releases</a>

<a href="https://github.com/AriHanan/Textify/releases/download/v1.5.0/TextifyPortable.exe">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/portable.png" alt="Download Portable" title="Download Portable" align="middle" height="50" />
</a>

If you wish for a standalone version theres an exe in the same folder, however it does not remember the last choise upon restart, and it does not have the fancier icon when pinned to a Windows 10 start menu.

You can click the title here too.

Once downloaded simply run.

For version history go to <a href="https://github.com/AriHanan/Textify/releases">Releases</a>

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
<a href="https://github.com/AriHanan/Textify/releases/download/v1.5.0/TextifyLib.dll">
	<img src="https://github.com/AriHanan/Textify/blob/master/Resources/download.png" alt="Download" title="Download" align="right" height="70" />
</a>

The library is available at `Textify/TextifyLib/TextifyLib/bin/Release/TextifyLib.dll`.

If you prefer, the library is also available on <a href="https://www.nuget.org/packages/TextifyLib/">NuGet</a>

You can also use the download button.

For version history go to <a href="https://github.com/AriHanan/Textify/releases">Releases</a>

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

See <a href="https://github.com/AriHanan/Textify/blob/master/LICENSE.md">LICENSE.md</a> for the license itself.

# Contact
If you have a feature request, want to send hate mail, or wish to contribute code, please reach me at AriHanan@protonmail.com.

Happy cycling.

# Author
made by the very bored developer <a href="https://github.com/AriHanan">Ari Hanan</a>.

> Textify, v1.5
