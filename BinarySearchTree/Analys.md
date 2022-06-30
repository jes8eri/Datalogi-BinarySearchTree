BinarySearchTree

Genomgång av metoder

Count metoden:      
Då den måste gå igenom varje värde som finns i hela trädet, så borde tidskomplexiteten vara O(n), då det är linjärt med antalet element.  
Finns det fler element att gå igenom, så ökar ju tiden.  
	Tidskomplexitet  
	Best case:  O(1) om det bara finns ett element..  
	Worst case:  O(n)  
	Average case:  O(n)  

  

Exists metoden:  
Söker rekursivt igenom sökträdet, från vänster => höger => uppåt för alla noder.  
Worst case scenario borde vara om trädet är väldigt obalanserat och att en sida går nästan rakt nedåt.  
I det fallet liknar sökträdet en länkad lista. Så tidskomplexitet för worst case borde vara linjärt med antalet element, dvs O(n).  
Om trädet istället är balanserat så borde det ha en logaritmisk tidskomplexitet på O(log n), då det hela tiden kan delas på hälften tills värdet hittas.  
Best case borde vara om rooten längst upp i trädet har det första värdet man söker, och då borde tidskomplexiteten för best case bli O(1), då det första elementet är en träff.  
	Tidskomplexitet  
	Best case:  O(1)  
	Worst case:  O(n)  
	Average case:  O(log n)  



Insert metoden:  
Måste hitta en passande tom nod att lägga in värdet i.  
Om roten i trädet inte har något värde, så blir det den mest passande noden. Alltså blir best case O(1).  
Annars så måste ju en sökning ske i trädet för att hitta det mest passande värdet, vilket resulterar i en logaritmisk tidskomplexitet på O(log n).  
Worst case är även här om trädet är obalanserat, exempelvis en rak linje ner åt höger (ex 5-6-7-8-9-10). Då blir det en tidskomplexitet på O(n), precis som i exists metoden.  
	Tidskomplexitet:  
	Best case:  O(1)
	Worst case:  O(n)
	Average case:  O(log n)  

Rymdskomplexitet för det binära sökträdet borde ju huvudsakligen bestå av antalet noder i trädet, vilket blir O(n).  

Reflektion:  
När det gäller tidskomplexiteten så tror jag tror att detta binära sökträdet ligger inom ramarna för vad som är normalt för ett binärt sökträd, men det hade absolut blivit bättre av att kunna bli balanserat.    
Det binära sökträdet hade blivit mer effektivt om det var självbalanserat eller om det hade funnits en metod för att balansera trädet, så att skillnad i höjd mellan vänster/höger inte är större än ett.  
Just nu så beror tidskomplexiteten för de flesta metoder på vilka värden som manuellt skickas in i trädet, och det är ju mindre genomtänkt.
