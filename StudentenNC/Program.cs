using System;

namespace StudentenNC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe: Erstelle ein Programm mit einer Liste von Studenten
            // Verwende für den Stundenten eine Klasse
            // Jeder Student hat einen Notendurchschnitt
            // Berechne dann den durschnittlichen Notendurchschnitt aller Studenten mit einer Schleife

            bool programm = true;
            students dieStudenten = new students();

            conversationLine("Was möchten Sie tun?");
            spaceLine();

            while (programm == true)
            {
                bool addStudent = true;
                bool repeat = true;
                conversationLine("(1) Schüler Hinzufügen");
                conversationLine("(2) Gesammtdurchschnitt berechnen");
                conversationLine("(3) Beenden");
                spaceLine();
                conversationAsk("Bitte geben Sie ihre Eingabe an: ");
                string getAnswer = Console.ReadLine();
                spaceLine();

                if (getAnswer == "1")
                {

                    while (addStudent == true)
                    {
                        Console.Clear();
                        conversationLine("Sie 'haben Schüler Hinzufügen' gewählt!");
                        conversationAsk("War diese Eingabe korrekt? (ja/nein): ");
                        string getAnswer2 = Console.ReadLine().ToLower();
                        spaceLine();

                        if (getAnswer2 == "ja")
                        {
                            
                            conversationLine("Sie haben mit 'ja' geantwortet!");
                            spaceLine();
                            while (repeat == true)
                            {                                
                                conversationAsk("Bitte geben Sie den Namen des Schülers ein: ");
                                string getName = Console.ReadLine();
                                conversationAsk("Bitte geben Sie nun den Notendurchschnitt an: ");
                                float getNC = float.Parse(Console.ReadLine());
                                spaceLine();
                                conversationLine("Bitte überprüfen Sie ihre Eingaben:");
                                conversationLine("Name: " + getName);
                                conversationLine("Notendurchschnitt: " + getNC);
                                spaceLine();
                                conversationAsk("War die Eingabe korrekt? (ja/nein/beenden): ");
                                string getAnswer3 = Console.ReadLine().ToLower();
                                spaceLine();

                                if (getAnswer3 == "ja")
                                {
                                    dieStudenten.AddStudenten(getName, getNC);
                                    conversationLine("Schüler " + getName + " wurde Hinzugefügt!");
                                    conversationAsk("Möchten Sie einen weitern schüler Hinzufügen? (ja/Nein): ");
                                    string getAnswer4 = Console.ReadLine().ToLower();
                                    spaceLine();

                                    if (getAnswer4 == "ja")
                                    {
                                        conversationLine("Sie haben mit 'ja' geantwortet!");
                                        spaceLine();
                                    }
                                    else if (getAnswer4 == "nein")
                                    {
                                        conversationLine("Sie haben mit 'nein' geantwortet. Wir kehren nun zum Menü zurück!");
                                        spaceLine();
                                        repeat = false;
                                        addStudent = false;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        conversationLine("Ihre Eingabe war nicht korrekt. Bitte wiederholen!");
                                        spaceLine();
                                    }
                                }
                                else if (getAnswer3 == "nein")
                                {
                                    conversationLine("Sie haben mit 'nein' geantwortet. Bitte wiederholen Sie ihre eingabe!");
                                    spaceLine();
                                }
                                else if (getAnswer3 == "beenden")
                                {
                                    conversationLine("Sie haben mit 'beenden' geantwortet. Wir kehren nun zum Menü zurück!");
                                    spaceLine();
                                    addStudent = false;
                                    repeat = false;
                                    Console.Clear();
                                }
                                else
                                {
                                    conversationLine("Ihre Eingabe war nicht korrekt. Bitte wiederholen!");
                                    spaceLine();
                                }
                            }
                        }
                        else if (getAnswer2 == "nein")
                        {
                            conversationLine("Sie haben mit 'nein' geantwortet. Wir kehren nun zum Menü zurück!");
                            spaceLine();
                            addStudent = false;
                            Console.Clear();
                        }
                        else
                        {
                            conversationLine("Ihre Eingabe war nicht korrekt. Bitte wiederholen!");
                            spaceLine();                            
                        }
                    }
                }
                else if (getAnswer == "2")
                {
                    Console.Clear();
                    conversationLine("Sie haben 'Gesammtdurchschnitt berechnen' gewählt!");
                    conversationAsk("War diese Eingabe korrekt? (ja/nein): ");
                    string getAnswer4 = Console.ReadLine().ToLower();
                    spaceLine();

                    if (getAnswer4 == "ja")
                    {
                        dieStudenten.ShowNC();
                        spaceLine();
                        conversationLine("Bitte drücken Sie eine beliebige 'Taste' um zum Menü zurück zu kehren!");
                        Console.ReadKey();
                        spaceLine();
                        Console.Clear();
                    }
                    else if (getAnswer4 == "nein")
                    {
                        conversationLine("Sie haben mit 'nein' geantwortet. Wir kehren nun zum Menü zurück!");
                        spaceLine();
                        Console.Clear();
                    }
                    else
                    {
                        conversationLine("Ihre Eingabe war nicht korrekt. Bitte wiederholen!");
                        spaceLine();
                    }
                }
                else if (getAnswer == "3")
                {
                    conversationLine("Vielen Dank! Bitte beehren Sie uns bald wieder <3");
                    spaceLine();
                    conversationLine("Bitte nun beliebige Taste zum Beenden drücken. . .");
                    Console.ReadKey();
                    programm = false;
                }
            }
        }

        // Ausgabe reiner Text
        static void conversationLine(string sentence)
        {
            Console.WriteLine(sentence);
        }

        // Ausgabe Anfrage an den Benutzer
        static void conversationAsk(string question)
        {
            Console.Write(question);
        }

        // Leere Zeile
        static void spaceLine()
        {
            Console.WriteLine();
        }
    }
}
