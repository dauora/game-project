EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_CARROT()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
(Get carrots?)
*[yes]
#speaker: Mother #portrait:Happymother
Halim ah, can get me some carrots or not?
~addGroceries(getGROCERIES_CARROT())
#speaker: Halim #portrait:Halim
Sure thing, auntie, the freshest carrots for you!
-> END
*[no]
-> END