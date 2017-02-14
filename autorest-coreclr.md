# AutoRest on CoreCLR

## Running AutoRest
- [NodeJS](https://nodejs.org/en/) (`>= 6.9.5`) with gulp (`npm install -g gulp`)
- [latest dotnet-cli toolset](https://github.com/dotnet/cli#installers-and-binaries) (`>= 1.0.0-rc4-004812`)
- build AutoRest (`npm install; gulp build`)
- run AutoRest (`gulp autorest ...`)

## Developing AutoRest
- all of the above
- [latest VS2017](https://aka.ms/vs/15/int.d15rel/vs_enterprise.exe)
- VSCode (`>= v1.9`) with [Omnisharp](https://github.com/OmniSharp/omnisharp-vscode/releases/) (`>= v1.7.0`)
- the language-specific installations (or just use the cowboy's [script](https://github.com/Azure/autorest/blob/master/Tools/setup-developerworkstation.ps1))

## Useful Commands
...working from any subdirectory of the repository!

|                      |                           |
|----------------------|---------------------------|
|Discover Commands     | `gulp`                    |
|Build                 | `gulp build`              |
|Run Tests             | `gulp test`               |
|Regenerate Test Files | `gulp regenerate`         |
|Run                   | `gulp autorest "<args>"`  |
|Reset Dotnet Cache    | `gulp reset-dotnet-cache` |

