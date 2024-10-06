using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public enum ActionType { Number, Operation, Clear, Memory, None}

	public static class CategoryManager
	{
		/// <summary>
		/// Vrací <see cref="ActionType"/> podle hodnoty vlastnosti Tag na ovládacím prvku.
		/// </summary>
		/// <param name="control"></param>
		/// <returns>
		/// Tag "Number" <see cref="ActionType.Number"/><br/>
		/// Tag "Operation" <see cref="ActionType.Operation"/><br/>
		/// Tag "Clear" <see cref="ActionType.Clear"/><br/>
		/// Tag "Memory" <see cref="ActionType.Memory"/><br/>
		/// Default <see cref="ActionType.None"/>
		/// </returns>
		public static ActionType ControlActionType(Control control)
		{
			switch (control.Tag.ToString())
			{
				case "Number":
					return ActionType.Number;
				case "Operation":
					return ActionType.Operation;
				case "Clear":
					return ActionType.Clear;
				case "Memory":
					return ActionType.Memory;
				default:
					return ActionType.None;
			}
		}
	}
}