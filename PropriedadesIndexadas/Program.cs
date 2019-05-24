using System;
using System.Collections.Generic;

namespace PropriedadesIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinemark = new Cinema();
            var rafael = new Cliente("Rafael");            
            var vanessa = new Cliente("Vanessa");
            var isabela = new Cliente("Isabela");

            cinemark["M5"] = rafael;
            cinemark["M6"] = vanessa;
            cinemark["M6"] = isabela;

            cinemark.ImprimirReservas();

            Console.ReadKey();
        }
    }

    public class Cinema
    {
        public string Assento { get; set; }
        public Cliente Cliente { get; set; }

        private readonly IDictionary<string, Cliente> Reservas = new Dictionary<string, Cliente>();

        public Cliente this[string assento]
        {
            get
            {
                return Reservas[assento];
            }
            set
            {
                Reservas[assento] = value;
            }
        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos reservados:");
            foreach (var item in Reservas)
            {
                Console.WriteLine($"Assento -> {item.Key} - Cliente -> {item.Value.Nome}");
            }
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
