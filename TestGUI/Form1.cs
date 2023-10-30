using Npgsql;
using System.Data;

namespace TestGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string vstrConnection = "server=129.151.221.119 ; port=5432 ; user id=596237 ; password=Ha1FinDagIDag! ; database=596237 ;";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;
        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vstrConnection;

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
        }
        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);

            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtgetData = new DataTable();
            dtgetData = getData("select * from ansatt0;");

            dataGridView1.DataSource = dtgetData;
        }
    }
}