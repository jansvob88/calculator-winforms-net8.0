using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Calculation
	{
		private double? firstNumber;
		private double? secondNumber;
		private Operation? activeOperation;

		public double? Result { get; private set; }
		public bool Finished { get; private set; }
		public string History { get; private set; }
		public double Memory { get; private set; }
		public bool MemoryStored { get; private set; }

		public Calculation()
		{
			NewCalculation();
			Memory = 0;
			MemoryStored = false;
		}

		/// <summary>
		/// Zahájí novou kalkulaci.<br/>
		/// Paměť <see cref="Memory"/> zůstane nedotčena.
		/// </summary>
		public void NewCalculation()
		{
			firstNumber = null;
			secondNumber = null;
			activeOperation = null;
			Result = null;
			Finished = false;
			History = string.Empty;
		}

		/// <summary>
		/// Při prvním použití je <paramref name="number"/> uloženo jako firstNumber a <paramref name="operation"/> jako activeOperation.<br/>
		/// Při každém dalším použití je <paramref name="number"/> uloženo jako secondNumber, volá se metoda <see cref="Calculate"/>,
		/// firstNumber je nahrazeno výsledkem kalkulace a activeOperation je nahrazena nově přijatým parametrem <paramref name="operation"/>.<br/>
		/// Tato sekvence se opakuje dokud v parametru <paramref name="operation"/> nepřijde operace <see cref="Operation.Equals"/>, čímž je aktuální výpočet ukončen
		/// a <see langword="bool"/> <see cref="Finished"/> je nastaven na <see langword="true"/>.
		/// </summary>
		/// <param name="number"></param>
		/// <param name="operation"></param>
		public void Next(double number, Operation operation)
		{
			if (!Finished)
			{
				History += number + " " + TextManager.ToString(operation) + " ";

				if (firstNumber == null)
				{
					firstNumber = number;
					Result = number;
				}
				else
				{
					secondNumber = number;
					Calculate();
					firstNumber = Result;
				}

				activeOperation = operation;

				if (operation == Operation.Equals)
				{
					History += Result;
					Finished = true;
				}
			}
		}

		/// <summary>
		/// Změní hodnotu <see cref="activeOperation"/>.
		/// </summary>
		/// <param name="operation"></param>
		public void ChangeOperation(Operation operation)
		{
			if (!Finished)
			{
				History = History.Remove(History.Length - 1 - TextManager.ToString(activeOperation).Length);
				History += TextManager.ToString(operation) + " ";
				activeOperation = operation;
			}
		}

		/// <summary>
		/// Přičte hodnotu do paměti kalkulačky a nastaví <see langword="bool"/> <see cref="MemoryStored"/> = <see langword="true"/>.<br/>
		/// Pro odečtení od paměti vložte do parametru zápornou hodnotu.
		/// </summary>
		/// <param name="number">Hodnota, která se přičte do paměti.</param>
		public void AddToMemory(double number)
		{
			Memory += number;
			MemoryStored = true;
		}

		/// <summary>
		/// Nastaví hodnotu v paměti kalkulačky na O a nastaví <see langword="bool"/> <see cref="MemoryStored"/> = <see langword="false"/>.
		/// </summary>
		public void ClearMemory()
		{
			Memory = 0;
			MemoryStored = false;
		}

		/// <summary>
		/// Provede matematickou operaci <see cref="activeOperation"/> mezi <see cref="firstNumber"/> a <see cref="secondNumber"/>.<br/>
		/// Výsledek operace je uložen do <see cref="Result"/>.
		/// </summary>
		private void Calculate()
		{
			switch (activeOperation)
			{
				case Operation.Add:
					Result = firstNumber + secondNumber;
					break;
				case Operation.Subtract:
					Result = firstNumber - secondNumber;
					break;
				case Operation.Multiply:
					Result = firstNumber * secondNumber;
					break;
				case Operation.Divide:
					if (secondNumber != 0)
						Result = firstNumber / secondNumber;
					break;
			}
		}
	}
}