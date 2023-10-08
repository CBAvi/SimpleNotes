namespace SimpleNotes
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.panelNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.splitContainerZero = new System.Windows.Forms.SplitContainer();
            this.splitContainerNotes = new System.Windows.Forms.SplitContainer();
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.splitContainerViewAndEdit = new System.Windows.Forms.SplitContainer();
            this.splitContainerNote = new System.Windows.Forms.SplitContainer();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.toolHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuTextEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerZero)).BeginInit();
            this.splitContainerZero.Panel1.SuspendLayout();
            this.splitContainerZero.Panel2.SuspendLayout();
            this.splitContainerZero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNotes)).BeginInit();
            this.splitContainerNotes.Panel1.SuspendLayout();
            this.splitContainerNotes.Panel2.SuspendLayout();
            this.splitContainerNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViewAndEdit)).BeginInit();
            this.splitContainerViewAndEdit.Panel1.SuspendLayout();
            this.splitContainerViewAndEdit.Panel2.SuspendLayout();
            this.splitContainerViewAndEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).BeginInit();
            this.splitContainerNote.Panel1.SuspendLayout();
            this.splitContainerNote.Panel2.SuspendLayout();
            this.splitContainerNote.SuspendLayout();
            this.contextMenuTextEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.ContextMenuStrip = this.contextMenuTextEdit;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textArea.Location = new System.Drawing.Point(0, 0);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(338, 409);
            this.textArea.TabIndex = 2;
            this.textArea.Text = "";
            // 
            // panelNotes
            // 
            this.panelNotes.AutoScroll = true;
            this.panelNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotes.Location = new System.Drawing.Point(0, 0);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(469, 451);
            this.panelNotes.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(108, 24);
            this.toolStripButtonAbout.Text = "О программе";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // splitContainerZero
            // 
            this.splitContainerZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerZero.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerZero.IsSplitterFixed = true;
            this.splitContainerZero.Location = new System.Drawing.Point(0, 27);
            this.splitContainerZero.Name = "splitContainerZero";
            // 
            // splitContainerZero.Panel1
            // 
            this.splitContainerZero.Panel1.Controls.Add(this.splitContainerNotes);
            // 
            // splitContainerZero.Panel2
            // 
            this.splitContainerZero.Panel2.Controls.Add(this.splitContainerViewAndEdit);
            this.splitContainerZero.Size = new System.Drawing.Size(815, 490);
            this.splitContainerZero.SplitterDistance = 471;
            this.splitContainerZero.TabIndex = 9;
            // 
            // splitContainerNotes
            // 
            this.splitContainerNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNotes.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerNotes.IsSplitterFixed = true;
            this.splitContainerNotes.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNotes.Name = "splitContainerNotes";
            this.splitContainerNotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerNotes.Panel1
            // 
            this.splitContainerNotes.Panel1.Controls.Add(this.buttonNewNote);
            // 
            // splitContainerNotes.Panel2
            // 
            this.splitContainerNotes.Panel2.Controls.Add(this.panelNotes);
            this.splitContainerNotes.Size = new System.Drawing.Size(469, 488);
            this.splitContainerNotes.SplitterDistance = 33;
            this.splitContainerNotes.TabIndex = 6;
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Location = new System.Drawing.Point(12, 4);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(200, 28);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "Новая заметка";
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // splitContainerViewAndEdit
            // 
            this.splitContainerViewAndEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerViewAndEdit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerViewAndEdit.IsSplitterFixed = true;
            this.splitContainerViewAndEdit.Location = new System.Drawing.Point(0, 0);
            this.splitContainerViewAndEdit.Name = "splitContainerViewAndEdit";
            this.splitContainerViewAndEdit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerViewAndEdit.Panel1
            // 
            this.splitContainerViewAndEdit.Panel1.Controls.Add(this.splitContainerNote);
            // 
            // splitContainerViewAndEdit.Panel2
            // 
            this.splitContainerViewAndEdit.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainerViewAndEdit.Panel2.Controls.Add(this.buttonEdit);
            this.splitContainerViewAndEdit.Size = new System.Drawing.Size(338, 488);
            this.splitContainerViewAndEdit.SplitterDistance = 446;
            this.splitContainerViewAndEdit.TabIndex = 3;
            // 
            // splitContainerNote
            // 
            this.splitContainerNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNote.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerNote.IsSplitterFixed = true;
            this.splitContainerNote.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNote.Name = "splitContainerNote";
            this.splitContainerNote.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerNote.Panel1
            // 
            this.splitContainerNote.Panel1.Controls.Add(this.textBoxTitle);
            // 
            // splitContainerNote.Panel2
            // 
            this.splitContainerNote.Panel2.Controls.Add(this.textArea);
            this.splitContainerNote.Size = new System.Drawing.Size(338, 446);
            this.splitContainerNote.SplitterDistance = 33;
            this.splitContainerNote.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(338, 27);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(228, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 27);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 27);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // toolHighlight
            // 
            this.toolHighlight.Name = "toolHighlight";
            this.toolHighlight.Size = new System.Drawing.Size(162, 24);
            this.toolHighlight.Text = "Выделить";
            this.toolHighlight.Click += new System.EventHandler(this.selToolStripMenuItem_Click);
            // 
            // toolInset
            // 
            this.toolInset.Name = "toolInset";
            this.toolInset.Size = new System.Drawing.Size(162, 24);
            this.toolInset.Text = "Вставить";
            this.toolInset.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(162, 24);
            this.toolCopy.Text = "Копировать";
            this.toolCopy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // contextMenuTextEdit
            // 
            this.contextMenuTextEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuTextEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHighlight,
            this.toolInset,
            this.toolCopy});
            this.contextMenuTextEdit.Name = "contextMenuTextEdit";
            this.contextMenuTextEdit.Size = new System.Drawing.Size(163, 76);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 517);
            this.Controls.Add(this.splitContainerZero);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 450);
            this.Name = "FormMain";
            this.Text = "SimpleNotes";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerZero.Panel1.ResumeLayout(false);
            this.splitContainerZero.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerZero)).EndInit();
            this.splitContainerZero.ResumeLayout(false);
            this.splitContainerNotes.Panel1.ResumeLayout(false);
            this.splitContainerNotes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNotes)).EndInit();
            this.splitContainerNotes.ResumeLayout(false);
            this.splitContainerViewAndEdit.Panel1.ResumeLayout(false);
            this.splitContainerViewAndEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViewAndEdit)).EndInit();
            this.splitContainerViewAndEdit.ResumeLayout(false);
            this.splitContainerNote.Panel1.ResumeLayout(false);
            this.splitContainerNote.Panel1.PerformLayout();
            this.splitContainerNote.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).EndInit();
            this.splitContainerNote.ResumeLayout(false);
            this.contextMenuTextEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.FlowLayoutPanel panelNotes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.SplitContainer splitContainerZero;
        private System.Windows.Forms.SplitContainer splitContainerNotes;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.SplitContainer splitContainerViewAndEdit;
        private System.Windows.Forms.SplitContainer splitContainerNote;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuTextEdit;
        private System.Windows.Forms.ToolStripMenuItem toolHighlight;
        private System.Windows.Forms.ToolStripMenuItem toolInset;
        private System.Windows.Forms.ToolStripMenuItem toolCopy;
    }
}

