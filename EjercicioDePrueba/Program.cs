using Team;

var fcbarcelona = new Team<AtletaFutball>(2);
fcbarcelona.NombreCoach = "Xavi Hernández";
fcbarcelona.Miembros[0] = new AtletaFutball 
{ 
    Nombre = "Robert Lewandowski", 
    Altura = 1.85, 
    Peso = 81, 
    GolesAnotados = 5, 
    Posicion = "Delantero" 
};

fcbarcelona.Miembros[1] = new AtletaFutball
{
    Nombre = "Gavi",
    Altura = 1.70,
    Peso = 80,
    GolesAnotados = 2,
    Posicion = "MedioCampista"
};

var losAngelesDodgers = new Team<AtletaBeisball>(1);
losAngelesDodgers.NombreCoach = "";
losAngelesDodgers.Miembros[0] = new AtletaBeisball
{
    Nombre = "Julio Urías",
    Posicion = "Pitcher",
    JuegosIiciados = 50
};

// imprimir informacion de los equipos
Console.WriteLine("Equipo de Fútbol");
Console.WriteLine($"DT: {fcbarcelona.NombreCoach}");
foreach (var player in fcbarcelona.Miembros)
{
    Console.WriteLine($"Jugador: {player.Nombre}, " +
        $"Posicion: {player.Posicion}, " +
        $"Goles Anotados: {player.GolesAnotados}");
}