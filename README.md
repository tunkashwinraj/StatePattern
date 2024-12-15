# State Pattern - Checking Account Example

## Overview
This project demonstrates the **State Pattern** in action, applied to a checking account system. It simulates a bank account that transitions between different states based on the balance and actions performed (such as withdrawals, deposits, and interest accrual). The states are represented by classes that handle specific behaviors for each state (e.g., OverDrawState, SilverState, GoldState, PlatinumState).

## Purpose
The purpose of this application is to model the state transitions in a bank account, where each state has its own set of rules for withdrawing money, depositing funds, and adding interest. The state of the account changes based on the balance and user actions, and each state is responsible for managing the behaviors associated with it.

## Components
### 1. `ICheckingActivity` Interface
Defines the methods for withdrawal, deposit, and interest management that will trigger state transitions.

### 2. `CheckingAccount` (Context Class)
Holds account information (such as customer name and account number) and manages the current state of the account. It delegates behavior to the current state object.

### 3. `BaseState` (Abstract State Class)
Represents a generic state, defining the structure for concrete states. It includes methods for withdrawing money, depositing money, and adding interest, with specific implementations in each subclass.

### 4. Concrete State Classes:
   - **`OverDrawState`**: Handles overdraft conditions with a fee for each withdrawal.
   - **`SilverState`**: Applies a transaction fee for withdrawals and does not accrue interest.
   - **`GoldState`**: Charges no transaction fees and applies 3% interest on the balance.
   - **`PlatinumState`**: Charges no transaction fees and applies 4% interest on the balance.

### 5. `CheckStateChange` Method
Each state checks the balance and determines if a transition to another state is required (e.g., moving from SilverState to GoldState).

## Usage
1. **Deposit Money**: Adds a specified amount to the account balance.
2. **Withdraw Money**: Withdraws a specified amount from the account, considering the state's withdrawal rules.
3. **Add Interest**: Adds interest to the account based on the state’s specific interest rate.

## How to Test
1. **Build the project** in Visual Studio.
2. Add a button (`btnTestStatePattern`) to the form and add the following code:
   ```csharp
   private void btnTestStatePattern_Click(object sender, EventArgs e)
   {
       // Create a new CheckingAccount instance and test state transitions
       CheckingAccount acct = new CheckingAccount("Bill", 1234);
       acct.DepositMoney(1200); // Example of state transition
       //acct.WithDrawMoney(500);
       //acct.DepositMoney(6000);
       MessageBox.Show(acct.State.ToString()); // Display the current state
   }
   ```

3. **Run the application** and observe the state transitions by uncommenting the different actions.

## Conclusion
This implementation provides a clear example of the State Pattern applied to an account management system. Each state encapsulates its specific behaviors, and the context object (CheckingAccount) manages transitions between these states.
