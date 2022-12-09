namespace Kolko_i_krzyzyk
{
    enum ObecnyGracz
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        ObecnyGracz Obecny;
        public Form1()
        {
            InitializeComponent();
            Obecny = ObecnyGracz.Cross;
            zmianaLabel();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Klik(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(Obecny == ObecnyGracz.Cross)
            {
                senderButton.Text = "X";
                Obecny = ObecnyGracz.Circle;
            }
            else
            {
                senderButton.Text = "O";
                Obecny = ObecnyGracz.Cross;
            }
            zmianaLabel();

        }


        public void zmianaLabel()
        {
            if(Obecny == ObecnyGracz.Cross)
            {
                ObecnyGraczLabel.Text = "Krzy¿yk";
            }
            else
            {
                ObecnyGraczLabel.Text = "Kó³ko";
            }
        }
        public void wygrana()
        {
            if (String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                Form2 win = new Form2();
                win.wygrany = tl.Text;
                win.Show();
            }
        }
        public void czyszczenie()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            { }
        }
    }
}