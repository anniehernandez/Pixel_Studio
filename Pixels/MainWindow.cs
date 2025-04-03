namespace Pixels
{
    public partial class WNDW : Form
    {
        public WNDW()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void lbl_documentation_Click(object sender, EventArgs e)
        {
            pnl_Documentation.Visible = true;
        }

        private void lbl_Video_Click(object sender, EventArgs e)
        {
            ClosePanels("Video");
        }

        private void ClosePanels(string CurrentWindow)
        {

            switch (CurrentWindow)
            {
                case "Video":

                    pnl_Documentation.Visible = !pnl_Documentation.Visible;


                    break;

                default:
                    break;
            }


            return;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
