namespace Calculator
{
	public partial class MainForm : Form
	{
		private Director director;
		public MainForm()
		{
			InitializeComponent();
			director = new Director(this);

			CategorizeControls();
			ToggleMemoryLabels(false);
		}

		/// <summary>
		/// P�i�ad� kontroln�m prvk�m Tag podle toho jakou funkci maj� vykon�vat.
		/// </summary>
		private void CategorizeControls()
		{
			buttonZero.Tag = CategoryManager.GenerateTag(Number.Zero);
			buttonOne.Tag = CategoryManager.GenerateTag(Number.One);
			buttonTwo.Tag = CategoryManager.GenerateTag(Number.Two);
			buttonThree.Tag = CategoryManager.GenerateTag(Number.Three);
			buttonFour.Tag = CategoryManager.GenerateTag(Number.Four);
			buttonFive.Tag = CategoryManager.GenerateTag(Number.Five);
			buttonSix.Tag = CategoryManager.GenerateTag(Number.Six);
			buttonSeven.Tag = CategoryManager.GenerateTag(Number.Seven);
			buttonEight.Tag = CategoryManager.GenerateTag(Number.Eight);
			buttonNine.Tag = CategoryManager.GenerateTag(Number.Nine);
			buttonComma.Tag = CategoryManager.GenerateTag(Number.Comma);

			buttonAdd.Tag = CategoryManager.GenerateTag(Operation.Add);
			buttonSubtract.Tag = CategoryManager.GenerateTag(Operation.Subtract);
			buttonMultiply.Tag = CategoryManager.GenerateTag(Operation.Multiply);
			buttonDivide.Tag = CategoryManager.GenerateTag(Operation.Divide);
			buttonEquals.Tag = CategoryManager.GenerateTag(Operation.Equals);

			buttonClear.Tag = CategoryManager.GenerateTag(Function.Clear);
			buttonClearEntry.Tag = CategoryManager.GenerateTag(Function.ClearEntry);
			buttonBackspace.Tag = CategoryManager.GenerateTag(Function.Backspace);

			labelMemoryClear.Tag = CategoryManager.GenerateTag(Memory.Clear);
			labelMemoryRecall.Tag = CategoryManager.GenerateTag(Memory.Recall);
			labelMemoryAdd.Tag = CategoryManager.GenerateTag(Memory.Add);
			labelMemorySubtract.Tag = CategoryManager.GenerateTag(Memory.Subtract);
		}

		/// <summary>
		/// Metoda je vol�na p�i stisknut� kter�hokoliv ovl�dac�ho prvku.<br/>
		/// Odes�l� dan� ovl�dac� prvek instanci t��dy <see cref="Director"/>.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ControlClicked(object sender, EventArgs e)
		{
			director.Action(sender as Control);
		}

		/// <summary>
		/// Metoda je vol�na p�i stisknut� kter�koliv kl�vesy na kl�vesnici.<br/>
		/// Odes�l� stisknutou kl�vesu t��d� <see cref="Director"/>.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KeyPressed(object sender, KeyEventArgs e)
		{
			director.Action(e.KeyCode);
		}
		/// <summary>
		/// Nastav� labelEntry.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateEntry(string text)
		{
			labelEntry.Text = text;
		}

		/// <summary>
		/// Nastav� labelHistory.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateHistory(string text)
		{
			labelHistory.Text = text;
		}

		/// <summary>
		/// Nastav� labelMemoryValue.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateMemory(string text)
		{
			labelMemoryValue.Text = text;
		}

		/// <summary>
		/// Vyp�n� a zap�n� ovl�dac� prvky labelMemoryClear, labelMemoryRecall a labelMemoryValue.
		/// </summary>
		/// <param name="toggle"><see langword="true"/> zapnout; <see langword="false"/> vypnout.</param>
		public void ToggleMemoryLabels(bool toggle)
		{
			labelMemoryClear.Enabled = toggle;
			labelMemoryRecall.Enabled = toggle;
			labelMemoryValue.Visible = toggle;
		}
	}
}