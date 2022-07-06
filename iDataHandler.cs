using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebAPI
{
    interface iDataHandler
    {
        DataSet ReadPlaceBets(string tableName);

        DataSet GetSelectedBet(int placeBetID);

        int InsertBet(int spin, double betAmount, double payout);

        int DeleteBet(int placeBetID);

        int UpdateBet(int placeBetID, int spin, double betAmount, double payout);
    }
}
