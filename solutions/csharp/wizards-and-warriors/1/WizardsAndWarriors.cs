abstract class Character
{
    string characterType="";
    
    protected Character(string characterType)
    {
        this.characterType = characterType;    
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
            return false;
    }

    public override string ToString()
    {
       return $"Character is a {this.characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    bool spellPrepared = false;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return this.spellPrepared ? 12 : 3;
    }

    public void PrepareSpell()
    {
        this.spellPrepared = true;
    }

    public override bool Vulnerable()
    {
        return !this.spellPrepared;
    }
}
