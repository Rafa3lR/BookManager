namespace BookManager._1_Modulo1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnTop = new Panel();
            lbFilters = new Label();
            btnAddBook = new Button();
            pnFilters = new Panel();
            label3 = new Label();
            cbSituationFilter = new ComboBox();
            tbAuthor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerMin = new DateTimePicker();
            btnUpdate = new Button();
            tbTitle = new TextBox();
            tbID = new TextBox();
            dateTimePickerMax = new DateTimePicker();
            flowPanelBooks = new FlowLayoutPanel();
            pnTop.SuspendLayout();
            pnFilters.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = SystemColors.ControlDarkDark;
            pnTop.Controls.Add(lbFilters);
            pnTop.Controls.Add(btnAddBook);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Margin = new Padding(0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(800, 44);
            pnTop.TabIndex = 0;
            // 
            // lbFilters
            // 
            lbFilters.AutoSize = true;
            lbFilters.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFilters.ForeColor = SystemColors.HighlightText;
            lbFilters.Location = new Point(41, 0);
            lbFilters.Name = "lbFilters";
            lbFilters.Size = new Size(106, 37);
            lbFilters.TabIndex = 0;
            lbFilters.Text = "FILTERS";
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = SystemColors.ButtonFace;
            btnAddBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddBook.Location = new Point(185, 0);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(106, 44);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "ADD BOOK";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // pnFilters
            // 
            pnFilters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnFilters.BackColor = SystemColors.ControlDarkDark;
            pnFilters.Controls.Add(label3);
            pnFilters.Controls.Add(cbSituationFilter);
            pnFilters.Controls.Add(tbAuthor);
            pnFilters.Controls.Add(label2);
            pnFilters.Controls.Add(label1);
            pnFilters.Controls.Add(dateTimePickerMin);
            pnFilters.Controls.Add(btnUpdate);
            pnFilters.Controls.Add(tbTitle);
            pnFilters.Controls.Add(tbID);
            pnFilters.Controls.Add(dateTimePickerMax);
            pnFilters.Location = new Point(0, 44);
            pnFilters.Margin = new Padding(0);
            pnFilters.Name = "pnFilters";
            pnFilters.Size = new Size(187, 406);
            pnFilters.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(0, 271);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 9;
            label3.Text = "Situation";
            // 
            // cbSituationFilter
            // 
            cbSituationFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSituationFilter.Font = new Font("Segoe UI", 9.75F);
            cbSituationFilter.FormattingEnabled = true;
            cbSituationFilter.Items.AddRange(new object[] { "All", "I want to read", "Reading", "I've already read it", "Rereading", "I've abandoned it" });
            cbSituationFilter.Location = new Point(0, 295);
            cbSituationFilter.Name = "cbSituationFilter";
            cbSituationFilter.Size = new Size(187, 25);
            cbSituationFilter.TabIndex = 8;
            cbSituationFilter.SelectedIndexChanged += cbSituationFilter_SelectedIndexChanged;
            // 
            // tbAuthor
            // 
            tbAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbAuthor.ForeColor = Color.FromArgb(114, 114, 114);
            tbAuthor.Location = new Point(0, 83);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(187, 25);
            tbAuthor.TabIndex = 2;
            tbAuthor.Text = "Search Author";
            tbAuthor.Enter += tbAuthor_Enter;
            tbAuthor.KeyDown += tbAuthor_KeyDown;
            tbAuthor.Leave += tbAuthor_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(0, 195);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 5;
            label2.Text = "Final date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(0, 139);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 3;
            label1.Text = "Inicial date:";
            // 
            // dateTimePickerMin
            // 
            dateTimePickerMin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerMin.Format = DateTimePickerFormat.Short;
            dateTimePickerMin.Location = new Point(0, 163);
            dateTimePickerMin.Name = "dateTimePickerMin";
            dateTimePickerMin.Size = new Size(187, 29);
            dateTimePickerMin.TabIndex = 4;
            dateTimePickerMin.Value = new DateTime(2024, 4, 6, 0, 0, 0, 0);
            dateTimePickerMin.KeyDown += dateTimePickerMin_KeyDown;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(53, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(74, 33);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "APPLY";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbTitle.ForeColor = Color.FromArgb(114, 114, 114);
            tbTitle.Location = new Point(0, 52);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(187, 25);
            tbTitle.TabIndex = 1;
            tbTitle.Text = "Search Title";
            tbTitle.Enter += tbTitle_Enter;
            tbTitle.KeyDown += tbTitle_KeyDown;
            tbTitle.Leave += tbTitle_Leave;
            // 
            // tbID
            // 
            tbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbID.ForeColor = Color.FromArgb(114, 114, 114);
            tbID.Location = new Point(0, 21);
            tbID.Name = "tbID";
            tbID.Size = new Size(187, 25);
            tbID.TabIndex = 0;
            tbID.Text = "Search ID";
            tbID.Enter += tbID_Enter;
            tbID.KeyDown += tbID_KeyDown;
            tbID.Leave += tbID_Leave;
            // 
            // dateTimePickerMax
            // 
            dateTimePickerMax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerMax.Format = DateTimePickerFormat.Short;
            dateTimePickerMax.Location = new Point(0, 219);
            dateTimePickerMax.Name = "dateTimePickerMax";
            dateTimePickerMax.Size = new Size(187, 29);
            dateTimePickerMax.TabIndex = 6;
            dateTimePickerMax.Value = new DateTime(2024, 4, 6, 0, 0, 0, 0);
            dateTimePickerMax.KeyDown += dateTimePickerMax_KeyDown;
            // 
            // flowPanelBooks
            // 
            flowPanelBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelBooks.AutoScroll = true;
            flowPanelBooks.BackColor = Color.LightSteelBlue;
            flowPanelBooks.Location = new Point(187, 44);
            flowPanelBooks.Margin = new Padding(0);
            flowPanelBooks.Name = "flowPanelBooks";
            flowPanelBooks.Size = new Size(613, 406);
            flowPanelBooks.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowPanelBooks);
            Controls.Add(pnFilters);
            Controls.Add(pnTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            RightToLeft = RightToLeft.No;
            Text = "BookManager";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            pnFilters.ResumeLayout(false);
            pnFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Button btnAddBook;
        private Panel pnFilters;
        private Label lbFilters;
        private Button btnUpdate;
        private Label label2;
        private Label label1;
        private Label label3;
        public static TextBox tbID;
        public static TextBox tbTitle;
        public static TextBox tbAuthor;
        public static DateTimePicker dateTimePickerMax;
        public static DateTimePicker dateTimePickerMin;
        public static FlowLayoutPanel flowPanelBooks;
        public static ComboBox cbSituationFilter;
    }
}
