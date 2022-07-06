using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WebAPI
{
    class DataHandler : iDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection conn = new SqlConnection();

        public DataHandler() 
        {
            connection.DataSource = @"LEDON\SQLEXPRESS";
            connection.InitialCatalog = "PlaceBet";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadPlaceBets(string tableName) 
        {
            DataSet rData = new DataSet();
            conn = new SqlConnection(connection.ToString());
            string qry = string.Format("");
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rData, SchemaType.Source, "tblPlaceBet");
                adapter.Fill(rData, "tbPlaceBet");
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State==ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            return rData;
        }
        public DataSet GetSelectedBet(int placeBetID)
        {
            DataSet rData = new DataSet();
            string qry = string.Format("SELECT * FROM tblPlaceBet WHERE PlaceBetID = {0}", placeBetID);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rData, SchemaType.Source, "tblPlaceBet");
                adapter.Fill(rData, "tblPlaceBet");
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rData;
        }
        public int DeleteBet(int placeBetID)
        {
            conn = new SqlConnection(connection.ToString());
            string qry = string.Format("DELETE FROM tblPlaceBet WHERE placeBetID = {0}", placeBetID);//This is code creates a connection to your database and runs an delete query
            int rowChanged = 0;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qry, conn);
                rowChanged = command.ExecuteNonQuery();
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rowChanged;
        }

        public int InsertBet(int spin, double betAmount, double payout)//This is code creates a connection to your database and runs an insert query
        {
            conn = new SqlConnection(connection.ToString());
            string qry = string.Format("INSERT INTO tblPlaceBet (Spin,BetAmount,Payout) VALUES ({0}, {1}, {2})", spin, betAmount, payout);
            int rowsAffected = 0;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qry, conn);
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                    {
                    conn.Close();
                }
            }
            return rowsAffected;
        }
        public int UpdateBet(int placeBetID, int spin, double betAmount, double payout)//This is code creates a connection to your database and runs an update query
        {
            conn = new SqlConnection(connection.ToString());
            string qry = string.Format("UPDATE tblPlaceBet SET" + "[Spin] = {0}, [BetAmount] = {1}, [Payout] = {2} WHERE [PlaceBetID] ={3}", spin, betAmount, payout, placeBetID);
            int changed = 0;
            try
            {
                SqlCommand command = new SqlCommand(qry, conn);
                command.Parameters.AddWithValue("@spinChange", spin);
                command.Parameters.AddWithValue("@betAmountChange", betAmount);
                command.Parameters.AddWithValue("@payoutChange", payout);
                command.Parameters.AddWithValue("@placeBetID", placeBetID);

                conn.Open();
                changed = command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return changed;
        }
    }
}
