using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Project
{
    public static class EkraniTemizle
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }                            
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    //cb.SelectedIndex = 0;
                    cb.SelectedItem = null;
                }
                else if (item is RichTextBox)
                {
                    RichTextBox rTxt = (RichTextBox)item;
                    rTxt.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mTxt = (MaskedTextBox)item;
                    mTxt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtPicker = (DateTimePicker)item;
                    dtPicker.Value = DateTime.Now;
                }
            }
        }

    }
}
