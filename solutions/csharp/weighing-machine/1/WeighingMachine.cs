class WeighingMachine
{
    private int precision = 0;
    private double weight = 0;
    private double tareAdjustment = 5;
    
    public WeighingMachine (int precision){
        this.precision = precision;
    }    
    public int Precision {
        get {
            return precision;
        }
    }

    public double Weight {
        get {
            return weight;
        }
        set {
            if (value < 0) {
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative.");
            }
            weight = value;
        }
    }

    public double TareAdjustment {
        get {
            return tareAdjustment;
        }
        set {
            tareAdjustment = value;
        }
    }

    public string DisplayWeight {
        get {
            double result = Weight - TareAdjustment;
            return $"{result.ToString("F" + Precision)} kg";
        }
    } 
}
