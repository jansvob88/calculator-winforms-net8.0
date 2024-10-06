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

		private string lastOperation;
		private ActionType lastAction;

		private bool resultDisplayed;

		private Calculation calculation;
		private MainForm mainForm;

		public Director(MainForm mainForm)
		{
			calculation = new Calculation();
			this.mainForm = mainForm;

			EntryText = "0";
			HistoryText = string.Empty;
			MemoryText = string.Empty;

			lastOperation = string.Empty;
			lastAction = ActionType.None;

			resultDisplayed = false;
		}

		/// <summary>
		/// Předává potřebné informace o ovládacím prvku metodě <see cref="RedirectAction(ActionType, string)"/>
		/// </summary>
		/// <param name="control"></param>
		public void Action(Control control)
		{
			ActionType actionType = ActionType.None;
			string actionText = string.Empty;

			actionType = CategoryManager.ControlActionType(control);

			if (control is Button)
				actionText = ((Button)control).Text;

			if (control is Label)
				actionText = ((Label)control).Text;

			RedirectAction(actionType, actionText);
		}

		/// <summary>
		/// Volá jednu ze 4 hlavních metod kalkulačky.<br/>
		/// Rovněž uchovává údaj o typu poslední provedené akce.
		/// </summary>
		/// <param name="actionType"></param>
		/// <param name="actionText"></param>
		private void RedirectAction(ActionType actionType, string actionText)
		{
			if (calculation.Finished && (actionType == ActionType.Operation || actionType == ActionType.Number))
			{
				Reset();
			}

			switch (actionType)
			{
				case ActionType.Number:
					ActionNumber(actionText);
					break;

				case ActionType.Operation:
					ActionOperation(actionText);
					break;

				case ActionType.Clear:
					ActionClear(actionText);
					break;

				case ActionType.Memory:
					ActionMemory(actionText);
					mainForm.ToggleMemoryLabels(calculation.MemoryStored);
					break;
			}

			lastAction = actionType;
		}

		/// <summary>
		/// Provádí zápis čísla uživatelem na displej.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Number"/>.
		/// </summary>
		/// <param name="number">Přijatelné hodnoty: "0"-"9" a ","</param>
		private void ActionNumber(string number)
		{
			if (resultDisplayed)
			{
				EntryText = "0";
				resultDisplayed = false;
			}
			if (number != "," && EntryText == "0")
			{
				EntryText = string.Empty;
			}
			if (number == ",")
			{
				if (EntryText.Contains(","))
					return;
			}

			EntryText += number;
		}

		/// <summary>
		/// Předává aktuální číslo na displeji a zvolenou matematickou operaci třídě <see cref="Calculation"/>.<br/>
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Operation"/>.
		/// </summary>
		/// <param name="operation">Přijatelné hodnoty: "+", "-", "*", "/", "="</param>
		private void ActionOperation(string operation)
		{
			if (lastAction == ActionType.Operation && operation != "=")
			{
				calculation.ChangeOperation(operation);
				lastOperation = operation;

				HistoryText = calculation.History;
			}
			else if (lastOperation == "/" && (EntryText == "0" || EntryText == "0,"))
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
		/// Metoda je volána při stisknutí ovládacího prvku typu <see cref="ActionType.Clear"/>.
		/// </summary>
		/// <param name="controlText">Přijatelné hodnoty: "CE", "C", ""(prázdný řetězec pro Backspace)</param>
		private void ActionClear(string controlText)
		{
			switch (controlText)
			{
				//Button Clear Entry
				case "CE":
					EntryText = "0";
					break;
				//Button Clear
				case "C":
					EntryText = "0";
					Reset();
					break;
				//Button Backspace
				//tento ovládací prvek jako jediný nemá nastavenou vlastnost Text, ale obsahuje obrázek.
				case "":
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
		/// <param name="controlText">Přijatelné hodnoty: "M+", "M-", "MC", "MR"</param>
		private void ActionMemory(string controlText)
		{
			switch (controlText)
			{
				case "M+":
					calculation.AddToMemory(double.Parse(EntryText));
					MemoryText = "M " + calculation.Memory;
					break;
				case "M-":
					calculation.AddToMemory(-double.Parse(EntryText));
					MemoryText = "M " + calculation.Memory;
					break;
				case "MC":
					calculation.ClearMemory();
					break;
				case "MR":
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

			lastOperation = string.Empty;
			lastAction = ActionType.None;
		}
	}
}
