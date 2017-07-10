# TODO List for LVC118 Solution

Zhijie Nie, 2017-06-30

## Program Development
* (C#) Closing the loop between `ShadowSys118` and `LVC118`

## Documentation

## Coding Improvements


## Need to Knows
* TestHarness is just a tool for developing an analytic - the actual end product will be an 
**installable Windows service**.


## Backup - Input Adapters `ConnectionString` 

### SSCSV
```
Filename=C:\Program Files\openECA\Server\20170626_ShadowSys_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:1; 2 = PPA:2}
```

### LVCCSV
```
Filename=C:\Program Files\openECA\Server\20170608_LVC_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:21; 2 = PPA:22; 3 = PPA:23; 4 = PPA:24; 5 = PPA:25; 6 = PPA:26; 7 = PPA:27; 8 = PPA:28; 9 = PPA:29; 10 = PPA:30; 11 = PPA:31; 12 = PPA:32}
```

### SS118CSV
```
Filename=C:\Program Files\openECA\Server\20170620_ShadowSys_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 2 = PPA:41}
```

### PSDLVC118CSV
```
Filename=C:\Program Files\openECA\Server\20170703_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```


```
Filename=C:\Program Files\openECA\Server\20170703_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41; 3 = PPA:42; 4 = PPA:43; 5 = PPA:44; 6 = PPA:45; 7 = PPA:46; 8 = PPA:47}; InputInterval=1000
```


### SS118TEST1
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test1.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```


### SS118TEST2
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test2.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```


### SS118TEST3
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test3.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```


## Issues


## Completed Tasks
* (C#) Realize previous LVC's funtionality and write ActionSignals to XML file locally
* (C#) Add `ActionChannel` Class only with properties and XML serilization method
* (C#) Use XML file to close the loop between `ShadowSys118` and `LVC118` in case bi-directional 
data feeding is not possible