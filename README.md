# Program na evidenci záběrů o MHD (C#)

> **autor:** Martin Hamacek
> 
> **datum:** 9. 3. 2025
> 
> **aktuální verze:** verze 1.0

Desktop aplikace, která slouží k evidenci záběru dopravních prostředků MHD
variace produktu [webová aplikace v PHP](spsejecna.cz)
## Popis produktu
-- sem dát use case diagram

## Jak zprovoznit

### schéma config souborů
database.config

`<?xml version="1.0" encoding="utf-8" ?>`

`<configuration>`

`<database_connection>`

`<type_of_database>0</type_of_database>`

`<adress>192.168.88.12</adress>`

`<port>3306</port>`

`<database>evidence_clips_about_public_transport</database>`

`<user_name>root</user_name>`

`<password>heslo</password>`

`<other></other>`

`</database_connection>`

`</configuration>`

ftp_connection.xml

`<?xml version="1.0" encoding="utf-8" ?>`

`<configuration>`

`<ftp_connect>`

`<type_of_server>0</type_of_server>`

`<server>ftp://127.0.0.1/server/</server>`

`<user_name>uživatel</user_name>`

`<password>heslo</password>`

`</ftp_connect>`

`</configuration>`

styles.xml

`<?xml version="1.0" encoding="utf-8" ?>`

`<style>`

`<levels_of_font>`

`<font level="normal" size="11" color="000000" name_of_font="Segoe UI" />`

`<font level="header" size="16" color="2F5496" name_of_font="Segoe UI Light" />`

`<font level="odd" size="11" color="000000" name_of_font="Segoe UI" />`

`<font level="even" size="11" color="000000" name_of_font="Segoe UI" />`

`<font level="header_of_table" size="11" color="FFFFFF" name_of_font="Segoe UI" />`

`</levels_of_font>`

`<levels_of_rows>`

`<row level="header" color="2F5496" />`

`<row level="odd" color="D9E2F3" />`

`<row level="even" color="B4C6E7" />`

`</levels_of_rows>`

`<background color="E6E6E6" />`

`<border size="2" color="FFFFFF" />`

`<enable_odd_rows set="true" />`

`</style>`


## Architektura
princip na jedné tabulce

## Platforma
PC s operačním systémem Windows 10 a novější

## Funkce
- komunikace s MySQL databází
- spravovat záznamy v tabulce záběr
- správa záznamů v ostatních tabulkách
- správa souvisejících souboru na místním úložišti
- správa souvisejících souboru na FTP serveru*
- výpis statistik
- seřazení dat v tabulce podle jednoho vybraného sloupce
- správa uživatelů
- filtrování souboru
- import dat do dalších tabulek
- export dat z databáze
- export tabulky do html souboru
- vlastní SQL dotaz

`*` -  vzhledem k bezpečnosti nedoporučuji používat FTP serveru - používejte pouze pokud chcete využít web. app. 

## Kontakt
@ email - [hamacekmar@gmail.com](mailto:hamacekmar@gmail.com)
