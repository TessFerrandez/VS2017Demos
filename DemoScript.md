# New in Visual Studio 2017 Demo Script #
## Installer ##
1. Talk about workloads and optional items, ex. ASP.NET 4.6.2
2. Talk about Individual Components, ex Git extensions for Windows

Core Visual Studio is about as big as 2 notepads

## Startup and Performance ##

### Startup ###
1. Launch Visual Studio (launches a lot faster)
### Start View ###
1. Start View - Most Recently Used project templates
2. Open from GitHub and VSTS
3. Open files/folders without solution
### Lightweight Load ###
1. Open the Demo Solution (loading time)
2. Turn on lightweight load 
3. Close and reopen

## Productivity and Refactoring ##

### Enhanced Navigation ###
1. Bring up Go To with **Ctrl+,** and search for Person
2. Filter (eg. buttons or t Person)
3. Navigate to Person
### Scope Identifiers ###
1. Show Scope identifiers in Person/SaveAddressToFile
2. Hover over the Scope identifiers
### Find all references ###
1. Show Find all References (for Person) - improved with keep results and grouping etc.
### Intellisense filtering ###
1. Show Intellisense Filtering
### Class/File refactoring ###
1. Create a new class in the Models Folder - clear the class file
2. Copy Json from http://openweathermap.org/current (sample queries)
3. Edit / Paste Special/JSON as Classes
4. **Ctrl+.** to move the classes to separate files
5. Rename the RootObject class and **Ctrl+.** to rename the file too
### More refactoring goodies ###
1. Open RefactorDemo.cs
2. Refactor Number property to methods
3. Refactor initialization of Person
### String refactoring ###
1. Open RefactorStringsDemo.cs
2. Refactor string.format to string interpolation
3. Chop up the long string with just enter
### XAML ###
1. Open XAMLIMprovements/MainWindow.xaml
2. uncomment Int32... and show ctrl+. to add namespace
3. Remove and sort namespaces
4. rightclick to rename namespaces

## New in C#7 ##

Use Csharp7.cs file for this

### Literal Improvements ###

1. var i = 10000000;
2. add _ to space it up 1_000_000; (can place them anywhere)
other ex: var x = 0xAB_CD_EF;
3. new binary literals... var b = 0001_0101_0011_1100;
