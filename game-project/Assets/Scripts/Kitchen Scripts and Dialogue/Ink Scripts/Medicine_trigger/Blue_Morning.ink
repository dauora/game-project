EXTERNAL addMorningMeds(string)
EXTERNAL getMEDICINE_BLUE()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the blue pill?)
*[yes]
~addMorningMeds(getMEDICINE_BLUE())
Ahh, why is this pill so big
-> END
*[no]
-> END