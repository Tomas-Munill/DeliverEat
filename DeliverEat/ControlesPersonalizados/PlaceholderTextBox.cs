using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace DeliverEat.ControlesPersonalizados
{
    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText;
        private Color placeholderColor = Color.Gray;
        private bool isPlaceholder = true;

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                SetPlaceholder();
            }
        }

        public PlaceholderTextBox()
        {
            SetPlaceholder();
            this.Enter += OnEnter;
            this.Leave += OnLeave;
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(this.Text) || this.Text == placeholderText)
            {
                this.Text = placeholderText;
                this.ForeColor = placeholderColor;
                isPlaceholder = true;
            }
            else
            {
                this.ForeColor = SystemColors.WindowText;
                isPlaceholder = false;
            }
        }

        private void OnEnter(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                this.Text = "";
                this.ForeColor = SystemColors.WindowText;
                isPlaceholder = false;
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }
    }
}
