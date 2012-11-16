using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Discount_check_action
{
    public partial class Discount_check_action : Form
    {
        public Discount_check_action()
        {
            InitializeComponent();
        }

        string name;
        string source;
        string local_adr;
        string nomenclature_id;

        const int group_min = 1;
        int group_max;

        int groupid = 1;

        OleDbConnection conn;

        private MySqlCommand cmd;
        private MySqlConnection serverConn;
        private string connStr;

        //import dll from use configuration file
        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(
        string lpAppName,
        string lpKeyName,
        string lpDefault,
        StringBuilder lpReturnedString,
        uint nSize,
        string lpFileName);

        private void Discount_check_action_Shown(object sender, EventArgs e)
        {
            clear_log();

            Log.log_write("Приложение запущено", "INFO", "Discount_check");

            load_config();

            load_group();
        }
       
        private void load_group()
        {
            switch (groupid)
            {
                case 1:
                    label_group_text.Text = "Акционные товары";
                    break;
                case 2:
                    label_group_text.Text = "Табачные Изделия";
                    break;
                case 3:
                    label_group_text.Text = "Сахар Фиксир.Цена";
                    break;
                case 4:
                    label_group_text.Text = "Пакет П/Э Цена.Изг";
                    break;
                case 5:
                    label_group_text.Text = "       Контейнеры ";
                    break;
            }

            if (group_min == groupid)
                button_group_prev.Enabled = false;
        }

        private void clear_log()
        {
             try
             {
                 DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + "/log/");

                 if (!Directory.Exists(Environment.CurrentDirectory + "/log/"))
                     return;

                 foreach (FileInfo fi in di.GetFiles())
                 {
                     fi.Delete();
                 }
             }
             catch (System.Exception ex)
             {
                 Log.log_write(ex.Message, "Exception", "Exception");
                 MessageBox.Show(ex.Message);
             }
        }

        private void get_name()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("GROUP", groupid.ToString(), "null", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            name = buffer.ToString();
        }

        private void load_config()
        {
            get_name_file();

            get_source();

            get_connect();

            get_group_max();

            get_local_adr();

            get_nomenclature_id();
            
            Log.log_write("Параметры из конфигурации загружены", "INFO", "Discount_check");
        }

        private void get_name_file()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "name", "", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            name = buffer.ToString();
        }

        private void get_nomenclature_id()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "nomenclature_id", "1", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            nomenclature_id = buffer.ToString();
        }

        private void get_source()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "source", "", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            source = "\\" + buffer.ToString() + "\\";
        }

        private void get_local_adr()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "local_adr", "", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            local_adr = buffer.ToString();
        }

        private void get_group_max()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "group_max", "", buffer, 50, Environment.CurrentDirectory + "\\config.ini");

            group_max = Convert.ToInt32(buffer.ToString());
        }

        private void get_connect()
        {
            StringBuilder buffer = new StringBuilder(10, 50);

            GetPrivateProfileString("SETTINGS", "srv_local ", "", buffer, 50, Environment.CurrentDirectory + "\\config.ini");
            connStr = string.Format("server={0};uid={1};pwd={2};database={3};", buffer, "pricechecker", "7194622Parti", "ukmserver");
            serverConn = new MySqlConnection(connStr);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            progressBar1.Value = 0;
            button_fix.Enabled = false;

            progressBar1.Maximum = (Convert.ToInt32(count_to_xls("SELECT COUNT(*) FROM [Лист1$]", name)))-1;

            query_to_xls("SELECT * FROM [Лист1$]", name, 0);
        }

        private void update_flag()
        {
            try
            {
                if (File.Exists(local_adr + "//cash01.upd"))
                {
                    File.Delete(local_adr + "//cash01.upd");
                }
            }
            catch (System.Exception ex)
            {
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
            }
         
        }

        private void send_file()
        {
            while (File.Exists(local_adr + "//cash01.upd"))
            {
                toolTip1.Show("Жду снятия флага обновления", this);

                Application.DoEvents();
            }

            if (!File.Exists(local_adr + "//cash01.upd"))
            {
                toolTip1.Show("Установка флага...", this);
                File.Copy(Environment.CurrentDirectory + "//pattern//" + "cash01.upd", local_adr + "//cash01.upd");
            }
        }

        private void button_fix_Click(object sender, EventArgs e)
        {
            button_fix.Enabled = false;

            try
            {
                serverConn.Open();

                send_file();

                insert_dbf("DELETE FROM 'PLULIM'");

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    string par = dr.Cells[3].Value.ToString().Replace(" ", "");
                    string bar = dr.Cells[0].Value.ToString().Replace(" ", "");

                    if (par == "Цена?")
                    {

                    }
                    else
                    {
                        insert_dbf("INSERT INTO PLULIM.DBF (CARDARTICU,PERCENT) VALUES ('" + bar + "',100)");

                        Log.log_write("Запрет скидки установлен: " + bar, "UPDATE", "update");
                    }
                }

                update_flag();
            }

            catch(Exception ex)
            { 
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (serverConn.State == ConnectionState.Open)
                    serverConn.Close();

                button_search.PerformClick();
            }
        }

        private void insert_dbf(string str)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            conn.ConnectionString = "Provider=vfpoledb;Data Source=" + local_adr + ";Collating Sequence=MACHINE;CODEPAGE=866";

            cmd.Connection = conn;

            try
            {
                conn.Open();
                
                cmd.CommandText = str;

                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (serverConn.State == ConnectionState.Open)
                    serverConn.Close();

                while (File.Exists(local_adr + "//cash01.upd"))
                {
                    toolTip1.Show("Ожидаем выгрузку в базу...", this);

                    Application.DoEvents();
                }

                if (!File.Exists(local_adr + "//cash01.upd"))
                {
                    toolTip1.Hide(this);
                }

                button_fix.Enabled = true;
            }
        }

        private void check_action(string barcode,string price_pattern)
        {
            MySqlDataReader reader;

            try
            {
                serverConn.Open();

                cmd = new MySqlCommand("SELECT item,price,minprice FROM trm_in_pricelist_items WHERE nomenclature_id = '"+ nomenclature_id +"' AND item = '" + barcode + "'", serverConn);

                reader = cmd.ExecuteReader();

                Application.DoEvents();

                while (reader.Read())
                {
                 UInt32 price_in_base = Convert.ToUInt32(reader.GetValue(1));
                 UInt32 price_min = Convert.ToUInt32(reader.GetValue(2));

                 if (price_in_base != Convert.ToUInt32(price_pattern))   
                 {
                     Log.log_write("Акционная цена не верна у штрихкода: " + reader.GetValue(0) + " Должна быть: " + price_pattern + " В базе " + price_in_base, "PRICE", "WARNING_PRICE");
                     dataGridView1.Rows.Add(barcode, price_in_base, price_min, "2");
                 }
                 else if (price_in_base != price_min)
                 {
                     Log.log_write("На акционный товар не установлен запрет акции: " + reader.GetValue(0), "PRICE", "WARNING_PRICE");
                     dataGridView1.Rows.Add(barcode, price_in_base, price_min, "1");
                 }
                 else if (price_in_base == price_min)
                 {
                      Log.log_write("Проверен успешно: " + reader.GetValue(0), "PRICE", "Check_true");
                 }
                 progressBar1.PerformStep();
                }

                if (!reader.Read())
                {
                    progressBar1.PerformStep();
                }
                
            }

            catch (Exception exc)
            {
                Log.log_write(exc.Message, "Exception", "Exception");
                MessageBox.Show(exc.Message);
            }
            finally
            {
                if (serverConn.State == ConnectionState.Open)
                    serverConn.Close();
            }

        }

        private object query_to_xls(string query, object name, int par)
        {
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + source + name + ";Extended Properties= \"Excel 8.0;HDR=YES;\"");

            OleDbDataReader myReader;

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    switch (par)
                    {      
                        case 0:  
                             string barcode = myReader.GetValue(0).ToString().Replace(" ", "");
                             string price = myReader.GetValue(2).ToString().Replace(" ", "");
                             
                             check_action(barcode, price);
                             break;
                        case 1:
                            return myReader.GetValue(1);
                        default:
                            break;
                    }
                }
            }

            catch (System.Exception ex)
            {
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
                return null;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                button_fix.Enabled = true;
            }

            return null;
        }

        private object count_to_xls(string query, object name)
        {
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + source + name + ";Extended Properties= \"Excel 8.0;HDR=YES;\"");

            OleDbDataReader myReader;

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                myReader = cmd.ExecuteReader();

                Object[] values = null;

                while (myReader.Read())
                {
                    values = new Object[myReader.FieldCount];
                    myReader.GetValues(values);
                    return values[0];
                }
            }

            catch (System.Exception ex)
            {
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return null;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Int32 val;

			val = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

             switch (val)
			 {
			 case 1:
                     dataGridView1.Rows[e.RowIndex].Cells["Column4"].Style.ForeColor = Color.Red;
                     dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value = "Запрет?";
				 break;
			 case 2:
                 dataGridView1.Rows[e.RowIndex].Cells["Column4"].Style.ForeColor = Color.Brown;
                 dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value = "Цена?";
				 break;
			 }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        string bar = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                        string msg = (query_to_xls("SELECT * FROM [Лист1$] WHERE BARCODE = '" + bar + "'", name, 1)).ToString().Replace("  ", "");

                        DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["Column1"];

                        cell.ToolTipText = msg;
                        break;
                    case 1:
                        //cell = dataGridView1.Rows[e.RowIndex].Cells["Column2"];
                        //cell.ToolTipText = "2";
                        break;
                    case 2:
                        //cell = dataGridView1.Rows[e.RowIndex].Cells["Column3"];
                        //cell.ToolTipText = "3";
                        break;
                    case 3:
                        cell = dataGridView1.Rows[e.RowIndex].Cells["Column4"];

                        string err = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();

                        if (err == "Запрет?")
                            cell.ToolTipText = "Не установлена опция запрет акции!";
                        else if (err == "Цена?")
                            cell.ToolTipText = "Различия в цене по прайсу!";
                        break;
                    default:
                        break;
                }
            }
            catch (System.Exception ex)
            {
                Log.log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
            }
        }

        private void button_group_next_Click(object sender, EventArgs e)
        {
            groupid++;

            if (groupid > group_min)
                button_group_prev.Enabled = true;

            if (groupid == group_max)
                button_group_next.Enabled = false;

            load_group();
            get_name();
            dataGridView1.Rows.Clear();
            //button_search.PerformClick();
        }

        private void button_group_prev_Click(object sender, EventArgs e)
        {
            groupid--;

            if (group_max > groupid)
                button_group_next.Enabled = true;

            if (groupid == group_min)
                button_group_prev.Enabled = false;

            load_group();
            get_name();
            dataGridView1.Rows.Clear();
            //button_search.PerformClick();
        }
    }
}
