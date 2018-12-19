# Surround Selection

[![Build status](https://ci.appveyor.com/api/projects/status/u3mx8qirp7nv4s86?svg=true)](https://ci.appveyor.com/project/priyanshu92/surroundselection)

Download this extension from the [VS Gallery](https://marketplace.visualstudio.com/items?itemName=PRIYANSHUAGRAWAL92.SurroundSelection)
or get the [CI build](http://vsixgallery.com/extension/4c807d55-9263-4ce0-9c1a-bfef58e96b02/).

---------------------------------------

The quickest way to wrap some selected text with various delimiters like double quotes, single quotes, braces etc.

See the [change log](CHANGELOG.md) for changes and road map.

## Features
Toggle wrapping of selected text in visual studio with:
- Double Quotes " "
- Single Quotes ' '
- Braces { }
- Parentheses ( )
- Square Brackets [ ]
- Angular Brackets < >
- Asterisk * *
- Multiline Comment /* */

### Steps to use
Select any text in Visual Studio and right click.

![Select And Right Click](Screenshots/select-and-right-click.png)

Then select *Surround Selection With* and then select the option you want eg. *Double Quotes* to get the text wrapped around that:

![Double Quotes Result](Screenshots/double-quotes-result.png)

## Hotkeys

| Action         | Hotkey          |
|----------------|-----------------|
| Double Quotes  | Ctrl+K, Ctrl+'  |
| Asterisk       | Ctrl+K, Ctrl+8  |

--------------------------------------------------------

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)