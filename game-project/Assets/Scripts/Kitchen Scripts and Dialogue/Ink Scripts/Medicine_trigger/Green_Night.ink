EXTERNAL addEveningMeds(string)
EXTERNAL getMEDICINE_GREEN()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the green pill?)
*[yes]
~addEveningMeds(getMEDICINE_GREEN())
Ahh, why is this pill so sour
-> END
*[no]
-> END