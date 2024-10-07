using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public static class TextManager
	{
		private const string numberZero = "0";
		private const string numberOne = "1";
		private const string numberTwo = "2";
		private const string numberThree = "3";
		private const string numberFour = "4";
		private const string numberFive = "5";
		private const string numberSix = "6";
		private const string numberSeven = "7";
		private const string numberEight = "8";
		private const string numberNine = "9";
		private const string numberComma = ",";

		private const string operationAdd = "+";
		private const string operationSubtract = "-";
		private const string operationMultiply = "*";
		private const string operationDivide = "/";
		private const string operationEquals = "=";

		/* Prozatím není využito
		private const string functionClear = "FC";
		private const string functionClearEntry = "FCE";
		private const string functionBackspace = "FBack";

		private const string memoryClear = "MC";
		private const string memoryRecall = "MR";
		private const string memoryAdd = "M+";
		private const string memorySubtract = "M-";
		*/

		/// <summary>
		/// Vrátí textovou reprezentaci ovládacího prvku.
		/// </summary>
		/// <param name="category"><see cref="Number"/>, <see cref="Operation"/></param>
		/// <returns>Vrátí textovou reprezentaci kategorie. Vrátí <see cref="string.Empty"/> při neúspěchu.</returns>
		public static string ToString(Enum category)
		{
			if (category is Number)
			{
				switch (category)
				{
					case Number.Zero: return numberZero;
					case Number.One: return numberOne;
					case Number.Two: return numberTwo;
					case Number.Three: return numberThree;
					case Number.Four: return numberFour;
					case Number.Five: return numberFive;
					case Number.Six: return numberSix;
					case Number.Seven: return numberSeven;
					case Number.Eight: return numberEight;
					case Number.Nine: return numberNine;
					case Number.Comma: return numberComma;
				}
			}
			else if (category is Operation)
			{
				switch (category)
				{
					case Operation.Add: return operationAdd;
					case Operation.Subtract: return operationSubtract;
					case Operation.Multiply: return operationMultiply;
					case Operation.Divide: return operationDivide;
					case Operation.Equals: return operationEquals;
				}
			}
			/* Prozatím není využito
			else if (type is Function)
			{
				switch (type)
				{
					case Function.Clear: return functionClear;
					case Function.ClearEntry: return functionClearEntry;
					case Function.Backspace: return functionBackspace;
				}
			}
			else if (type is Memory)
			{
				switch (type)
				{
					case Memory.Clear: return memoryClear;
					case Memory.Recall: return memoryRecall;
					case Memory.Add: return memoryAdd;
					case Memory.Subtract: return memorySubtract;
				}
			}
			*/
			return string.Empty;
		}
	}
}
