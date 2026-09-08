static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) {
           return 3.213f;
       }
        else if (balance < 1000 && balance >=0){
            return 0.5f;
        }
        else if (balance >= 1000 && balance < 5000){
            return 1.621f;
        }
        else {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        if (balance < 0) {
           return 3.213m/100 * balance;
       }
        else if (balance < 1000 && balance >=0){
            return 0.5m/100 * balance;
        }
        else if (balance >= 1000 && balance < 5000){
            return 1.621m/100 * balance;
        }
        else {
            return 2.475m/100 * balance;
        }
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        if (balance < 0) {
           return 3.213m/100 * balance + balance;
       }
        else if (balance < 1000 && balance >=0){
            return 0.5m/100 * balance + balance;
        }
        else if (balance >= 1000 && balance < 5000){
            return 1.621m/100 * balance + balance;
        }
        else {
            return 2.475m/100 * balance + balance;
        }
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        if (balance >= targetBalance){
            return 0;
        }

        int years=0;

        decimal currentBalance = balance;

        while (currentBalance < targetBalance)
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            years ++;
        }

        return years;
    }
}
