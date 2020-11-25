using System.Windows.Forms;
using WorldsHardestGame;

namespace irf_10_het_JV6INX
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;
        public Form1()
        {
            InitializeComponent();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            //gc.AddPlayer();
            //gc.Start(true);
        }
    }
}
