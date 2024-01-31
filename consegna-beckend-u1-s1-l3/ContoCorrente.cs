using System;

namespace consegna_beckend_u1_s1_l3
{
    internal class ContoCorrente
    {
        private string name { get; set; }
        private string surname { get; set; }
        private double balance { get; set; }
        private bool open { get; set; }

        public ContoCorrente(string name, string surname, int balance, bool open)
        {
            this.name = name;
            this.surname = surname;
            this.balance = balance;
            this.open = open;
        }

        public void GetInfo()
        {

            {

                Console.WriteLine($"Ciao {this.name} {this.surname}. Il tuo saldo è: {this.balance}");

            }

        }
        public string Payment(double x)
        {
            this.balance += x;
            return $"Hai depositato {x} sul tuo conto. Il tuo saldo è {this.balance}";
        }

        public string Withdrawal(double x)
        {
            if (x > this.balance)
            {
                Console.WriteLine("Fondi insufficienti");
            }
            this.balance -= x;
            return $"Hai prelevato {x} dal tuo conto. Il tuo saldo è: {this.balance}";
        }







    }
}
