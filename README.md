# Evidence záběrů o MHD - desktop aplikace

autor: Martin Hamacek

## učel aplikace: 
Desktop aplikace na evidenci záběrů dopravních prostředků MHD. 

## architektura programu
- package diagram

## použité technologie

- [Winforms C# (.net 8.0)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0) – tvorba uživatelského rozhraní desktopové aplikace v jazyce C#
- [MySQL.data.Connection (v 9.1.0)](https://www.nuget.org/packages/MySql.Data/9.1.0#show-readme-container) – práce s MySQL databázi 
- [ScottPlot (v 5.0.47)](https://scottplot.net/) - vytváření grafů na desktop aplikaci
- [DocumentFormat.OpenXml (v 3.3.0)](https://www.nuget.org/packages/documentformat.openxml) - načítání dat z .xlsx souboru

## jak zprovoznit

### zdrojové kódy
1. stáhněte si tento repozitář
2. otevřete projekt ve Visual Studiu
3. nainstalujte potřebné NuGets (seznam použitých technologií)

### build programu

1. nahrajde databázi na MySQL server [postup](https://github.com/Martin-Hamacek-05/mysql_ev_clip_about_p_transport)
2. spustě .exe soubor, který se nachází v bin/Debug/net8.0-windows
3. po spuštění klikněte na tlačítko připojení do databáze, a zadejte všechny potřebné údaje
4. přihlašte se uživatelské jméno `admin` heslo: `Heslo321123` - pro přihlášení změnte heslo

## Databáze

viz. další odkazy

## záznamy o změnách v dokumentaci
|datum|změna|
|-|-|
|9. 4. 2025|Nová verze dokumentace|
|10. 4. 2025|Úprava - použité technologie, doplnění jak zprovoznit, doplnění odkazů|

## kontakt
@ - hamacekmar@gmail.com

## další odkazy
[Evidence záběrů o MHD - schéma databáze pro MySQL server](https://github.com/Martin-Hamacek-05/mysql_ev_clip_about_p_transport)

[Evidence záběrů o MHD - webové rozhraní]()
