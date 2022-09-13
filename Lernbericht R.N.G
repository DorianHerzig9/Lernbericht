# Lernbericht zu R.N.G
  Dorian Herzig / Lernatelier 
  
## Einleitung
  Ich habe ein Random Number Generrator Spiel gemacht.
  
## Was habe ich gelernt?
Ich habe gelernt, wie ich ein Programm schreibe und es zu einem Spiel mache,
sowie den Text und Hintergrund schön zu gestalten.

## Beschreibung
1.Ich habe das man das Programm auf C# schreiben muss und das haben ein auf Visual Studios gemacht.
2.In diesem Spiel kann man vom Programm eine Zahl verlangen und sie gibt dir, dann eine, welche du mit versuchen herausfinden kannst.
3.Sowie habe ich auch Sachen mit einem Code farbig gemacht.


2.
```csharp
Console.ForegroundColor = ConsoleColor.Cyan;
                          Console.Write("Wählen Sie eine Zahl zwischen " + min + " - " + max + ":");
                          Console.ForegroundColor = ConsoleColor.Green;
                          int Zahleingabe = Convert.ToInt32(Console.ReadLine());
                          Console.ForegroundColor = ConsoleColor.White;
                          Random rnd = new Random();
```


3.
```csharp
  Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ihre Zahl ist zu gross.");
                            Console.ForegroundColor = ConsoleColor.White;
```  

## Verifikation

2. Hier sieht man, dass ich bei "Console.Write("Wählen Sie eine Zahl zwischen "+ min + " - " + max + ":""eine Funktion eingebaut habe, womit man seine Zahl wählen kann.

3. Hier sieht man, dass ich im Code Farben eingefügt habe "ConsoleColor.Red;"


# Reflexion zum Arbeitsprozess

👍 Ich bin zufrieden mit meiner Arbeit, da ich einiges dazugelernt habe und konnte das Projekt fertigstellen.

👎 Ich bin nicht zufrieden mit meiner Planung, ich habe am Anfang zu wenig oder zu schlecht geplant und kam am Ende wegen des Lernberichtes in den Stress.

**VBV**: Ich hätte wohl mich besser planen sollen sowie die Sachen, die ich in der Schule nicht verstehe, Zuhause nachschauen.

        
