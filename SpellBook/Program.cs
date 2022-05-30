using System;
using System.Collections.Generic;
using System.Linq;

namespace SpellBook{
	internal class Program{
		private List<Spell> SpellBook = new List<Spell>(); 

		private void Start(){
			while(true){
				Console.Clear();
				Console.WriteLine("1. Vygenerovat nový spell a přidat do Spellbooku");
				Console.WriteLine("2. Zobrazit Spellbook");
				Console.WriteLine("3. Smazat poslední záznam ve Spellbooku");
				Console.WriteLine("4. Smazat celý Spellbook");
				Console.WriteLine("*. Ukončit aplikaci");

				string input = Console.ReadLine();

				switch(input){
					case "1":
						Spell newSpell = new Spell();
						this.SpellBook.Add(newSpell);

						Console.WriteLine($"Byl přidán nový spell {newSpell.SpellName}, manaCost: {newSpell.ManaCost}");
						break;
					case "2":
						Console.WriteLine(string.Join("\n", this.SpellBook.Select(x => $"{x.SpellName} ({x.ManaCost})")));
						break;
					case "3":
						int lastIndex = this.SpellBook.Count - 1;
						Spell lastSpell = this.SpellBook[lastIndex];

						this.SpellBook.RemoveAt(lastIndex);
						Console.WriteLine($"Spell {lastSpell.SpellName} byl smazán ze seznamu");
						break;
					case "4":
						this.SpellBook.Clear();
						Console.WriteLine($"SpellBook byl smazán");
						break;
					case "*":
						Environment.Exit(0);
						break;
				}

				Console.WriteLine("Stiskni enter pro pokračování");
				Console.ReadLine();
			}
		}

		public static void Main() => new Program().Start();
	}
}