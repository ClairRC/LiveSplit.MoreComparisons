# LiveSplit.MoreComparisons

This is a LiveSplit component which allows you to generate custom comparisons for a given goal time with options to determine how time save is distributed.

The DLL file can be downloaded [here](https://github.com/ClairRC/LiveSplit.MoreComparisons/tree/main/Component).

## How to use
Drag LiveSplit.MoreComparisons.dll into the component folder in your LiveSplit folder.

Go to "Edit Layout..." and add More Comparisons (under Other) to your layout.

Double click the component and input your specifications.

Click "Add comparison" and it'll be added to your layout.

## Options

### Comparison Name

This is the name of the comparison to be added.

### Final Split Time

This will be the end goal of the comparison. It tends to round down a little, so if you want it to end as 2:00:00 instead of 1:59:59, you could input 2:00:00.01.

### Timesave Generation

This will determine how your time save is distributed.

**Constant** will give every split an equal amount of time save.

**Length** will determine the time save based on the length of the split.

**Random** will randomly distribute your time save.

### Timesave Spread

This option is basically how extreme your time saves will be. If you set it to 0, every split will be worse than gold, and time saves will be distributed fairly evenly.

If higher options are chosen, time saves will be more extreme at the cost of some splits being better than gold.

**Note:** It's recommended for comparisons that are actually reasonable to compare against to use lower values. 20-50 will give pretty normal splits. Higher numbers result in more extreme and sillier results.

## To-Do

I would like to add more generation methods, such as balanced, and maybe more interesting options.


## Notes

It is recommended to use comparison names that aren't already implemented into LiveSplit. Naming your comparison "Average Segments" for instance could cause weird behavior. (This is a LiveSplit thing in general.)

If you notice any bugs or have any suggestions, feel free to reach out and let me know. My Discord is clair.rc.