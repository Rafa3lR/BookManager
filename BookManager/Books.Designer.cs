namespace BookManager._1_Modulo1
{
    partial class Books
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookTitle = new Label();
            lblAuthorName = new Label();
            lblID = new Label();
            lblPubDate = new Label();
            btnBooks = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.Anchor = AnchorStyles.Top;
            lblBookTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookTitle.ImageAlign = ContentAlignment.TopCenter;
            lblBookTitle.Location = new Point(10, 6);
            lblBookTitle.Margin = new Padding(0);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(194, 173);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Nome do livro";
            lblBookTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblBookTitle.Click += lblBookTitle_Click;
            lblBookTitle.MouseLeave += lblBookTitle_MouseLeave;
            lblBookTitle.MouseMove += lblBookTitle_MouseMove;
            // 
            // lblAuthorName
            // 
            lblAuthorName.Anchor = AnchorStyles.Top;
            lblAuthorName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorName.ImageAlign = ContentAlignment.TopCenter;
            lblAuthorName.Location = new Point(10, 179);
            lblAuthorName.Margin = new Padding(0);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(194, 64);
            lblAuthorName.TabIndex = 1;
            lblAuthorName.Text = "Nome Autor";
            lblAuthorName.TextAlign = ContentAlignment.TopCenter;
            lblAuthorName.Click += lblAuthorName_Click;
            lblAuthorName.MouseLeave += lblAuthorName_MouseLeave;
            lblAuthorName.MouseMove += lblAuthorName_MouseMove;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Top;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(22, 243);
            lblID.Margin = new Padding(0);
            lblID.Name = "lblID";
            lblID.Size = new Size(76, 29);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += lblID_Click;
            lblID.MouseLeave += lblID_MouseLeave;
            lblID.MouseMove += lblID_MouseMove;
            // 
            // lblPubDate
            // 
            lblPubDate.Anchor = AnchorStyles.Top;
            lblPubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPubDate.Location = new Point(98, 243);
            lblPubDate.Margin = new Padding(0);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(106, 29);
            lblPubDate.TabIndex = 3;
            lblPubDate.Text = "06/04/2024";
            lblPubDate.TextAlign = ContentAlignment.MiddleLeft;
            lblPubDate.Click += lblPubDate_Click;
            lblPubDate.MouseLeave += lblPubDate_MouseLeave;
            lblPubDate.MouseMove += lblPubDate_MouseMove;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Transparent;
            btnBooks.Dock = DockStyle.Fill;
            btnBooks.FlatAppearance.BorderSize = 5;
            btnBooks.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBooks.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Location = new Point(0, 0);
            btnBooks.Margin = new Padding(0);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(213, 282);
            btnBooks.TabIndex = 4;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 282);
            panel1.TabIndex = 5;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblPubDate);
            Controls.Add(lblID);
            Controls.Add(lblAuthorName);
            Controls.Add(lblBookTitle);
            Controls.Add(btnBooks);
            Controls.Add(panel1);
            Name = "Books";
            Size = new Size(213, 282);
            Load += Books_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblBookTitle;
        private Label lblAuthorName;
        private Label lblID;
        private Label lblPubDate;
        private Button btnBooks;
        private Panel panel1;
    }
}
