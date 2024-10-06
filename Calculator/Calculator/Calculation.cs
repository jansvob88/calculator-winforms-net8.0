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
		private string activeOperation;

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
		/// Vymaže údaje o aktuálně prováděném výpočtu.<br/>
		/// Paměť <see cref="Memory"/> zůstane nedotčena.
		/// </summary>
		public void NewCalculation()
		{
			firstNumber = null;
			secondNumber = null;
			activeOperation = string.Empty;
			Result = null;
			Finished = false;
			History = string.Empty;
		}

		/// <summary>
		/// Při prvním použití je <paramref name="number"/> uloženo jako firstNumber a <paramref name="operation"/> jako activeOperation.<br/>
		/// Při každém dalším použití je <paramref name="number"/> uloženo jako secondNumber, volá se metoda <see cref="Calculate"/>,
		/// firstNumber je nahrazeno výsledkem kalkulace a activeOperation je nahrazena nově přijatým parametrem <paramref name="operation"/>.<br/>
		/// Tato sekvence se opakuje dokud v parametru <paramref name="operation"/> nepřijde operace "=", čímž je aktuální výpočet ukončen
		/// a <see langword="bool"/> <see cref="Finished"/> je nastaven na <see langword="true"/>.
		/// </summary>
		/// <param name="number"></param>
		/// <param name="operation"></param>
		public void Next(double number, string operation)
		{
			History += number + " " + operation + " ";

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

			if (operation == "=")
			{
				History += Result;
				Finished = true;
			}
		}

		/// <summary>
		/// Změní hodnotu <see cref="activeOperation"/>.
		/// </summary>
		/// <param name="operation"></param>
		public void ChangeOperation(string operation)
		{
			activeOperation = operation;
			History = History.Remove(History.Length - 2);
			History += operation + " ";
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
				case "+":
					Result = firstNumber + secondNumber;
					break;
				case "-":
					Result = firstNumber - secondNumber;
					break;
				case "*":
					Result = firstNumber * secondNumber;
					break;
				case "/":
					if (secondNumber != 0)
						Result = firstNumber / secondNumber;
					break;
			}
		}
	}
}