# funkce programu

## verze 1.0

- možnost zálohování dat z databáze do souboru .csv

- možnost spravovat data nad všemi tabulkami

- vyhledávání v tabulce

- vyhledávání v tabulce buď podle označení, nebo podle evidenčního čísla

- hromadné přejmenování - tabulka zastávka

- generovat řadu - tabulka linky

- statistiky

|název statistiky|obsahuje graf|typy grafů|
|-|-|-|
|celkový přehled|ne|ne|
|přepočet záběrů na dny|ano|- sloupcový graf I.  <br> - bodový graf I.|
|přepočet záběrů na měsíc|ano|- sloupcový graf I. <br> - bodový graf I.|
|přepočet záběrů na jednotlivé linky|ano|- sloupcový graf I. <br> - bodový graf I.|    
|přepočet záběrů na jednotlivé zastávky|ano|- sloupcový graf I. <br> - bodový graf I.|
|přepočet dnů na zastávky|ano|- sloupcový graf I. <br> - bodový graf I.|    
|přepočet záběrů na podtyp dopravních prostředků|ano|- sloupcový graf II.|
|přepočet linek na zastávku na základě klipů|ano|- sloupcový graf II.|    
|přepočet linek na podtyp dopravních prostředků|ano|- sloupcový graf III.| 

- filtr (filtrování záběrů)
    - období

    - formáty

    - linky

    - dopravci

    - zastávky

    - podtyp dopravních prostředků

- zkopírovat záběry (filtr, SQL dotaz (pouze pokud SQL dotaz obsahuje sloupce `name_of_clip` a `file_url`))

- sql dotaz

- nastavení

    - správa úložiště (podpora místního úložiště a FTP)

    - stylopis (zatím pouze pro HTML soubory)

        - úrovně textu (běžný text, nadpis, liché řádky, sudé řádky, hlavičky tabulky)
            - název fontu

            - barva

            - velikost

        - ohraničení buňky

        - barva ohraničení

        - barva pozadí dokumentu

        - typ řádku (liché, sudé, hlavička)

            - barva pozadí

        - rozlišování sudých a lichých řádků


- všechno co má tabulku - uložit jako

    podporované formáty: 

    |název formátu|koncovka|
    |-|-|
    |hypertext markup language|*.html|
    |textový soubor s oddělovači|*.csv|
    |textový soubor s tabulátorem oddělenými hodnotami|*.tsv|
    |markdown|*.md|
    |javascript object notation|*.json|
    |extensible markup language|*.xml|
    |extensible markup language (včetně datových typu)|*.xml|
    |sešit MS Excel 2007 a výše|*.xlsx|

- Sem zadejte nadpis – vstupní pole

    Slouží k zadání nadpisu

- Import dat – tabulka záběr

    Slouží k hromadnému nahraní souborů na server včetně informací. 

    1.	nejprve natáčíte záběry a průběžně si zapisujete v elektronické formě (.xlsx, nebo .csv) informace

    2.	pomocí tlačítka Vybrat zdroj souborů vybere původní místo souboru (buď připojenou SD kartu, nebo jiné zařízení)

    3.	následně pomocí Vybrat soubor s daty vybere soubor, kam byly zapsány požadované data

    4.	důležité je sjednocení dat, které manuálně provedete včetně odstranění prázdných řádků

    5.	Následně vybere cílový adresář a kliknete na uložit a data ze souboru se zapíšou do databáze a poté dojde ke zkopírování dat

