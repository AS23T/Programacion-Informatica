class Lenguaje
{
    private string nombre;
    private string año;
    public Lenguaje(string nombre, string año)
    {
        this.nombre = nombre;
        this.año = año;
    }
    public void descripcion()
    {
        Console.WriteLine("{0} fue creado en el año {1}", this.nombre, this.año);
    }
}