Public class Personaje
{
    Public string Nombre {get; set;}
    Public int Vida {get; set;}
    Public int Ataque {get; set;}
    Public int Defensa {get; set;}
    Public int Nivel {get; set;}
}

Personaje personaje = new Personaje
{
   Nombre = "Guerrero",
   Vida = 100, //error para romper el codigo //codigo reparado 
   Defensa = 30,
   Nivel = 1
};
