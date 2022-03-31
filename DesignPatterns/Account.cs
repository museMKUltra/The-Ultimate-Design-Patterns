namespace DesignPatterns
{
    public class Account
    {
        private float _balance;

        public void SetBalance(int balance)
        {
            if (balance > 0)
            {
                _balance = balance;
            }
        }

        public float GetBalance()
        {
            return _balance;
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0)
            {
                _balance -= amount;
            }
        }
    }
}