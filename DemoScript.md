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

### Out variables ###
1. Refactor in ParseOut to declare int inline

### Null check allows throw ###
1. Refactor in null check

### Pattern matching in switch ###
1. Add cases for Customer c and Employee e
2. Add case for Customer c when c.Age > 20
3. Talk about order of cases

        switch(p){
            case Customer c when c.Age > 20;
                break;
            case Customer c:
                break;
            Case Employee e:
                break;
            default:
                break;
        }

### Tuples ###
1. Change signature and return

        public (string First, string Last) ParseName(){
            ...
            return (firstName, lastName);
        }

2. Tuple deconstruction

        (string firstName, string lastName) = ParseName();


### Force c# 6 ###
If you work with developers who stay in vs2015

1. Go to **Project Properties/Build/Advanced/Language Version** 

## XAML imporovements ##

1. Set XamlImprovements project as startup and run it
2. Add XAML while loading to show XAML edit and continue

        <TextBlock Text="Hello" FontSize="24"/>

## Live Test ##

Project and Test project under TestImprovements

1. Test / Run all tests -- back and forth workflow
2. Turn on live testing and wait for it to kick in
3. Talk about Fail, Pass, Miss
4. Add Multiply method, show miss (since we dont have tests for that)
5. Point out the missing line in Divide (test didnt cover it)
6. Show Subtract (click on X), one passing and one failing test
7. Fix the failing test

Can pause if you do large refactorings
Can exclude projects or files
Test runner is synced up

Supports NUnit, XUnit and MSTest

## Debugging Improvements ##

1. Set debuggerimprovements project as startup and run it

### run to click ###
1. Click 3 to break at breakpoint
2. Click to run and note perftips as well (perftips came in 2015 but now match Diagnostic tools)

### New exception dialog ### 
1. Run scenario 1 - break at exception
2. Show new exception dialog, exception settings and conditions

### Null reference exceptions ###
1. Run scenario 2 - break at null ref and show how it picks up nullref
2. add exception filtering on inner catch

        catch (FileNotFoundException ex) when (ex.FileName == "some file")

### Attach and reattach ###
1. Attach and show filter
2. Re-attach

## Xamarin ##

### -- prepp -- ###
1. Open XamarinApp project (make sure solution is rebuilt)
2. Open XamarinApp/Views/AboutPage
3. View/other windows/xamarin forms preview (Place side by side)

### Xamarin forms previewer ###
1. change text on button to show live preview
2. add new button or label underneath to show improved xaml intellisense

## Other improvements ##