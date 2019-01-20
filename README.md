This is a C# example about how to write a small application.
#### Attention: this code is writed in visual studio 2017, older version may not compatible
***********************************************************************
What kinds of example?

In this example I use the C# skill about
 
* Inherit 
* Language-Integrated Query (LINQ) 
* Event
* Dictionary and List
* Read Write files
* Command pattern
* Communicate with excel (save file to excel)
***********************************************************************
# Inherit
Inherit can be found in AccountingCommandAndReceiver.cs, such as
``` C#
class ModifyItemPriceCommand : AccountingCommand
```

# Language-Integrated Query (LINQ) 
LINQ can be found in AccountingCommandAndReceiver.cs, such as

```C#
 var dateRecord = Readlines.Select(l => l.Split('=')).Where(x => x[2] == AccountingInformation.fileDateKeyWord).ToDictionary(a => a[0], a => double.Parse(a[1]));
```
# Event
Event can be found in AccountingCommandPattern.cs, sucg as
```C#
public static event Action<string> ShowDialogEvent = null;
```
# Dictionary and List
Dictionary can be found in AccountingCommandAndReceiver.cs, such as
```C#
public Dictionary<string, double> dateMoneyRecord;

List<string> write2File = new List<string>();
```
# Read Write files
Read Write files can be found in AccountingCommandAndReceiver.cs, such as
```C#
 File.WriteAllLines(filePath, write2File);
```
# Communicate with excel (save file to excel)
save file to excel function can be found in AccountingCommandAndReceiver.cs, which is 
```C#
public void SaveToExcel(string excelPath)
```
# Command pattern
This structure is written in command pattern, so it is much easer to read and modify. 
***********************************************************************
How to use?
You can type how much money you spend each date and special item that you spend.
It can add all price and show up total money you spend.
Finally, you can save it and read from the old file.
