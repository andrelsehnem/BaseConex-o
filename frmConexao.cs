using System;
using System.Windows.Forms;


namespace BaseConexão
{
    public partial class frmConexao : Form
    {
        public Conexao con;
        public frmConexao()
        {
            InitializeComponent();
        }

        private void frmConexao_Load(object sender, EventArgs e)
        {

        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            //frmExecuta frm = new();
            con = new(txt_servidor.Text, txt_porta.Text, txt_user.Text, txt_senha.Text, txt_database.Text);
            if (con.conectado)
            {
                Visible = false;
                //frm.Show();
            }
            else return;
        }
    }
}
