public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation is null)
            throw new ArgumentNullException(nameof(operation));

        if (operation == string.Empty)
            throw new ArgumentException("L'opération ne peut pas être vide.", nameof(operation));
        
        switch (operation) 
        {
            case "+" :
                return $"{operand1} + {operand2} = {operand1 + operand2}";
            case "-" :
                return $"{operand1} - {operand2} = {operand1 - operand2}";
            case "/" :
                if (operand2 != 0) 
                {
                    return $"{operand1} / {operand2} = {operand1 / operand2}";
                }
                else return "Division by zero is not allowed.";
            case "*" :
                return $"{operand1} * {operand2} = {operand1 * operand2}";
            default : 
                throw new ArgumentOutOfRangeException(
                    nameof(operation), operation, "Opération inconnue.");
        }
    }
}
