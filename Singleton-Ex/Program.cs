Dragon dragonInstance = Dragon.Instance;

dragonInstance.ShowMessage();

Dragon anotherDragonInstance = Dragon.Instance;

anotherDragonInstance.ShowMessage();

if (dragonInstance == anotherDragonInstance)
{
    Console.WriteLine("Ambas as variáveis referenciam a mesma instância.");
}