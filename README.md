# LVC118
This is the Analytic project of Local Voltage Controller using IEEE 118-bus system, generated using 
openECA Client v1.0.5.0.



## Control Decision Thresholds

| Configuration File  | TapChanger | CapBank #1 | CapBank #2 | 
| :------------------ | :--------: | ----: | ----: |
| init_SysConfigFrame_test1 | [131.1, 133.8] | [130.0, 135.0] | [129.0, 134.0] |
| init_SysConfigFrame_test2 | [131.1, 133.8] | [130.0, 135.0] | [129.0, 134.0] |
| init_SysConfigFrame_test3 | [131.1, 133.8] | [130.0, 135.0] | [126.0, 134.0] |


## I/Os
| I/O | Name | DataType | PointTag | SignalType | SignalReference | ID (Assigned) |
| :-: | :--- | :------- | :------- | :--------: | :-------------- | :------------ |
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
| N/A | LoadIncrementPercentage | double | SS_118:LOADINCRE | DIGI | SS118-LOADINCRE | PPA:41 |


