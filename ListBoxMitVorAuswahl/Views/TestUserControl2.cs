using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.ViewModels;

namespace WindowsFormsApp1.Views
{
    public partial class TestUserControl2 : UserControl
    {
        public TestUserControl2()
        {
            InitializeComponent();

            DataContext.BeteiligteChanged += DataContext_BeteiligteChanged;
            mainWindowViewModelBindingSource.DataSource = DataContext;
            beteiligteListBox.DataSource = DataContext.Beteiligte;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            BeteiligteSelectDefaults();
        }

        /// <summary>
        /// Handler für das Ereignis <see cref="TestViewModel.BeteiligteChanged"/>.
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
        /// <remarks>Durch die direkte Zuweisung von <see cref="TestViewModel.Beteiligte"/>, 
        /// anstelle der <see cref="TestUserControl1.beteiligteBindingSource"/>, funktioniert 
        /// die Vorauswahl in beiden Ereignissen (<see cref="MainWindow_Load(object, EventArgs)"/> und
        /// <see cref="DataContext_BeteiligteChanged(object, EventArgs)"/>).</remarks>
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

        TestViewModel DataContext { get; } = new TestViewModel();
    }
}
