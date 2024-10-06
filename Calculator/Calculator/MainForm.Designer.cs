namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			labelHistory = new Label();
			labelEntry = new Label();
			panelButtons = new Panel();
			labelMemoryValue = new Label();
			labelMemoryMinus = new Label();
			labelMemoryPlus = new Label();
			labelMemoryClear = new Label();
			labelMemoryRecall = new Label();
			buttonClearEntry = new Button();
			buttonClear = new Button();
			buttonBackspace = new Button();
			buttonPlus = new Button();
			buttonEquals = new Button();
			buttonDivide = new Button();
			buttonMultiply = new Button();
			buttonMinus = new Button();
			buttonComma = new Button();
			buttonZero = new Button();
			buttonSeven = new Button();
			buttonEight = new Button();
			buttonNine = new Button();
			buttonFour = new Button();
			buttonFive = new Button();
			buttonSix = new Button();
			buttonOne = new Button();
			buttonTwo = new Button();
			buttonThree = new Button();
			panelDisplay = new Panel();
			panelButtons.SuspendLayout();
			panelDisplay.SuspendLayout();
			SuspendLayout();
			// 
			// labelHistory
			// 
			labelHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelHistory.BorderStyle = BorderStyle.FixedSingle;
			labelHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			labelHistory.Location = new Point(10, 9);
			labelHistory.Name = "labelHistory";
			labelHistory.Size = new Size(378, 72);
			labelHistory.TabIndex = 1;
			labelHistory.Text = "labelHistory";
			// 
			// labelEntry
			// 
			labelEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelEntry.BorderStyle = BorderStyle.FixedSingle;
			labelEntry.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			labelEntry.Location = new Point(10, 91);
			labelEntry.Name = "labelEntry";
			labelEntry.Size = new Size(378, 39);
			labelEntry.TabIndex = 0;
			labelEntry.Text = "labelEntry";
			labelEntry.TextAlign = ContentAlignment.TopRight;
			// 
			// panelButtons
			// 
			panelButtons.Controls.Add(labelMemoryValue);
			panelButtons.Controls.Add(labelMemoryMinus);
			panelButtons.Controls.Add(labelMemoryPlus);
			panelButtons.Controls.Add(labelMemoryClear);
			panelButtons.Controls.Add(labelMemoryRecall);
			panelButtons.Controls.Add(buttonClearEntry);
			panelButtons.Controls.Add(buttonClear);
			panelButtons.Controls.Add(buttonBackspace);
			panelButtons.Controls.Add(buttonPlus);
			panelButtons.Controls.Add(buttonEquals);
			panelButtons.Controls.Add(buttonDivide);
			panelButtons.Controls.Add(buttonMultiply);
			panelButtons.Controls.Add(buttonMinus);
			panelButtons.Controls.Add(buttonComma);
			panelButtons.Controls.Add(buttonZero);
			panelButtons.Controls.Add(buttonSeven);
			panelButtons.Controls.Add(buttonEight);
			panelButtons.Controls.Add(buttonNine);
			panelButtons.Controls.Add(buttonFour);
			panelButtons.Controls.Add(buttonFive);
			panelButtons.Controls.Add(buttonSix);
			panelButtons.Controls.Add(buttonOne);
			panelButtons.Controls.Add(buttonTwo);
			panelButtons.Controls.Add(buttonThree);
			panelButtons.Dock = DockStyle.Bottom;
			panelButtons.Location = new Point(0, 134);
			panelButtons.Margin = new Padding(4);
			panelButtons.Name = "panelButtons";
			panelButtons.Size = new Size(402, 400);
			panelButtons.TabIndex = 0;
			// 
			// labelMemoryValue
			// 
			labelMemoryValue.Anchor = AnchorStyles.None;
			labelMemoryValue.AutoSize = true;
			labelMemoryValue.Location = new Point(38, 2);
			labelMemoryValue.Name = "labelMemoryValue";
			labelMemoryValue.Size = new Size(156, 21);
			labelMemoryValue.TabIndex = 23;
			labelMemoryValue.Text = "labelMemoryValue";
			// 
			// labelMemoryMinus
			// 
			labelMemoryMinus.Anchor = AnchorStyles.None;
			labelMemoryMinus.AutoSize = true;
			labelMemoryMinus.Location = new Point(330, 32);
			labelMemoryMinus.Name = "labelMemoryMinus";
			labelMemoryMinus.Size = new Size(31, 21);
			labelMemoryMinus.TabIndex = 22;
			labelMemoryMinus.Tag = "Memory";
			labelMemoryMinus.Text = "M-";
			labelMemoryMinus.Click += ControlClicked;
			// 
			// labelMemoryPlus
			// 
			labelMemoryPlus.Anchor = AnchorStyles.None;
			labelMemoryPlus.AutoSize = true;
			labelMemoryPlus.Location = new Point(231, 32);
			labelMemoryPlus.Name = "labelMemoryPlus";
			labelMemoryPlus.Size = new Size(36, 21);
			labelMemoryPlus.TabIndex = 21;
			labelMemoryPlus.Tag = "Memory";
			labelMemoryPlus.Text = "M+";
			labelMemoryPlus.Click += ControlClicked;
			// 
			// labelMemoryClear
			// 
			labelMemoryClear.Anchor = AnchorStyles.None;
			labelMemoryClear.AutoSize = true;
			labelMemoryClear.Enabled = false;
			labelMemoryClear.Location = new Point(38, 32);
			labelMemoryClear.Name = "labelMemoryClear";
			labelMemoryClear.Size = new Size(35, 21);
			labelMemoryClear.TabIndex = 20;
			labelMemoryClear.Tag = "Memory";
			labelMemoryClear.Text = "MC";
			labelMemoryClear.Click += ControlClicked;
			// 
			// labelMemoryRecall
			// 
			labelMemoryRecall.Anchor = AnchorStyles.None;
			labelMemoryRecall.AutoSize = true;
			labelMemoryRecall.Enabled = false;
			labelMemoryRecall.Location = new Point(133, 32);
			labelMemoryRecall.Name = "labelMemoryRecall";
			labelMemoryRecall.Size = new Size(35, 21);
			labelMemoryRecall.TabIndex = 19;
			labelMemoryRecall.Tag = "Memory";
			labelMemoryRecall.Text = "MR";
			labelMemoryRecall.Click += ControlClicked;
			// 
			// buttonClearEntry
			// 
			buttonClearEntry.Anchor = AnchorStyles.None;
			buttonClearEntry.BackColor = Color.White;
			buttonClearEntry.FlatAppearance.BorderSize = 0;
			buttonClearEntry.FlatStyle = FlatStyle.Flat;
			buttonClearEntry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonClearEntry.Location = new Point(10, 66);
			buttonClearEntry.Name = "buttonClearEntry";
			buttonClearEntry.Size = new Size(90, 60);
			buttonClearEntry.TabIndex = 18;
			buttonClearEntry.Tag = "Clear";
			buttonClearEntry.Text = "CE";
			buttonClearEntry.UseVisualStyleBackColor = false;
			buttonClearEntry.Click += ControlClicked;
			// 
			// buttonClear
			// 
			buttonClear.Anchor = AnchorStyles.None;
			buttonClear.BackColor = Color.White;
			buttonClear.FlatAppearance.BorderSize = 0;
			buttonClear.FlatStyle = FlatStyle.Flat;
			buttonClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonClear.Location = new Point(106, 66);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(90, 60);
			buttonClear.TabIndex = 17;
			buttonClear.Tag = "Clear";
			buttonClear.Text = "C";
			buttonClear.UseVisualStyleBackColor = false;
			buttonClear.Click += ControlClicked;
			// 
			// buttonBackspace
			// 
			buttonBackspace.Anchor = AnchorStyles.None;
			buttonBackspace.BackColor = Color.White;
			buttonBackspace.FlatAppearance.BorderSize = 0;
			buttonBackspace.FlatStyle = FlatStyle.Flat;
			buttonBackspace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonBackspace.Image = (Image)resources.GetObject("buttonBackspace.Image");
			buttonBackspace.Location = new Point(202, 66);
			buttonBackspace.Name = "buttonBackspace";
			buttonBackspace.Size = new Size(90, 60);
			buttonBackspace.TabIndex = 16;
			buttonBackspace.Tag = "Clear";
			buttonBackspace.UseVisualStyleBackColor = false;
			buttonBackspace.Click += ControlClicked;
			// 
			// buttonPlus
			// 
			buttonPlus.Anchor = AnchorStyles.None;
			buttonPlus.BackColor = Color.White;
			buttonPlus.FlatAppearance.BorderSize = 0;
			buttonPlus.FlatStyle = FlatStyle.Flat;
			buttonPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonPlus.Location = new Point(298, 264);
			buttonPlus.Name = "buttonPlus";
			buttonPlus.Size = new Size(90, 60);
			buttonPlus.TabIndex = 15;
			buttonPlus.Tag = "Operation";
			buttonPlus.Text = "+";
			buttonPlus.UseVisualStyleBackColor = false;
			buttonPlus.Click += ControlClicked;
			// 
			// buttonEquals
			// 
			buttonEquals.Anchor = AnchorStyles.None;
			buttonEquals.BackColor = Color.LightSkyBlue;
			buttonEquals.FlatAppearance.BorderSize = 0;
			buttonEquals.FlatStyle = FlatStyle.Flat;
			buttonEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonEquals.Location = new Point(202, 330);
			buttonEquals.Name = "buttonEquals";
			buttonEquals.Size = new Size(186, 60);
			buttonEquals.TabIndex = 14;
			buttonEquals.Tag = "Operation";
			buttonEquals.Text = "=";
			buttonEquals.UseVisualStyleBackColor = false;
			buttonEquals.Click += ControlClicked;
			// 
			// buttonDivide
			// 
			buttonDivide.Anchor = AnchorStyles.None;
			buttonDivide.BackColor = Color.White;
			buttonDivide.FlatAppearance.BorderSize = 0;
			buttonDivide.FlatStyle = FlatStyle.Flat;
			buttonDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonDivide.Location = new Point(298, 66);
			buttonDivide.Name = "buttonDivide";
			buttonDivide.Size = new Size(90, 60);
			buttonDivide.TabIndex = 13;
			buttonDivide.Tag = "Operation";
			buttonDivide.Text = "/";
			buttonDivide.UseVisualStyleBackColor = false;
			buttonDivide.Click += ControlClicked;
			// 
			// buttonMultiply
			// 
			buttonMultiply.Anchor = AnchorStyles.None;
			buttonMultiply.BackColor = Color.White;
			buttonMultiply.FlatAppearance.BorderSize = 0;
			buttonMultiply.FlatStyle = FlatStyle.Flat;
			buttonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonMultiply.Location = new Point(298, 132);
			buttonMultiply.Name = "buttonMultiply";
			buttonMultiply.Size = new Size(90, 60);
			buttonMultiply.TabIndex = 12;
			buttonMultiply.Tag = "Operation";
			buttonMultiply.Text = "*";
			buttonMultiply.UseVisualStyleBackColor = false;
			buttonMultiply.Click += ControlClicked;
			// 
			// buttonMinus
			// 
			buttonMinus.Anchor = AnchorStyles.None;
			buttonMinus.BackColor = Color.White;
			buttonMinus.FlatAppearance.BorderSize = 0;
			buttonMinus.FlatStyle = FlatStyle.Flat;
			buttonMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonMinus.Location = new Point(298, 198);
			buttonMinus.Name = "buttonMinus";
			buttonMinus.Size = new Size(90, 60);
			buttonMinus.TabIndex = 11;
			buttonMinus.Tag = "Operation";
			buttonMinus.Text = "-";
			buttonMinus.UseVisualStyleBackColor = false;
			buttonMinus.Click += ControlClicked;
			// 
			// buttonComma
			// 
			buttonComma.Anchor = AnchorStyles.None;
			buttonComma.BackColor = Color.White;
			buttonComma.FlatAppearance.BorderSize = 0;
			buttonComma.FlatStyle = FlatStyle.Flat;
			buttonComma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonComma.Location = new Point(106, 330);
			buttonComma.Name = "buttonComma";
			buttonComma.Size = new Size(90, 60);
			buttonComma.TabIndex = 10;
			buttonComma.Tag = "Number";
			buttonComma.Text = ",";
			buttonComma.UseVisualStyleBackColor = false;
			buttonComma.Click += ControlClicked;
			// 
			// buttonZero
			// 
			buttonZero.Anchor = AnchorStyles.None;
			buttonZero.BackColor = Color.White;
			buttonZero.FlatAppearance.BorderSize = 0;
			buttonZero.FlatStyle = FlatStyle.Flat;
			buttonZero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonZero.Location = new Point(10, 330);
			buttonZero.Name = "buttonZero";
			buttonZero.Size = new Size(90, 60);
			buttonZero.TabIndex = 9;
			buttonZero.Tag = "Number";
			buttonZero.Text = "0";
			buttonZero.UseVisualStyleBackColor = false;
			buttonZero.Click += ControlClicked;
			// 
			// buttonSeven
			// 
			buttonSeven.Anchor = AnchorStyles.None;
			buttonSeven.BackColor = Color.White;
			buttonSeven.FlatAppearance.BorderSize = 0;
			buttonSeven.FlatStyle = FlatStyle.Flat;
			buttonSeven.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonSeven.Location = new Point(10, 132);
			buttonSeven.Name = "buttonSeven";
			buttonSeven.Size = new Size(90, 60);
			buttonSeven.TabIndex = 8;
			buttonSeven.Tag = "Number";
			buttonSeven.Text = "7";
			buttonSeven.UseVisualStyleBackColor = false;
			buttonSeven.Click += ControlClicked;
			// 
			// buttonEight
			// 
			buttonEight.Anchor = AnchorStyles.None;
			buttonEight.BackColor = Color.White;
			buttonEight.FlatAppearance.BorderSize = 0;
			buttonEight.FlatStyle = FlatStyle.Flat;
			buttonEight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonEight.Location = new Point(106, 132);
			buttonEight.Name = "buttonEight";
			buttonEight.Size = new Size(90, 60);
			buttonEight.TabIndex = 7;
			buttonEight.Tag = "Number";
			buttonEight.Text = "8";
			buttonEight.UseVisualStyleBackColor = false;
			buttonEight.Click += ControlClicked;
			// 
			// buttonNine
			// 
			buttonNine.Anchor = AnchorStyles.None;
			buttonNine.BackColor = Color.White;
			buttonNine.FlatAppearance.BorderSize = 0;
			buttonNine.FlatStyle = FlatStyle.Flat;
			buttonNine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonNine.Location = new Point(202, 132);
			buttonNine.Name = "buttonNine";
			buttonNine.Size = new Size(90, 60);
			buttonNine.TabIndex = 6;
			buttonNine.Tag = "Number";
			buttonNine.Text = "9";
			buttonNine.UseVisualStyleBackColor = false;
			buttonNine.Click += ControlClicked;
			// 
			// buttonFour
			// 
			buttonFour.Anchor = AnchorStyles.None;
			buttonFour.BackColor = Color.White;
			buttonFour.FlatAppearance.BorderSize = 0;
			buttonFour.FlatStyle = FlatStyle.Flat;
			buttonFour.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonFour.Location = new Point(10, 198);
			buttonFour.Name = "buttonFour";
			buttonFour.Size = new Size(90, 60);
			buttonFour.TabIndex = 5;
			buttonFour.Tag = "Number";
			buttonFour.Text = "4";
			buttonFour.UseVisualStyleBackColor = false;
			buttonFour.Click += ControlClicked;
			// 
			// buttonFive
			// 
			buttonFive.Anchor = AnchorStyles.None;
			buttonFive.BackColor = Color.White;
			buttonFive.FlatAppearance.BorderSize = 0;
			buttonFive.FlatStyle = FlatStyle.Flat;
			buttonFive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonFive.Location = new Point(106, 198);
			buttonFive.Name = "buttonFive";
			buttonFive.Size = new Size(90, 60);
			buttonFive.TabIndex = 4;
			buttonFive.Tag = "Number";
			buttonFive.Text = "5";
			buttonFive.UseVisualStyleBackColor = false;
			buttonFive.Click += ControlClicked;
			// 
			// buttonSix
			// 
			buttonSix.Anchor = AnchorStyles.None;
			buttonSix.BackColor = Color.White;
			buttonSix.FlatAppearance.BorderSize = 0;
			buttonSix.FlatStyle = FlatStyle.Flat;
			buttonSix.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonSix.Location = new Point(202, 198);
			buttonSix.Name = "buttonSix";
			buttonSix.Size = new Size(90, 60);
			buttonSix.TabIndex = 3;
			buttonSix.Tag = "Number";
			buttonSix.Text = "6";
			buttonSix.UseVisualStyleBackColor = false;
			buttonSix.Click += ControlClicked;
			// 
			// buttonOne
			// 
			buttonOne.Anchor = AnchorStyles.None;
			buttonOne.BackColor = Color.White;
			buttonOne.FlatAppearance.BorderSize = 0;
			buttonOne.FlatStyle = FlatStyle.Flat;
			buttonOne.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonOne.Location = new Point(10, 264);
			buttonOne.Name = "buttonOne";
			buttonOne.Size = new Size(90, 60);
			buttonOne.TabIndex = 2;
			buttonOne.Tag = "Number";
			buttonOne.Text = "1";
			buttonOne.UseVisualStyleBackColor = false;
			buttonOne.Click += ControlClicked;
			// 
			// buttonTwo
			// 
			buttonTwo.Anchor = AnchorStyles.None;
			buttonTwo.BackColor = Color.White;
			buttonTwo.FlatAppearance.BorderSize = 0;
			buttonTwo.FlatStyle = FlatStyle.Flat;
			buttonTwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonTwo.Location = new Point(106, 264);
			buttonTwo.Name = "buttonTwo";
			buttonTwo.Size = new Size(90, 60);
			buttonTwo.TabIndex = 1;
			buttonTwo.Tag = "Number";
			buttonTwo.Text = "2";
			buttonTwo.UseVisualStyleBackColor = false;
			buttonTwo.Click += ControlClicked;
			// 
			// buttonThree
			// 
			buttonThree.Anchor = AnchorStyles.None;
			buttonThree.BackColor = Color.White;
			buttonThree.FlatAppearance.BorderSize = 0;
			buttonThree.FlatStyle = FlatStyle.Flat;
			buttonThree.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			buttonThree.Location = new Point(202, 264);
			buttonThree.Name = "buttonThree";
			buttonThree.Size = new Size(90, 60);
			buttonThree.TabIndex = 0;
			buttonThree.Tag = "Number";
			buttonThree.Text = "3";
			buttonThree.UseVisualStyleBackColor = false;
			buttonThree.Click += ControlClicked;
			// 
			// panelDisplay
			// 
			panelDisplay.Controls.Add(labelHistory);
			panelDisplay.Controls.Add(labelEntry);
			panelDisplay.Dock = DockStyle.Fill;
			panelDisplay.Location = new Point(0, 0);
			panelDisplay.Name = "panelDisplay";
			panelDisplay.Size = new Size(402, 134);
			panelDisplay.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(402, 534);
			Controls.Add(panelDisplay);
			Controls.Add(panelButtons);
			Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			MinimumSize = new Size(418, 573);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Kalkulačka";
			panelButtons.ResumeLayout(false);
			panelButtons.PerformLayout();
			panelDisplay.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel panelButtons;
		private Button buttonThree;
		private Button buttonComma;
		private Button buttonZero;
		private Button buttonSeven;
		private Button buttonEight;
		private Button buttonNine;
		private Button buttonFour;
		private Button buttonFive;
		private Button buttonSix;
		private Button buttonOne;
		private Button buttonTwo;
		private Button buttonPlus;
		private Button buttonEquals;
		private Button buttonDivide;
		private Button buttonMultiply;
		private Button buttonMinus;
		private Button buttonClearEntry;
		private Button buttonClear;
		private Button buttonBackspace;
		private Label labelMemoryMinus;
		private Label labelMemoryPlus;
		private Label labelMemoryClear;
		private Label labelMemoryRecall;
		private Label labelHistory;
		private Label labelEntry;
		private Label labelMemoryValue;
		private Panel panelDisplay;
	}
}
