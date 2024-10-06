namespace Calculator
{
	public partial class MainForm : Form
	{
		private Director director;
		public MainForm()
		{
			InitializeComponent();

			director = new Director(this);

			labelEntry.Text = "0";
			labelHistory.Text = string.Empty;

			ToggleMemoryLabels(false);
		}

		/// <summary>
		/// Metoda je volána pøi stisknutí kteréhokoliv ovládacího prvku.<br/>
		/// Odesílá daný ovládací prvek instanci tøídy <see cref="Director"/>.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ControlClicked(object sender, EventArgs e)
		{
			director.Action(sender as Control);
		}

		/// <summary>
		/// Nastaví labelEntry.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateEntry(string text)
		{
			labelEntry.Text = text;
		}

		/// <summary>
		/// Nastaví labelHistory.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateHistory(string text)
		{
			labelHistory.Text = text;
		}

		/// <summary>
		/// Nastaví labelMemoryValue.Text
		/// </summary>
		/// <param name="text"></param>
		public void UpdateMemory(string text)
		{
			labelMemoryValue.Text = text;
		}

		/// <summary>
		/// Vypíná a zapíná ovládací prvky labelMemoryClear, labelMemoryRecall a labelMemoryValue.
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