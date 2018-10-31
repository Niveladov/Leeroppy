using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fredro
{
    public partial class frmFredro : XtraForm
    {
        private DateTime previousTime = DateTime.Now;
        private readonly SynchronizationContext synchronizationContext;
        private readonly FredroModel _model;

        public frmFredro()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
            _model = new FredroModel();
            InitEvents();
            BindControls();
        }

        private void BindControls()
        {
            teBaseUrl.DataBindings.Clear();
            teBaseUrl.DataBindings.Add("EditValue", _model, "BaseUrl");

            teCheckedUrl.DataBindings.Clear();
            teCheckedUrl.DataBindings.Add("EditValue", _model, "CheckedUrl");

            teOutputFile.DataBindings.Clear();
            teOutputFile.DataBindings.Add("EditValue", _model, "FilePath");

            sePeriod.DataBindings.Clear();
            sePeriod.DataBindings.Add("EditValue", _model, "Period");

            seExtraPartLength.DataBindings.Clear();
            seExtraPartLength.DataBindings.Add("EditValue", _model, "SymbolCount");

            chcbeSelectedSymbols.DataBindings.Clear();
            chcbeSelectedSymbols.DataBindings.Add("EditValue", _model, "SymbolValue");

            //meLog.DataBindings.Clear();
            //meLog.DataBindings.Add("EditValue", _model, nameof(_model.LogText));
        }

        private void InitEvents()
        {
            _model.PropertyChanged += _model_PropertyChanged;
            _model.OnUpdate += _model_OnUpdate;
        }

        private void _model_OnUpdate(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("SymbolValue"))
            {
                var value = checked(Convert.ToByte(chcbeSelectedSymbols.EditValue));
                _model.SetCurrentSymbols(value);
            }
        }

        public void UpdateGUI()
        {
            var timeNow = DateTime.Now;

            if ((DateTime.Now - previousTime).Milliseconds <= 200) return;

            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                meLog.Text = (o as FredroModel).LogText;
            }), _model);

            previousTime = timeNow;
        }

        private async void OnBtnStartClickAsync(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            await Task.Run(() =>
            {
                _model.DoWork();
                //UpdateGUI();
            });
            //meLog.Text = _model.LogText;  
            btnStart.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _model.StopWork();
        }

        private void btnBindFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Файлы (*.txt, *.doc, *.docx)| *.txt; *.docx; *.doc";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _model.FilePath = dialog.FileName;
                }
            }
        }



    }
}
