namespace SpellBook{
	public class Spell{
		public string SpellName{ get; private set; }
		public int ManaCost{ get; private set; }

		public Spell(){
			this.SpellName = HelperClass.GenerateSpellName("SpellForms.txt", "SpellTypes.txt");
			this.ManaCost = HelperClass.GenerateSpellCost();
		}
	}
}