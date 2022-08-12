namespace el_promagrama_del_loco_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Aa = 0;
        public double Ab = 0;
        public double Ac = 0;
        public double Ad = 0;
        public double Ae = 0;

        public double Ba = 0;
        public double Bb = 0;
        public double Bc = 0;
        public double Bd = 0;
        public double Be = 0;

        public double Ca = 0;
        public double Cb = 0;
        public double Cc = 0;
        public double Cd = 0;
        public double Ce = 0;

        public double fila1;
        public double fila2;
        public double fila3;
        public double fila4;
        public double fila5;

        public double col1;
        public double col2;
        public double col3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aa = Convert.ToDouble(txtAa.Text);
            Ab = Convert.ToDouble(txtAb.Text);
            Ac = Convert.ToDouble(txtAc.Text);
            Ad = Convert.ToDouble(txtAd.Text);
            Ae = Convert.ToDouble(txtAe.Text);

            Ba = Convert.ToDouble(txtBa.Text);
            Bb = Convert.ToDouble(txtBb.Text);
            Bc = Convert.ToDouble(txtBc.Text);
            Bd = Convert.ToDouble(txtBd.Text);
            Be = Convert.ToDouble(txtBe.Text);

            Ca = Convert.ToDouble(txtCa.Text);
            Cb = Convert.ToDouble(txtCb.Text);
            Cc = Convert.ToDouble(txtCc.Text);
            Cd = Convert.ToDouble(txtCd.Text);
            Ce = Convert.ToDouble(txtCe.Text);

            col1 = Aa + Ab + Ac + Ad + Ae;
            col2 = Ba + Bb + Bc + Bd + Be;
            col3 = Ca + Cb + Cc + Bd + Be;

            fila1 = Aa + Ba + Ca;
            fila2 = Ab + Bb + Cb;
            fila3 = Ac + Bc + Cc;
            fila4 = Ad + Bd + Cd;
            fila5 = Ae + Be + Ce;

            txtFila1.Text = fila1.ToString();
            txtFila2.Text = fila2.ToString();
            txtFila3.Text = fila3.ToString();
            txtFila4.Text = fila4.ToString();
            txtFila5.Text = fila5.ToString();

            txtcol1.Text = col1.ToString();
            txtcol2.Text = col2.ToString();
            txtcol3.Text = col3.ToString();



        }
    }
}