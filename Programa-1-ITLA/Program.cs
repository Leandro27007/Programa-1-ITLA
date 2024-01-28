using Programa_1_ITLA;

Socio socio1 = new("Marcos", 2);
Socio socio2 = new("Pedro", 9);
Socio socio3 = new("Esteban", 3);


Club club = new(socio1, socio2, socio3);

club.imprimirMayorSocio();


Console.ReadLine();

