using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.ViewModels;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext.BeteiligteChanged += DataContext_BeteiligteChanged;
            mainWindowViewModelBindingSource.DataSource = DataContext;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            BeteiligteSelectDefaults();
        }

        /// <summary>
        /// Handler für das Ereignis <see cref="MainWindowViewModel.BeteiligteChanged"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataContext_BeteiligteChanged(object sender, EventArgs e)
        {
            BeteiligteSelectDefaults();
        }

        /// <summary>
        /// Wählt alle <see cref="PersonListItem.Tatverdaechtig">Tatverdächtigen</see> in 
        /// der <see cref="beteiligteListBox">ListBox Beteiligte</see> aus.
        /// </summary>
        /// <remarks>Das sollte aus zwei Ereignissen (<see cref="MainWindow_Load(object, EventArgs)"/> und
        /// <see cref="DataContext_BeteiligteChanged(object, EventArgs)"/>) heraus funktionieren. Tatsächlich 
        /// funktioniert es nur beim Aufruf aus <see cref="MainWindow.MainWindow_Load(object, EventArgs)"/>.</remarks>
        private void BeteiligteSelectDefaults()
        {
            // Auswahl in der Listbox aufheben
            beteiligteListBox.ClearSelected();

            // ObjectCollection ListBox.Items in generische Liste kopieren
            List<PersonListItem> beteiligte = new List<PersonListItem>();
            foreach(PersonListItem personListItem in beteiligteListBox.Items) { beteiligte.Add(personListItem); }
            
            // Alle Tatverdächtigen in der ListBox auswählen
            beteiligte.ForEach(personListItem =>
            {
                if (personListItem.Tatverdaechtig)
                {
                    beteiligteListBox.SetSelected(beteiligte.IndexOf(personListItem), true);
                }
            });
        }

        MainWindowViewModel DataContext { get; } = new MainWindowViewModel();
    }
}
