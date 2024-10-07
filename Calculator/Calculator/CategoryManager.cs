using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public enum ActionType { None, Number, Operation, Function, Memory }
	public enum Number { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Comma}
	public enum Operation { Add, Subtract, Multiply, Divide, Equals }
	public enum Function { Clear, ClearEntry, Backspace }
	public enum Memory { Clear, Recall, Add, Subtract }

	public static class CategoryManager
	{
		private const string actionNone = "None";
		private const string actionNumber = "Number";
		private const string actionOperation = "Operation";
		private const string actionFunction = "Function";
		private const string actionMemory = "Memory";

		private const string numberZero = "Zero";
		private const string numberOne = "One";
		private const string numberTwo = "Two";
		private const string numberThree = "Three";
		private const string numberFour = "Four";
		private const string numberFive = "Five";
		private const string numberSix = "Six";
		private const string numberSeven = "Seven";
		private const string numberEight = "Eight";
		private const string numberNine = "Nine";
		private const string numberComma = "Comma";

		private const string operationAdd = "Add";
		private const string operationSubtract = "Subtract";
		private const string operationMultiply = "Multiply";
		private const string operationDivide = "Divide";
		private const string operationEquals = "Equals";

		private const string functionClear = "Clear";
		private const string functionClearEntry = "ClearEntry";
		private const string functionBackspace = "Backspace";

		private const string memoryClear = "Clear";
		private const string memoryRecall = "Recall";
		private const string memoryAdd = "Add";
		private const string memorySubtract = "Subtract";

		/// <summary>
		/// Vygeneruje unikátní Tag pro ovládací prvek podle toho jakou funkci má zastávat.
		/// </summary>
		/// <param name="category">
		/// <see cref="Number"/>, <see cref="Operation"/>, <see cref="Function"/>, <see cref="Memory"/>
		/// </param>
		/// <returns></returns>
		public static string GenerateTag(Enum category)
		{
			string tag = string.Empty;

			if (category is Number)
			{
				tag += actionNumber;

				switch (category)
				{
					case Number.Zero: tag += numberZero; break;
					case Number.One: tag += numberOne; break;
					case Number.Two: tag += numberTwo; break;
					case Number.Three: tag += numberThree; break;
					case Number.Four: tag += numberFour; break;
					case Number.Five: tag += numberFive; break;
					case Number.Six: tag += numberSix; break;
					case Number.Seven: tag += numberSeven; break;
					case Number.Eight: tag += numberEight; break;
					case Number.Nine: tag += numberNine; break;
					case Number.Comma: tag += numberComma; break;
				}
			}
			else if (category is Operation)
			{
				tag += actionOperation;

				switch (category)
				{
					case Operation.Add: tag += operationAdd; break;
					case Operation.Subtract: tag += operationSubtract; break;
					case Operation.Multiply: tag += operationMultiply; break;
					case Operation.Divide: tag += operationDivide; break;
					case Operation.Equals: tag += operationEquals; break;
				}
			}
			else if (category is Function)
			{
				tag += actionFunction;

				switch (category)
				{
					case Function.Clear: tag += functionClear; break;
					case Function.ClearEntry: tag += functionClearEntry; break;
					case Function.Backspace: tag += functionBackspace; break;
				}
			}
			else if (category is Memory)
			{
				tag += actionMemory;

				switch (category)
				{
					case Memory.Clear: tag += memoryClear; break;
					case Memory.Recall: tag += memoryRecall; break;
					case Memory.Add: tag += memoryAdd; break;
					case Memory.Subtract: tag += memorySubtract; break;
				}
			}
			else
			{
				tag += actionNone;
			}
			return tag;
		}

		/// <summary>
		/// Vrátí kategorii ovládacího prvku na základě jeho Tagu.
		/// </summary>
		/// <param name="control"></param>
		/// <returns><see cref="Number"/>, <see cref="Operation"/>, <see cref="Function"/>, <see cref="Memory"/>.<br/>
		/// Vrátí <see cref="ActionType.None"/> při neúspěchu.</returns>
		public static Enum GetControlCategory(Control control)
		{
			return GetControlCategory(control.Tag.ToString());
		}
		private static Enum GetControlCategory(string tag)
		{
			string type = string.Empty;

			if (tag.StartsWith(actionNumber))
			{
				type = tag.Remove(0, actionNumber.Length);

				switch (type)
				{
					case numberZero: return Number.Zero;
					case numberOne: return Number.One;
					case numberTwo: return Number.Two;
					case numberThree: return Number.Three;
					case numberFour: return Number.Four;
					case numberFive: return Number.Five;
					case numberSix: return Number.Six;
					case numberSeven: return Number.Seven;
					case numberEight: return Number.Eight;
					case numberNine: return Number.Nine;
					case numberComma: return Number.Comma;
				}
			}
			else if (tag.StartsWith(actionOperation))
			{
				type = tag.Remove(0, actionOperation.Length);

				switch (type)
				{
					case operationAdd: return Operation.Add;
					case operationSubtract: return Operation.Subtract;
					case operationMultiply: return Operation.Multiply;
					case operationDivide: return Operation.Divide;
					case operationEquals: return Operation.Equals;
				}
			}
			else if (tag.StartsWith(actionFunction))
			{
				type = tag.Remove(0, actionFunction.Length);

				switch (type)
				{
					case functionClear: return Function.Clear;
					case functionClearEntry: return Function.ClearEntry;
					case functionBackspace: return Function.Backspace;
				}
			}
			else if (tag.StartsWith(actionMemory))
			{
				type = tag.Remove(0, actionMemory.Length);

				switch (type)
				{
					case memoryClear: return Memory.Clear;
					case memoryRecall: return Memory.Recall;
					case memoryAdd: return Memory.Add;
					case memorySubtract: return Memory.Subtract;
				}
			}
			return ActionType.None;
		}

		/// <summary>
		/// Vrátí <see cref="ActionType"/> ovládacího prvku na základě jeho Tagu.
		/// </summary>
		/// <param name="control"></param>
		/// <returns><see cref="ActionType"/.<br/>
		/// Vrátí <see cref="ActionType.None"/> při neúspěchu.</returns>
		public static ActionType GetControlActionType(Control control)
		{
			return GetControlActionType(control.Tag.ToString());
		}
		private static ActionType GetControlActionType(string tag)
		{
			if (tag.StartsWith(actionNumber)) return ActionType.Number;
			else if (tag.StartsWith(actionOperation)) return ActionType.Operation;
			else if (tag.StartsWith(actionFunction)) return ActionType.Function;
			else if (tag.StartsWith(actionMemory)) return ActionType.Memory;
			else return ActionType.None;
		}

		/// <summary>
		/// Vrátí kategorii klávesy.
		/// </summary>
		/// <param name="key"></param>
		/// <returns><see cref="Number"/>, <see cref="Operation"/>, <see cref="Function"/>.<br/>
		/// Vrátí <see cref="ActionType.None"/> při neúspěchu.</returns>
		public static Enum GetKeyCategory(Keys key)
		{
			ActionType actionType = GetKeyActionType(key);

			if (actionType == ActionType.Number)
			{
				switch (key)
				{
					case Keys.NumPad0:
					case Keys.D0:
						return Number.Zero;
					case Keys.NumPad1:
					case Keys.D1:
						return Number.One;
					case Keys.NumPad2:
					case Keys.D2:
						return Number.Two;
					case Keys.NumPad3:
					case Keys.D3:
						return Number.Three;
					case Keys.NumPad4:
					case Keys.D4:
						return Number.Four;
					case Keys.NumPad5:
					case Keys.D5:
						return Number.Five;
					case Keys.NumPad6:
					case Keys.D6:
						return Number.Six;
					case Keys.NumPad7:
					case Keys.D7:
						return Number.Seven;
					case Keys.NumPad8:
					case Keys.D8:
						return Number.Eight;
					case Keys.NumPad9:
					case Keys.D9:
						return Number.Nine;
					case Keys.Decimal:
					case Keys.Oemcomma:
						return Number.Comma;
				}
			}
			else if (actionType == ActionType.Operation)
			{
				switch (key)
				{
					case Keys.Add: return Operation.Add;
					case Keys.Subtract: return Operation.Subtract;
					case Keys.Multiply: return Operation.Multiply;
					case Keys.Divide: return Operation.Divide;

					case Keys.Enter: case Keys.Oemplus: return Operation.Equals;
				}
			}
			else if (actionType == ActionType.Function)
			{
				switch (key)
				{
					case Keys.C: return Function.Clear;
					case Keys.E: return Function.ClearEntry;
					case Keys.Back: return Function.Backspace;
				}
			}
			return ActionType.None;
		}
		/// <summary>
		/// Vrátí <see cref="ActionType"/> klávesy.
		/// </summary>
		/// <param name="key"></param>
		/// <returns><see cref="ActionType"/>.<br/>
		/// Vrátí <see cref="ActionType.None"/> při neúspěchu.</returns>
		public static ActionType GetKeyActionType(Keys key)
		{
			switch (key)
			{
				case Keys.NumPad0: case Keys.NumPad1: case Keys.NumPad2: case Keys.NumPad3:	case Keys.NumPad4:
				case Keys.NumPad5: case Keys.NumPad6: case Keys.NumPad7: case Keys.NumPad8:	case Keys.NumPad9:
				case Keys.D0: case Keys.D1:	case Keys.D2: case Keys.D3:	case Keys.D4:
				case Keys.D5: case Keys.D6:	case Keys.D7: case Keys.D8:	case Keys.D9:
				case Keys.Decimal:
				case Keys.Oemcomma:
					return ActionType.Number;

				case Keys.Add:
				case Keys.Subtract:
				case Keys.Multiply:
				case Keys.Divide:
				case Keys.Enter:
				case Keys.Oemplus:
					return ActionType.Operation;

				case Keys.C:
				case Keys.E:
				case Keys.Back:
					return ActionType.Function;

				default:
					return ActionType.None;
			}
		}
	}
}