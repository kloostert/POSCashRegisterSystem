using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace VuurwerkKassa
{
    public static class MsgBoxes
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Annuleren";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonOk.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 80, 372, 20);
            buttonOk.SetBounds(120, 265, 75, 23);
            buttonCancel.SetBounds(309, 265, 75, 23);

            label.AutoSize = true;
            buttonOk.AutoSize = true;
            buttonCancel.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 300);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult DialogBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "Ja";
            buttonCancel.Text = "Nee";
            buttonOk.DialogResult = DialogResult.Yes;
            buttonCancel.DialogResult = DialogResult.No;
            buttonOk.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label.SetBounds(9, 20, 372, 13);
            buttonOk.SetBounds(217, 165, 75, 23);
            buttonCancel.SetBounds(309, 165, 75, 23);

            label.AutoSize = true;
            buttonOk.AutoSize = true;
            buttonCancel.AutoSize = true;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.TabIndex = 0;

            form.ClientSize = new Size(396, 200);
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        public static DialogResult DialogBoxOk(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label.SetBounds(9, 20, 372, 13);
            buttonOk.SetBounds(305, 185, 75, 23);

            label.AutoSize = true;
            buttonOk.AutoSize = true;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 220);
            form.Controls.AddRange(new Control[] { label, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        public static DialogResult ListBox(string title, string promptText, ref int value, ref Collection<Artikel> items)
        {
            Form form = new Form();
            Label label = new Label();
            ListBox listBox = new ListBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Annuleren";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonOk.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBox.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label.SetBounds(9, 20, 372, 13);
            listBox.SetBounds(12, 80, 372, 225);
            buttonOk.SetBounds(120, 325, 75, 23);
            buttonCancel.SetBounds(309, 325, 75, 23);

            label.AutoSize = true;
            buttonOk.AutoSize = true;
            buttonCancel.AutoSize = true;
            listBox.Anchor = listBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 360);
            form.Controls.AddRange(new Control[] { label, listBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            foreach (Artikel a in items)
            {
                listBox.Items.Add(a.getOmsch());
            }

            DialogResult dialogResult = form.ShowDialog();
            value = listBox.SelectedIndex;
            return dialogResult;
        }
    }
}
