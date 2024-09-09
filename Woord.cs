class Woord
{
    private string _tekst;
    public string Tekst {get {return _tekst;} private set {_tekst = value;} }

    public Woord(string tekst) 
    {
        _tekst = tekst;
    }
    public int AantalKlinkers(){
        int n = Tekst.Length;
        int ak = 0;

        for (int i = 0; i < n; i++)
        {
            if (Tekst[i] == 'a' || Tekst[i] == 'e' || Tekst[i] == 'i' || Tekst[i] == 'o' || Tekst[i] == 'u' ||
                Tekst[i] == 'A' || Tekst[i] == 'E' || Tekst[i] == 'I' || Tekst[i] == 'O' || Tekst[i] == 'U')
            {
                ak++;
            }
        }
        return ak;
    }
    public int AantalMedeKlinkers(){
        int n = Tekst.Length;
        int amk = 0;

        for (int i = 0; i < n; i++)
        {
            if (Tekst[i] != 'a' && Tekst[i] != 'e' && Tekst[i] != 'i' && Tekst[i] != 'o' && Tekst[i] != 'u' &&
                Tekst[i] != 'A' && Tekst[i] != 'E' && Tekst[i] != 'I' && Tekst[i] != 'O'&& Tekst[i] !='U')
            {
                amk++;
            }
        }
        return amk;
    }

    public override string ToString()
    {
        return $"{_tekst}\nAantal klinkers: {this.AantalKlinkers()} Aantal mede klinkers: {this.AantalMedeKlinkers()}";
    }
}