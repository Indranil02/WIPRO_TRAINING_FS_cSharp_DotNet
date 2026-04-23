using System;

namespace BankingSystemCaseStudy
{
    // --- TASK 1: CREATE CUSTOM EXCEPTIONS ---

    // US5: Custom exception for insufficient funds or minimum balance violations 
    public partial class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    // Custom exception for invalid amount inputs (<= 0) 
    public partial class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }

    // --- TASK 2: CREATE BANKACCOUNT CLASS ---

    public class BankAccount
    {
        // AccountHolderName, Balance 
        public string AccountHolderName { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string name, double initialBalance)
        {
            AccountHolderName = name;
            // Minimum balance should be ₹1000 
            if (initialBalance < 1000)
                throw new InsufficientBalanceException("Account creation failed: Initial balance must be at least ₹1000.");

            Balance = initialBalance;
        }

        // Deposit Method 
        public void Deposit(double amount)
        {
            //Deposit amount must be greater than 0 
            if (amount <= 0)
                throw new InvalidAmountException("Deposit failed: Amount must be greater than 0.");

            Balance += amount;
            Console.WriteLine($"Successfully deposited: ₹{amount}");
        }

        // Withdraw Method [cite: 31]
        public void Withdraw(double amount)
        {
            // Invalid inputs should throw appropriate exceptions 
            if (amount <= 0)
                throw new InvalidAmountException("Withdrawal failed: Amount must be greater than 0.");

            // Withdrawal amount cannot exceed balance 
            if (amount > Balance)
                throw new InsufficientBalanceException("Withdrawal failed: Insufficient funds.");

            // Minimum balance of ₹1000 must be maintained 
            if (Balance - amount < 1000)
                throw new InsufficientBalanceException("Withdrawal failed: Maintenance of ₹1000 minimum balance required.");

            Balance -= amount;
            Console.WriteLine($"Successfully withdrew: ₹{amount}");
        }

        // Check Balance Method 
        public void CheckBalance()
        {
            Console.WriteLine($"Account: {AccountHolderName} | Current Balance: ₹{Balance}");
        }
    }

    // --- TASK 3: IMPLEMENT MAIN WITH TRY-CATCH-FINALLY ---

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Banking Transaction System ===\n");
            BankAccount myAccount = null;

            // Use try-catch-finally 
            try
            {
                // Test with inputs 
                myAccount = new BankAccount("Alex", 5000);
                myAccount.CheckBalance();

                Console.WriteLine("\n[Action]: Depositing ₹1500...");
                myAccount.Deposit(1500);

                Console.WriteLine("\n[Action]: Attempting to withdraw ₹6000 (Should trigger exception)...");
                myAccount.Withdraw(6000);
            }
            catch (InsufficientBalanceException ex)
            {
                // Print proper messages 
                Console.WriteLine($"Caught Error: {ex.Message}");
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine($"Caught Error: {ex.Message}");
            }
            catch (ArgumentException ex) // Built-in exception 
            {
                Console.WriteLine($"Argument Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                // Finally block for clean session termination 
                Console.WriteLine("\n--- Session Summary ---");
                myAccount?.CheckBalance();
                Console.WriteLine("Transaction processing complete.");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}