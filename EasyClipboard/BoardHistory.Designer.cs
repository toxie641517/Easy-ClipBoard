namespace EasyClipboard
{
    partial class BoardHistory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListItems = new System.Windows.Forms.DataGridView();
            this.history = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNote = new System.Windows.Forms.DataGridView();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNote)).BeginInit();
            this.SuspendLayout();
            // 
            // ListItems
            // 
            this.ListItems.AllowUserToAddRows = false;
            this.ListItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItems.ColumnHeadersVisible = false;
            this.ListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.history});
            this.ListItems.Location = new System.Drawing.Point(0, 408);
            this.ListItems.Name = "ListItems";
            this.ListItems.RowHeadersVisible = false;
            this.ListItems.Size = new System.Drawing.Size(287, 250);
            this.ListItems.TabIndex = 0;
            this.ListItems.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItems_CellMouseEnter);
            this.ListItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItems_CellMouseLeave);
            this.ListItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListItems_CellContentClick);
            // 
            // history
            // 
            this.history.HeaderText = "ClipBoard History";
            this.history.Name = "history";
            this.history.ReadOnly = true;
            // 
            // KeyNote
            // 
            this.KeyNote.AllowUserToAddRows = false;
            this.KeyNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KeyNote.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeyNote.ColumnHeadersVisible = false;
            this.KeyNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.note});
            this.KeyNote.Location = new System.Drawing.Point(0, 0);
            this.KeyNote.Name = "KeyNote";
            this.KeyNote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KeyNote.Size = new System.Drawing.Size(287, 400);
            this.KeyNote.TabIndex = 1;
            this.KeyNote.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.KeyNote_CellContentClick);
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // BoardHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 555);
            this.Controls.Add(this.KeyNote);
            this.Controls.Add(this.ListItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoardHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Easy ClipBoard";
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn history;
        private System.Windows.Forms.DataGridView KeyNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}

