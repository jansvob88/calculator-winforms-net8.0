using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Director
	{
		private string entryText;
		private string historyText;
		private string memoryText;

		public string EntryText
		{
			get { return entryText; }
			private set { entryText = value; mainForm.UpdateEntry(entryText); }
		}
		public string HistoryText
		{
			get { return historyText; }
			private set { historyText = value; mainForm.UpdateHistory(historyText); }
		}
		public string MemoryText
		{
			get { return memoryText; }
			private set { memoryText = value; mainForm.UpdateMemory(memoryText); }
		}

		private Operation? lastOperation;
		private ActionType lastAction;

		private bool resultDisplayed;

		private Calculation calculation;
		private MainForm mainForm;

		public Director(MainForm mainForm)
		{
			this.mainForm = mainForm;
			calculation = new Calculation();

			EntryText = "0";
			HistoryText = string.Empty;
			MemoryText = string.Empty;

			lastOperation = null;
			lastAction = ActionType.None;

			resultDisplayed = false;
		}

		/// <summary>
		/// Předává potřebné informace o ovládacím prvku metodě <see cref="RedirectAction(ActionType, Enum)"/>.
		/// </summary>
		/// <param name="control"></param>
		public void Action(Control control)
		{
			ActionType action = CategoryManager.GetControlActionType(control);
			Enum category = CategoryManager.GetControlCategory(control);

			RedirectAction(action, category);
		}
		/// <summary>
		/// Předává potřebné informace o stisknuté klávese metodě <see cref="RedirectAction(ActionType, Enum)"/>.
		/// </summary>
		/// <param name="key"></param>
		public void Action(Keys key)
		{
			ActionType action = CategoryManager.GetKeyActionType(key);
			Enum category = CategoryManager.GetKeyCategory(key);

			RedirectAction(action, category);
		}

		/// <summary>
		/// Volá jednu ze 4 hlavních metod kalkulačky.<br/>
		/// Rovněž uchovává údaj o typu poslední provedené akce.
		/// </summary>
		/// <param name="action"></param>
		/// <param name="category"></param>
		private void RedirectAction(ActionType action, Enum category)
		{
			if (calculation.Finished && (action == ActionType.Operation || action == ActionType.Number))
			{
				Reset();
			}

			switch (action)
			{
				case ActionType.Number:
					ActionNumber((Number)category);
					break;

				case ActionType.Operation:
					ActionOperation((Operation)category);
					break;

				case ActionType.Function:
					ActionFunction((Function)category);
					break;

				case ActionType.Memory:
					ActionMemory((Memory)category);
					mainForm.ToggleMemoryLabels(calculation.MemoryStored);
					break;
			}

			lastAction = action;
		}

		/// <summary>
		/// Provádí zápis čísla uživatelem na displej.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Number"/>.
		/// </summary>
		/// <param name="number"></param>
		private void ActionNumber(Number number)
		{
			if (resultDisplayed)
			{
				EntryText = "0";
				resultDisplayed = false;
			}
			if (number != Number.Comma && EntryText == "0")
			{
				EntryText = string.Empty;
			}
			if (number == Number.Comma)
			{
				if (EntryText.Contains(","))
					return;
			}

			EntryText += TextManager.ToString(number);
		}

		/// <summary>
		/// Předává aktuální číslo na displeji a zvolenou matematickou operaci třídě <see cref="Calculation"/>.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Operation"/>.
		/// </summary>
		/// <param name="operation"></param>
		private void ActionOperation(Operation operation)
		{
			if (lastAction == ActionType.Operation && operation != Operation.Equals)
			{
				calculation.ChangeOperation(operation);
				lastOperation = operation;

				HistoryText = calculation.History;
			}
			else if (lastOperation == Operation.Divide && (EntryText == "0" || EntryText == "0,"))
			{
				MessageBox.Show("Nulou nelze dělit!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				calculation.Next(double.Parse(EntryText), operation);
				lastOperation = operation;

				EntryText = calculation.Result.ToString();
				resultDisplayed = true;

				HistoryText = calculation.History;
			}
		}

		/// <summary>
		/// Obsluha tlačítek CE (ClearEntry), C (Clear) a Backspace.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Function"/>.
		/// </summary>
		/// <param name="function"></param>
		private void ActionFunction(Function function)
		{
			switch (function)
			{
				case Function.ClearEntry:
					EntryText = "0";
					break;

				case Function.Clear:
					EntryText = "0";
					Reset();
					break;

				case Function.Backspace:
					if (resultDisplayed)
					{
						break;
					}
					if (EntryText.Length > 1)
					{
						EntryText = EntryText.Remove(EntryText.Length - 1);
					}
					else if (EntryText != "0")
					{
						EntryText = "0";
					}
					break;
			}
		}

		/// <summary>
		/// Obsluha ovládacích prvků pro práci s pamětí kalkulačky.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Memory"/>
		/// </summary>
		/// <param name="memory"></param>
		private void ActionMemory(Memory memory)
		{
			switch (memory)
			{
				case Memory.Add:
					calculation.AddToMemory(double.Parse(EntryText));
					MemoryText = "M " + calculation.Memory;
					break;

				case Memory.Subtract:
					calculation.AddToMemory(-double.Parse(EntryText));
					MemoryText = "M " + calculation.Memory;
					break;

				case Memory.Clear:
					calculation.ClearMemory();
					break;

				case Memory.Recall:
					EntryText = calculation.Memory.ToString();
					resultDisplayed = false;
					break;
			}
		}

		/// <summary>
		/// Resetuje kalkulačku na nový výpočet.
		/// </summary>
		private void Reset()
		{
			calculation.NewCalculation();
			HistoryText = string.Empty;

			lastOperation = null;
			lastAction = ActionType.None;
		}
	}
}
