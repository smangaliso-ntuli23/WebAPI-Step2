using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WebAPI
{
    class Bets
    {
        private int placeBetID, spin;
        private double betAmount, payout;

        
        public int PlaceBetID
        {
            get
            {
                return placeBetID;
            }

            set
            {
                placeBetID = value;
            }
        }
        public int Spin
        {
            get
            {
                return spin;
            }
            set
            {
                spin = value;
            }
        }

        public double BetAmount
        {
            get
            {
                return betAmount;
            }
            set
            {
                betAmount = value;
            }
        }
        public double Payout
        {
            get
            {
                return payout;
            }
            set
            {
                payout = value;
            }
        }
        public Bets()
        {
        
        }

        public Bets(int placeBetID, int spin, double betAmount, double payout)
        {
            this.placeBetID = placeBetID;
            this.spin = spin;
            this.betAmount = betAmount;
            this.payout = payout;
        }

        public List<Bets> GetAllBets()
        {
            List<Bets> bets = new List<Bets>();
            DataHandler dh = new DataHandler();
            return bets;
        }
        public List<Bets> getSpecificBet(int idToGet)
        {
            List<Bets> bets = new List<Bets>();
            DataHandler dh = new DataHandler();
            return bets;
        }

        public double Insert(int spin, double betAmount, double payout)
        {
            DataHandler dh = new DataHandler();
            int affected = dh.InsertBet(spin, betAmount, payout);
            return affected;
        }
        //This has been added to make the format more easier to read
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {4}",placeBetID,betAmount,spin,payout);
        }
    }
}
