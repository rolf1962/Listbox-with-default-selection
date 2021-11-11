using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private TestContext context = new TestContext();
        private List<PersonListItem> _allePersonen;
        private bool _nurTatVerdaechtige;

        public MainWindowViewModel()
        {
            PropertyChanged += MainWindowViewModel_PropertyChanged;

            _allePersonen = context.Personen.Select(p => new PersonListItem()
            {
                Person = p,
                Ausgewaehlt = false,
                Tatverdaechtig = context.Personen.IndexOf(p) % 2 != 0
            }).ToList();

            LadeBeteiligte();
        }

        /// <summary>
        /// Ermöglicht die Behandlung eigener <see cref="ViewModelBase.PropertyChanged"/>-Ereignisse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                /// Das <see cref="ViewModelBase.PropertyChanged"/>-Ereignis von <see cref="NurTatVerdaechtige"/> löst
                /// die Reduktion/Erweiterung von <see cref="Beteiligte"/> aus.
                case nameof(NurTatVerdaechtige):
                    LadeBeteiligte();
                break;

            }
        }

        /// <summary>
        /// Lädt die Einträge in <see cref="Beteiligte"/>, unter Berücksichtigung des Schalters <see cref="NurTatVerdaechtige"/>, neu.
        /// </summary>
        private void LadeBeteiligte()
        {
            Beteiligte.Clear();
            if (NurTatVerdaechtige)
            {
                _allePersonen.Where(p => p.Tatverdaechtig).ToList().ForEach(p => Beteiligte.Add(p));
            }
            else
            {
                _allePersonen.ForEach(p => Beteiligte.Add(p));
            }

            BeteiligteChanged?.Invoke(this, new EventArgs());
        }

        public bool NurTatVerdaechtige
        {
            get { return _nurTatVerdaechtige; }
            set
            {
                if (_nurTatVerdaechtige != value)
                {
                    _nurTatVerdaechtige = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public List<PersonListItem> Beteiligte { get; } = new List<PersonListItem>();
        public List<PersonListItem> TatBeteiligte { get; } = new List<PersonListItem>();
        public List<PersonListItem> TatVerdaechtige { get; } = new List<PersonListItem>();

        public event EventHandler BeteiligteChanged;
    }
}
