using System.Windows.Forms;

namespace VuurwerkKassa
{
    public partial class KlantView : Form
    {
        public KlantView()
        {
            InitializeComponent();
        }

        public ListView getListView()
        {
            return listViewKlant;
        }

        public Label getTotaalLabel()
        {
            return lblTotaalKlant;
        }
    }
}
