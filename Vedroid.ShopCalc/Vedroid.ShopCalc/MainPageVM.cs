using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Vedroid.ShopCalc
{
    internal class MainPageVM : VMBase
    {
        public MainPageVM()
        {
            CalcCommand = new Command(Calc);
            ClearHistoryCommand = new Command(ClearHistory);

            History = new ObservableCollection<HistoryItem>();
        }
        //Вес
        private Decimal _Brutto;
        public Decimal Brutto
        {
            get => _Brutto;
            set => SetField(ref _Brutto, value);
        }

        private Decimal _Price;
        public Decimal Price
        {
            get => _Price;
            set => SetField(ref _Price, value);
        }

        private Decimal _Netto;
        public Decimal Netto
        {
            get => _Netto;
            set => SetField(ref _Netto, value);
        }

        private ObservableCollection<HistoryItem> _History;

        public ObservableCollection<HistoryItem> History
        {
            get => _History;
            set => SetField(ref _History, value);
        }

        private Decimal _Result;
        public Decimal Result
        {
            get => _Result;
            set => SetField(ref _Result, value);
        }


        #region Commands
        public ICommand CalcCommand { get; set; }

        private void Calc()
        {
            Result = (Price * Netto) / Brutto;
            History.Add(new HistoryItem()
            {
                ItemBrutto = Brutto,
                ItemPrice = Price,
                ItemNetto = Netto,
                ItemResult = Result
            });
        }

        public ICommand ClearHistoryCommand { get; set; }
        private void ClearHistory()
        {
            History.Clear();
        }
        #endregion
    }
}
