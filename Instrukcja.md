# Przygotowanie projektu
Solucja została utworzona w środowisku Visual Studio 2013 i na tej wersji została przetestowana.

Po otwarciu solucji należy ją przebudować (Build -> Rebuild Solution) aby Visual Studio pobrał odpowiednią wersję Entity Framework-a.

Następnie trzeba otworzyć plik z schematem bazy (LibraryDBModel.edmx) i w pustym miejscu na schemacie kilknąć prawym przyciskiem myszy oraz wybrać opcję "Generate Database from Model".

Po wyświetleniu okna dialogowego, w polu "Server name" należy wpisać "(localdb)\v11.0", a w polu "Select or enter a database name" wpisać "Biblioteka.LibraryDBModel". Zmiany można zatwierdzić klikając OK. Stworzy to nową, lokalną bazę danych w środowisku Visual Studio.

Teraz można otworzyć plik z skryptem tworzącym bazę (LibraryDBModel.edmx.sql) i ponownie klikając prawym przyciskiem myszy, wybrać z menu opcję "Execute". Może pojawić się okno logowania do bazy danych, należy wtedy jako nazwę serwera podać "(localdb)\v11.0" i kliknąć OK.

Po tym jak skrypt skończy się wykonywać trzeba zapisać plik z schematem oraz skryptem i po zapisaniu je zamknąć. Można wtedy już normalnie zbudować solucję (Build -> Build Solution) i uruchomić aplikację.
