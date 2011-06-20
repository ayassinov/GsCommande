using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.GlagSoft.GsCommande.Outils
{
    public class NullableDateTimePicker : DateTimePicker
    {

        [Browsable(true),
         Category("Behavior"),
         Description("The string used to display null values in the control"),
         DefaultValue(" ")]
        public string NullValue { get; set; }

        private DateTimePickerFormat _oldFormat = DateTimePickerFormat.Short;
        private string _oldCustomFormat = null;
        private bool _isNull = false;


        public new DateTime Value
        {
            get
            {
                if (_isNull)
                    return DateTime.MinValue;
                else
                    return base.Value;
            }
            set
            {
                if (value == DateTime.MinValue)
                {
                    if (!_isNull)
                    {
                        _oldFormat = this.Format;
                        _oldCustomFormat = this.CustomFormat;
                        _isNull = true;
                    }

                    this.Format = DateTimePickerFormat.Custom;
                    this.CustomFormat = NullValue;
                }
                else
                {
                    if (_isNull)
                    {
                        this.Format = _oldFormat;
                        this.CustomFormat = _oldCustomFormat;
                        _isNull = false;
                    }
                    base.Value = value;
                }
            }
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                if (_isNull)
                {
                    this.Format = _oldFormat;
                    this.CustomFormat = _oldCustomFormat;
                    _isNull = false;
                }
            }
            base.OnCloseUp(eventargs);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Delete)
                this.Value = DateTime.MinValue;
        }

    }
}
