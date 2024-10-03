Archipelago archipelago = new Archipelago("Arquipélago de Observers");

Resident resident1 = new Resident("João");
Resident resident2 = new Resident("Maria");
Resident resident3 = new Resident("Pedro");
Resident resident4 = new Resident("Augusto");


archipelago.RegisterObserver("Magia", resident1);
archipelago.RegisterObserver("Magia", resident2);
archipelago.RegisterObserver("Fogos de artificio", resident1);
archipelago.RegisterObserver("Fogos de artificio", resident4);
archipelago.RegisterObserver("Batalha", resident3);

archipelago.SetHappening("Magia", "O evento de magia ocorrerá hoje as 19h na praça principal.");
archipelago.SetHappening("Batalha", "As guildas se enfrentarão 21h na ponte ao lado do castelo.");
archipelago.SetHappening("Fogos de artificio", "Fogos serão acionados perto do porto as 18h.");


