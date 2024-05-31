using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (dt != null)
            {
                List<SapTaglist> sapTaglists = new List<SapTaglist>();
                for (int i = 0; i < dt.Rows.Count; i++)
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            CboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
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
                List<SapTaglist> sapTaglists = sAPTagListBindingSource.DataSource as List<SapTaglist>;

                if (sapTaglists == null || sapTaglists.Count == 0)
                {
                    MessageBox.Show("No data to import!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=190.7.10.7;Database=SUEApplication;User Id=sa;Password=tns2007;";

                using (SqlConnection db = new SqlConnection(connectionString))
                {
                    db.Open();
                    using (SqlTransaction transaction = db.BeginTransaction())
                    {
                        try
                        {
                            foreach (var sapTaglist in sapTaglists)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO SAP_Taglist (Ccode, station, line, tagnumber, wipid, countdate, item, itemdescr, unit, type, jobnumber, productiondate, ProcLineDecr, BlankTag, InvtType) VALUES (@Ccode, @station, @line, @tagnumber, @wipid, @countdate, @item, @itemdescr, @unit, @type, @jobnumber, @productiondate, @ProcLineDecr, @BlankTag, @InvtType)", db, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@Ccode", sapTaglist.Ccode);
                                    cmd.Parameters.AddWithValue("@station", sapTaglist.station);
                                    cmd.Parameters.AddWithValue("@line", sapTaglist.line);
                                    cmd.Parameters.AddWithValue("@tagnumber", sapTaglist.tagnumber);
                                    cmd.Parameters.AddWithValue("@wipid", sapTaglist.wipid);
                                    cmd.Parameters.AddWithValue("@countdate", sapTaglist.countdate);
                                    cmd.Parameters.AddWithValue("@item", sapTaglist.item);
                                    cmd.Parameters.AddWithValue("@itemdescr", sapTaglist.itemdescr);
                                    cmd.Parameters.AddWithValue("@unit", sapTaglist.unit);
                                    cmd.Parameters.AddWithValue("@type", sapTaglist.type);
                                    cmd.Parameters.AddWithValue("@jobnumber", sapTaglist.jobnumber);
                                    cmd.Parameters.AddWithValue("@productiondate", sapTaglist.productiondate);
                                    cmd.Parameters.AddWithValue("@ProcLineDecr", sapTaglist.ProcLineDecr);
                                    cmd.Parameters.AddWithValue("@BlankTag", sapTaglist.BlankTag);
                                    cmd.Parameters.AddWithValue("@InvtType", sapTaglist.InvtType);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Import Complete!");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUEApplicationDataSet.SAP_TagList' table. You can move, or remove it, as needed.
            this.sAP_TagListTableAdapter.Fill(this.sUEApplicationDataSet.SAP_TagList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWipid.Text))
            {
                MessageBox.Show("Please enter Wipid to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=190.7.10.7;Initial Catalog=SUEApplication;User ID=sa;Password=tns2007";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM SAP_Taglist WHERE wipid = @Wipid";
                        cmd.Parameters.AddWithValue("@Wipid", txtWipid.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
