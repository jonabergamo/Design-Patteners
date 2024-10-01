public class Subwoofer
{
    public bool IsOn { get; private set; }
    public int Volume { get; private set; }
    public int CrossoverFrequency { get; private set; }

    public Subwoofer()
    {
        IsOn = false; // Subwoofer desligado inicialmente
        Volume = 50; // Volume padrão
        CrossoverFrequency = 80; // Frequência padrão de corte
    }

    public void PowerOn()
    {
        IsOn = true;
        Console.WriteLine("Subwoofer ligado.");
    }

    public void PowerOff()
    {
        IsOn = false;
        Console.WriteLine("Subwoofer desligado.");
    }

    public void SetVolume(int newVolume)
    {
        if (newVolume < 0 || newVolume > 100)
        {
            Console.WriteLine("Volume fora do intervalo permitido (0-100).");
        }
        else
        {
            Volume = newVolume;
            Console.WriteLine($"Volume ajustado para {Volume}%.");
        }
    }

    public void SetCrossoverFrequency(int frequency)
    {
        if (frequency < 40 || frequency > 200)
        {
            Console.WriteLine("Frequência fora do intervalo permitido (40-200 Hz).");
        }
        else
        {
            CrossoverFrequency = frequency;
            Console.WriteLine($"Frequência de corte ajustada para {CrossoverFrequency} Hz.");
        }
    }

    public void IncreaseVolume()
    {
        if (Volume < 100)
        {
            Volume++;
            Console.WriteLine($"Volume aumentado para {Volume}%.");
        }
        else
        {
            Console.WriteLine("Volume já está no máximo.");
        }
    }

    public void DecreaseVolume()
    {
        if (Volume > 0)
        {
            Volume--;
            Console.WriteLine($"Volume diminuído para {Volume}%.");
        }
        else
        {
            Console.WriteLine("Volume já está no mínimo.");
        }
    }

    public void DisplayStatus()
    {
        string powerStatus = IsOn ? "ligado" : "desligado";
        Console.WriteLine($"Subwoofer está {powerStatus}, Volume: {Volume}%, Frequência de corte: {CrossoverFrequency} Hz.");
    }
}
