using System;

namespace ConsoleApp1
{
    public class ExemploVeiculo
    {
        private abstract class Veiculo
        {
            public int Ano { get; private set; }
            public string Marca { get; private set; }

            public Veiculo(int Ano, string Marca)
            {
                this.Ano = Ano;
                this.Marca = Marca;
            }

            public virtual void Buzinar()
            {
                Console.WriteLine("Bip! Bip!");
            }

            public abstract void Acelerar();
        }

        private class Carro : Veiculo
        {
            public int Velocidade { get; private set; }

            public Carro(int Velocidade, int Ano, string Marca) : base(Ano, Marca)
            {
                this.Velocidade = Velocidade;
            }

            public override void Buzinar()
            {
                if (Velocidade > 100)
                    Console.WriteLine("FUM! FUM!");
                else
                    Console.WriteLine("Fom! Fom!");
            }

            public override void Acelerar()
            {
                Console.WriteLine("Pressionando o acelerador com o pé");
            }
        }

        private class Moto : Veiculo
        {
            public bool PossuiCanoCortado { get; set; }

            public Moto(bool PossuiCanoCortado, int Ano, string Marca) : base(Ano, Marca)
            {
                this.PossuiCanoCortado = PossuiCanoCortado;
            }

            public override void Buzinar()
            {
                if (PossuiCanoCortado)
                    Console.WriteLine("Vrum! Vrum!");
                else
                    Console.WriteLine("Bop! Bop!");
            }

            public override void Acelerar()
            {
                Console.WriteLine("Girando o acelerar com a mão");
            }
        }

        public static void Executar()
        {
            Carro carro1 = new Carro(100, 2020, "Bmw");
            Moto moto1 = new Moto(true, 2021, "Honda");

            carro1.Buzinar();
            carro1.Acelerar();

            moto1.Acelerar();
            moto1.Buzinar();

            Console.ReadKey();
        }
    }
}
