using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepositManager
{
    internal class DataModels
    {
        public enum LockerTier
        {
            Gold,
            Silver,
            Bronze
        }

       public struct SecurityPin
        {
            public int Pincode;
            
            public SecurityPin(int InitPin)
            {
                Pincode = InitPin;
            }
        }

        public class CustomerProfile
        {
            public string Name { get; set; }
            public CustomerProfile(string name)
            {
                Name = name;
            }
        }

        public class DepositBox
        {
            private decimal _storedCash;

            protected decimal baseFee = 50.00m;

            public CustomerProfile Owner { get; set; }
            public LockerTier Tier { get; set; }
            public SecurityPin Pin { get; set; }

            public decimal StoredCash
            {
                get { return _storedCash; }
                set { _storedCash = value; }
            }

            public DepositBox()
            {
                Owner = new CustomerProfile("Tim");
                Tier = LockerTier.Bronze;
                Pin = new SecurityPin(1111); /
                _storedCash = 0.00m;
            }

            public DepositBox(string ownerName, LockerTier tier, int pinCode)
            {
                Owner = new CustomerProfile(ownerName);
                Tier = tier;
                Pin = new SecurityPin(pinCode);
                _storedCash = 0.00m;
            }

            public void Deposit(decimal cashAmount)
            {
                _storedCash += cashAmount;
            }

            public string Deposit(string itemDescription)
            {
                return $"Successfully locked away: {itemDescription}";
            }

            public virtual decimal CalculateAnnualFee()
            {
                return baseFee;
            }
        }

        public class VIPDepositBox : DepositBox
        {
            public VIPDepositBox(string ownerName, int pinCode)
                : base(ownerName, LockerTier.Gold, pinCode)
            {
            }

            public override decimal CalculateAnnualFee()
            {
                return baseFee * 0.80m;
            }
        }
    }
}
