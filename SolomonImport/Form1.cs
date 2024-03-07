using ExcelDataReader;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
 

namespace SolomonImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[CboSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<SapTaglist> sapTaglists = new List<SapTaglist>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    SapTaglist sapTaglist = new SapTaglist();
                    sapTaglist.Ccode = dt.Rows[i]["Ccode"].ToString();
                    sapTaglist.station = dt.Rows[i]["station"].ToString();
                    sapTaglist.line = dt.Rows[i]["line"].ToString();
                    sapTaglist.tagnumber = dt.Rows[i]["tagnumber"].ToString();
                    sapTaglist.wipid = dt.Rows[i]["wipid"].ToString();
                    sapTaglist.countdate = dt.Rows[i]["countdate"].ToString();
                    sapTaglist.item = dt.Rows[i]["item"].ToString();
                    sapTaglist.itemdescr = dt.Rows[i]["itemdescr"].ToString();
                    sapTaglist.unit = dt.Rows[i]["unit"].ToString();
                    sapTaglist.type = dt.Rows[i]["type"].ToString();
                    sapTaglist.jobnumber = dt.Rows[i]["jobnumber"].ToString();
                    sapTaglist.productiondate = dt.Rows[i]["productiondate"].ToString();
                    sapTaglist.ProcLineDecr = dt.Rows[i]["ProcLineDecr"].ToString();
                    sapTaglist.BlankTag = dt.Rows[i]["BlankTag"].ToString();
                    sapTaglist.InvtType = dt.Rows[i]["InvtType"].ToString();
                    sapTaglists.Add(sapTaglist);
                }
                sAPTagListBindingSource.DataSource = sapTaglists;
            }
        }

        DataTableCollection tableCollection;
         
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog() { Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            CboSheet.Items.Clear();
                            foreach(DataTable table in tableCollection)
                                CboSheet.Items.Add(table.TableName); //add sheet to combobox
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=190.7.10.7 ;Database=SUEApplication;User Id=sa;Password=tns2007;";
                DapperPlusManager.Entity<SapTaglist>().Table("SAP_Taglist");
                List<SapTaglist> sapTaglists = sAPTagListBindingSource.DataSource as List<SapTaglist>;

                if (sapTaglists != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                       db.BulkInsert(sapTaglists);
                    }
                }
                MessageBox.Show("Import Complete!");              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUEApplicationDataSet.SAP_TagList' table. You can move, or remove it, as needed.
            this.sAP_TagListTableAdapter.Fill(this.sUEApplicationDataSet.SAP_TagList);
            // TODO: This line of code loads data into the 'sUEApplicationDataSet.SAP_TagList' table. You can move, or remove it, as needed.
            this.sAP_TagListTableAdapter.Fill(this.sUEApplicationDataSet.SAP_TagList);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=190.7.10.7;Initial Catalog=SUEApplication;User ID=sa;Password=tns2007");
            
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from SAP_Taglist where wipid IN ('" + txtWipid.Text + "') ";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
