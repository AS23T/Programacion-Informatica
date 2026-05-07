// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using EjmeploOO_Pesonas;
/*
Gamer jj = new Gamer(42, "Koke", 60, "Kokerock");
Console.WriteLine("Hello, " +
    jj.Nombre 
    + " tienes " + jj.Edad 
    + " años!! " +
    //"Estas jugando " 
    //+ jj.vg.Nombre
    "\n");
jj.jugar();

Deportista lg = new Deportista(25, "Linda", 165, 60);
Console.WriteLine("Hello, " +
    lg.Nombre
    + " tienes " + lg.Edad
    + " años!! " +
    //"Estas practicando "
    //+ lg.d.Nombre +
    "\n");
lg.jugar();

Deportista[] d = new Deportista[3];
d[0] = new Deportista(25, "Juan", 175, 70);
d[1] = new Deportista(22, "Maria", 165, 50);
d[2] = new Deportista(20, "Pedro", 172, 75);

// Jugar para cada deportista, version foreach
foreach (var item in d)
{
    Console.WriteLine("Hola " + item.Nombre);
    item.jugar();
}

Gamer[] g = new Gamer[3];
g[0] = new Gamer(25, "Daniel", 60, "DinoDan");
g[1] = new Gamer(22, "Luis", 38, "Louie");
g[2] = new Gamer(20, "Sara", 45, "SarahConnor");

// Jugar para cada gamer, version for
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Hola " + g[i].Nombre);
    g[i].jugar();
}
*/

Persona[] p = new Persona[3];
p[0] = new Gamer(25, "Daniel", 60, "DinoDan");
p[1] = new Deportista(22, "Luis", 172, 68);
p[2] = new Gamer(20, "Sara", 45, "SarahConnor");

// Jugar para cada persona, version for
for (int i = 0; i < 3; i++)
{
    p[i].mostrarDatos();
    p[i].jugar();
}