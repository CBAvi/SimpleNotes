using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleNotes
{
    public partial class FormMain : Form
    {
        private List<Note> notes = new List<Note>();
        private List<GroupBox> noteBoxes = new List<GroupBox>();

        private bool editing = false;
        private bool newNote = false;
        private int editNoteId = -1;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализатор бумажек
        /// </summary>
        /// <param name="note">Заметка</param>
        private void noteBoxInit(Note note)
        {
            noteBoxes.Add(new GroupBox());
            int idx = noteBoxes.Count - 1;

            Label labelNote = new Label();
            labelNote.Location = new Point(7, 27);
            labelNote.Name = "labelNote" + idx.ToString();
            labelNote.Size = new Size(200, 130);
            labelNote.TabIndex = 0;
            labelNote.Text = note.description;
            labelNote.MouseClick += new MouseEventHandler(labelNote_MouseClick);

            noteBoxes[idx].SuspendLayout();
            noteBoxes[idx].BackColor = Color.FromArgb(235, 200, 10); // Фон
            noteBoxes[idx].ForeColor = Color.FromArgb(50, 50, 0); // Текст
            noteBoxes[idx].Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            noteBoxes[idx].Controls.Add(labelNote);
            noteBoxes[idx].Location = new Point(3, 3);
            noteBoxes[idx].Name = "noteBox" + idx.ToString();
            noteBoxes[idx].Size = new Size(215, 160);
            noteBoxes[idx].TabIndex = 5 + idx;
            noteBoxes[idx].TabStop = false;
            noteBoxes[idx].Text = note.title;
            panelNotes.Controls.Add(noteBoxes[idx]);

            noteBoxes[idx].ResumeLayout(false);
            noteBoxes[idx].PerformLayout();
        }
        /// <summary>
        /// Обновление бумажек
        /// </summary>
        private void noteBoxesUpdate()
        {
            if (noteBoxes.Count > 0)
            {
                for (int i = 0; i < noteBoxes.Count; i++)
                {
                    noteBoxes[i].Dispose();
                }
            }
            noteBoxes.Clear();
            for (int i = 0; i < notes.Count; i++)
            {
                noteBoxInit(notes[i]);
            }
        }

        /// <summary>
        /// Сохранение заметки
        /// </summary>
        /// <param name="note">Заметка</param>
        private void saveNote(Note note)
        {
            StreamWriter streamWriter = new StreamWriter("notes\\" + note.dateOfCreation.ToString().Replace(':', '.') + ".json");
            streamWriter.Write(note.Serialize());
            streamWriter.Close();
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        /// <param name="note">Заметка</param>
        private void deleteNote(Note note)
        {
            String fileName = "notes\\" + note.dateOfCreation.ToString().Replace(':', '.') + ".json";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        /// <summary>
        /// Установка режима редактировния
        /// </summary>
        /// <param name="mode">Режим</param>
        private void editingMode(bool mode)
        {
            editing = mode;
            if (editing)
            {
                textArea.ReadOnly = false;
                textBoxTitle.ReadOnly = false;
                buttonEdit.Text = "Готово";
                buttonDelete.Text = "Отмена";
            }
            else
            {
                textArea.ReadOnly = true;
                textBoxTitle.ReadOnly = true;
                buttonEdit.Text = "Изменить";
                buttonDelete.Text = "Удалить";
                newNote = false;
            }
        }

        // Загрузка формы: загрузка заметок
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("notes"))
            {
                String[] files = Directory.GetFiles("notes");
                StreamReader streamReader;
                for (int i = 0; i < files.Length; i++)
                {
                    streamReader = new StreamReader(files[i]);
                    notes.Add(Note.Deserialize(streamReader.ReadToEnd()));
                    streamReader.Close();
                }
            }
            else
            {
                Directory.CreateDirectory("notes");
                notes.Add(new Note("Заметка №0", "Простые заметки\rМожно добавлять, изменять и удалять свои заметки.", DateTime.Now));
                saveNote(notes[0]);
            }
            noteBoxesUpdate();
        }

        // Выделение текста (не сохраняется в заметках)
        private void selToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionFont.Bold == false)
            {
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Bold | textArea.SelectionFont.Style);
            }
            else
            {
                textArea.SelectionFont = new Font(textArea.SelectionFont, textArea.Font.Style);
            }
        }

        // Обработка копирования в буфер обмена
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Copy();
        }

        // Обработка вставки из буфера обмена
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Paste();
        }

        // Обработка кнопки ифнормации о программе
        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простые заметки\r\r" +
                "Создавайте свои заметнки, " +
                "чтобы не забыть что-то важное. " +
                "(Заметки хранятся в виде JSON-файлов " +
                "в каталоге notes в папке с программой)" +
                "\r\r@CBAvi, 2023");
        }

        // Обработка клика по заметки
        private void labelNote_MouseClick(object sender, MouseEventArgs e)
        {
            if (newNote)
            {
                MessageBox.Show("Закончите создание заметки или отмените действие");
            }
            else
            {
                Label label = (Label)sender;
                editNoteId = Convert.ToInt32(label.Parent.Name.Replace("noteBox", ""));
                textArea.Text = notes[editNoteId].description;
                textBoxTitle.Text = notes[editNoteId].title;
                editingMode(false);
            }
        }

        // Обработка кнопки редактирования
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes[editNoteId].title = textBoxTitle.Text;
                notes[editNoteId].description = textArea.Text;
                notes[editNoteId].time = DateTime.Now;
                saveNote(notes[editNoteId]);
                editingMode(false);
                noteBoxesUpdate();
            }
            else editingMode(true);
        }

        // Обработка кнопки удаления или отмены
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (editing && !newNote)
            {
                editingMode(false);
                textArea.Text = notes[editNoteId].description;
                textBoxTitle.Text = notes[editNoteId].title;
            }
            else
            {
                deleteNote(notes[editNoteId]);
                notes.RemoveAt(editNoteId);
                noteBoxesUpdate();
                newNote = false;
            }
        }

        // Обработка кнопки создания новой заметки
        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            editingMode(true);
            notes.Add(new Note());
            editNoteId = notes.Count - 1;
            noteBoxInit(notes[editNoteId]);
            newNote = true;
            textArea.Text = "";
            textBoxTitle.Text = "";
        }
    }
}
