using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace PlayerDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=SQLiteDBPlayer.db;Version=3;New=False;Compress=True;");
        }

        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from tbl1";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into tbl1 (PlayerID, FirstName, LastName, Phone, eMail, Address)values('" +textBox1+ "','" +textBox2+ "','" +textBox3+ "','" +textBox4+ "','" +textBox5+ "','" +textBox6+ "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "update tbl1 set FirstName='" + textBox2.Text + "',LastName='"+textBox3.Text+ "',Phone='" + textBox4.Text + "',eMail='" + textBox5.Text + "',Address='" + textBox6.Text + "',where ID='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tbl1 where ID='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
