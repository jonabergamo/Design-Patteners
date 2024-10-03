Archipelago archipelago = new Archipelago("Arquipélago de Observers");

Resident resident1 = new Resident("João");
Resident resident2 = new Resident("Maria");
Resident resident3 = new Resident("Pedro");
Resident resident4 = new Resident("Augusto");


archipelago.RegisterObserver("Magia", resident1);
archipelago.SetHappening("Magia", "Uma explosão magica ocorreu.");
archipelago.RemoveObserver("Magia", resident1);
archipelago.SetHappening("Magia", "Uma explosão magica ocorreu.");
//archipelago.RegisterObserver("Magia", resident2);
//archipelago.RegisterObserver("Fogos de artificio", resident1);
//archipelago.RegisterObserver("Fogos de artificio", resident4);
//archipelago.RegisterObserver("Batalha", resident3);

//archipelago.SetHappening("Batalha", "As guildas se enfrentaram na ponte.");
//archipelago.SetHappening("Fogos de artificio", "Fogos foram acionados perto do porto.");


