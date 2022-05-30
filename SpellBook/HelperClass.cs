using System;
using System.IO;

namespace SpellBook{
	public static class HelperClass{
		private static Random random = new Random();

		public static string[] BuildField(this string fileName){
			string AssetsLocation = Path.Combine(Environment.CurrentDirectory, $"Assets/{fileName}");

			if(!File.Exists(AssetsLocation)){
				return null;
			}

			return File.ReadAllText(AssetsLocation).Split(';');
		}

		public static string GenerateSpellName(string spellForms, string spellTypes){
			string[] spellFormsField = BuildField(spellForms);
			string[] spellTypesField = BuildField(spellTypes);

			return $"{spellFormsField[HelperClass.random.Next(0, spellFormsField.Length)]} {spellTypesField[HelperClass.random.Next(0, spellTypesField.Length)]}";
		}

		public static int GenerateSpellCost(){
			return HelperClass.random.Next(0, HelperClass.random.Next(10, 25));
		}
	}
}