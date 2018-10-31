using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fredro
{
    internal class FredroModel : INotifyPropertyChanged
    {
        private string _baseUrl;
        public string BaseUrl
        {
            get { return _baseUrl; }
            set
            {
                if (!value.Equals(_baseUrl))
                {
                    _baseUrl = value;
                    NotifyPropertyChanged("BaseUrl");
                }
            }
        }

        private string _checkedUrl;
        public string CheckedUrl
        {
            get { return _checkedUrl; }
            set
            {
                if (!value.Equals(_checkedUrl))
                {
                    _checkedUrl = value;
                    NotifyPropertyChanged("CheckedUrl");
                }
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (!value.Equals(_filePath))
                {
                    _filePath = value;
                    NotifyPropertyChanged("FilePath");
                }
            }
        }

        private string _logText = "";
        public string LogText
        {
            get { return _logText; }
            set
            {
                if (!value.Equals(_logText))
                {
                    _logText = value;
                    NotifyPropertyChanged("LogText");
                }
            }
        }

        private int _symbolValue;
        public int SymbolValue
        {
            get { return _symbolValue; }
            set
            {
                if (value != _symbolValue)
                {
                    _symbolValue = value;
                    NotifyPropertyChanged("SymbolValue");
                }
            }
        }

        private int _symbolCount;
        public int SymbolCount
        {
            get { return _symbolCount; }
            set
            {
                if (value != _symbolCount)
                {
                    _symbolCount = value;
                    NotifyPropertyChanged("SymbolCount");
                }
            }
        }

        private int _period;
        public int Period
        {
            get { return _period; }
            set
            {
                if (value != _period)
                {
                    _period = value;
                    NotifyPropertyChanged("Period");
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler OnUpdate;

        private List<char> _allSymbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
            'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> _lowerSymbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> _digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private List<char> _CurrentSymbols;
        private bool _isBaseExist = true;


        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnUpdateForm()
        {
            if (OnUpdate != null)
            {
                OnUpdate.Invoke(this, EventArgs.Empty);
            }
        }

        internal void SetCurrentSymbols(byte value)
        {
            switch(value)
            {
                case 1:
                    _CurrentSymbols = _allSymbols;
                    break;
                case 2:
                    _CurrentSymbols = _lowerSymbols;
                    break;
                case 3:
                    _CurrentSymbols = _digits;
                    break;
                default:
                    throw new Exception();
            }
        }

        public void DoWork()
        {
            do
            {
                for (int i = 0; i < Period; i++)
                {
                    CheckUrl();
                    OnUpdateForm();
                }
                CheckBaseUrl();
                OnUpdateForm();
            }
            while (_isBaseExist);
        }

        internal void StopWork()
        {
            LogText += Environment.NewLine + "Приготовься забирать свой флекс!!!";
            _isBaseExist = false;
        }

        private void CheckUrl()
        {
            var rnd = new Random();
            string urlPart = "";
            for (int k = 0; k < SymbolCount; k++)
            {
                urlPart += _CurrentSymbols[rnd.Next(0, _CurrentSymbols.Count)];
            }
            var url = BaseUrl + urlPart;
            Request(url);
            //task.Wait();
        }

        private void CheckBaseUrl()
        {
            RequestCheckedUrl();
            //task.Wait();
        }

        private void WriteToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true, Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }

        private void Request(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    LogText = "Байтим - " + url + " - :::Флекс:::" + Environment.NewLine + LogText;
                    WriteToFile(url);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    LogText = "Роняем - " + url + Environment.NewLine + LogText;
                }
            }
        }

        private void RequestCheckedUrl()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(CheckedUrl);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    LogText = "Делаем флекс!!!" + Environment.NewLine + LogText;
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    LogText = "Больше не будет флекса =(" + Environment.NewLine + LogText;
                    _isBaseExist = false;
                }
            }
        }
    }
}
