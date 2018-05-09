using System;
using System.Windows.Forms;

namespace Be.Sidmar.RIS.BrandweerBewaking.Testje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            var row1 = _dataDienstverslagDetailActies.Actiegroepen.AddActiegroepenRow(1, "Groep 1");
            var row2 = _dataDienstverslagDetailActies.Actiegroepen.AddActiegroepenRow(2, "Groep 2");
            var row3 = _dataDienstverslagDetailActies.Actiegroepen.AddActiegroepenRow(3, "Groep 3");
            var row4 = _dataDienstverslagDetailActies.Actiegroepen.AddActiegroepenRow(4, "Groep 4");

            _dataDienstverslagDetailActies.Acties.AddActiesRow(row1, 1, "Actie A");
            _dataDienstverslagDetailActies.Acties.AddActiesRow(row1, 2, "Actie B");
            _dataDienstverslagDetailActies.Acties.AddActiesRow(row2, 3, "Actie C");
            _dataDienstverslagDetailActies.Acties.AddActiesRow(row3, 4, "Actie D");
            _dataDienstverslagDetailActies.Acties.AddActiesRow(row3, 5, "Actie E");
            _dataDienstverslagDetailActies.Acties.AddActiesRow(row4, 6, "Actie F");
        }

        private static int _teller = -1;

        private void ButtonAddClick(object sender, EventArgs e)
        {
            var newColumn = _dataDienstverslagDetailActies.Acties.Columns.Add(DateTime.Now.ToLongTimeString());
            _dataDienstverslagDetailActies.Acties.Rows[++_teller%6][newColumn.Ordinal] = "X";
        }
    }
}
