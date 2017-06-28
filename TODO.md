# TODO List for LVC118 Solution

Zhijie Nie, 2017-06-28

## Program Development
* (C#) Closing the loop between `ShadowSys118` and `LVC118`

## Documentation

| I/O | Name | DataType | PointTag | SignalType | SignalReference | ID (Assigned) |
| :-: | :--- | :------- | :------- | :--------: | :-------------- | :------------ |
| N/A | LoadIncrementPercentage | double | SS_118:LOADINCRE | DIGI | SS118-LOADINCRE | PPA:41 |
| O | ActTxRaise      | short  | SS_118:ACTTXRAISE      | DIGI | SS118-ACTXRAISE   | PPA:42 |
| O | ActTxLower      | short  | SS_118:ACTTXLOWER      | DIGI | SS118-ACTTXLOWER  | PPA:43 |
| O | ActSn1Close     | short  | SS_118:ACTSN1CLOSE     | DIGI | SS118-ACTSN1CLOSE | PPA:44 |
| O | ActSn1Trip      | short  | SS_118:ACTSN1TRIP      | DIGI | SS118-ACTSN1TRIP  | PPA:45 |
| O | ActSn2Close     | short  | SS_118:ACTSN2CLOSE     | DIGI | SS118-ACTSN2CLOSE | PPA:46 |
| O | ActSn2Trip      | short  | SS_118:ACTSN2TRIP      | DIGI | SS118-ACTSN2TRIP  | PPA:47 |
| I | StateTxTapV     | short  | SS_118:STATETXTAPV     | DIGI | SS118-STATETXTAPV | PPA:48 |
| I | StateSn1CapBkrV | short  | SS_118:STATESN1CAPBKRV | DIGI | SS118-STATESN1CAPBKRV | PPA:49 |
| I | StateSn2CapBkrV | short  | SS_118:STATESN2CAPBKRV | DIGI | SS118-STATESN2CAPBKRV | PPA:50 |
| I | StateSn1BusBkrV | short  | SS_118:STATESN1BUSBKRV | DIGI | SS118-STATESN1BUSBKRV | PPA:51 |
| I | StateSn2BusBkrV | short  | SS_118:STATESN2BUSBKRV | DIGI | SS118-STATESN2BUSBKRV | PPA:52 |
| I | MeasTxVoltV     | double | SS_118:MEASTXVOLTV     | VPHM | SS118-MEASTXVOLTV  | PPA:53 |
| I | MeasSn1VoltV    | double | SS_118:MEASSN1VOLTV    | VPHM | SS118-MEASSN1VOLTV | PPA:54 |
| I | MeasSn2VoltV    | double | SS_118:MEASSN2VOLTV    | VPHM | SS118-MEASSN2VOLTV | PPA:55 |
| I | MeasTxMwV       | double | SS_118:MEASTXMWV       | CALC | SS118-MEASTXMWV    | PPA:56 |
| I | MeasTxMvrV      | double | SS_118:MEASTXMVRV      | CALC | SS118-MEASTXMVRV   | PPA:57 |
| I | MeasGn1MwV      | double | SS_118:MEASGN1MWV      | CALC | SS118-MEASGN1MWV   | PPA:58 |
| I | MeasGn1MvrV     | double | SS_118:MEASGN1MVRV     | CALC | SS118-MEASGN1MVRV  | PPA:59 |
| I | MeasGn2MwV      | double | SS_118:MEASGN2MWV      | CALC | SS118-MEASGN2MWV   | PPA:60 |
| I | MeasGn2MvrV     | double | SS_118:MEASGN2MVRV     | CALC | SS118-MEASGN2MVRV  | PPA:61 |


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
Filename=C:\Program Files\openECA\Server\20170627_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:42; 2 = PPA:43; 3 = PPA:44; 4 = PPA:45; 5 = PPA:46; 6 = PPA:47}; InputInterval=500
```

## Issues


## Completed Tasks