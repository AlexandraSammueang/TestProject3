using System;
namespace Testtest
{
    public class Kronor
    {
        //public int ÖrenPart1;
        /*
         * Totala värdet i öre. 
         * När vi väl har skapat ett Kronor-objekt ska det aldrig kunna ändras
         */
        private readonly int öre;
        public int Öre => öre;

        // Skapar tom Kronor
        public Kronor()
        {

        }

        // Skapar kopia av en annan Kronor
        public Kronor(Kronor kronor)
        {
            öre = kronor.ÖrenPart() + kronor.KronorPart() * 100;
        }
        /*
         * Skapar Kronor med initialt värde
         */
        public Kronor(int kronor, int öre)
        {
            this.öre = kronor * 100 + öre; // ändrar i constructor 
        }

        /*
         * Returnerar kronordelen av kronorna
         */
        public int KronorPart()
        {
            return öre / 100;
        }


        /*
         * Returnerar öresdelen av kronorna
         */
        public int ÖrenPart()
        {
            return öre % 100;
        }
        /*
         * Adderar den här Kronor med other och returnerar resultatet
         */

        public Kronor Add(Kronor other)
        {
            if (other.isNegative())
            {
                throw new ArgumentException("Adding negative value");
            }
            var tempÖrenAddition = this.ÖrenPart() + other.ÖrenPart(); //tagit bort onödiga paranteser
            var tempKronorAddition = this.KronorPart() * 100 + other.KronorPart() * 100; //ändrat här
            /*if (tempKronorAddition < 0)
            {
                throw new ArgumentException("Negative value");
            }*/ //Tagit bort denna, behövs ej!!

            var tempKronor = tempKronorAddition / 100;

            var tempÖren = tempÖrenAddition % 100;

            return new Kronor(tempKronor, tempÖren);
        }

        public Kronor Subtract(Kronor other)
        {

            var tempÖrenSubbtration = this.ÖrenPart() - other.ÖrenPart();
            var tempKronorSubtraction = this.KronorPart() * 100 - other.KronorPart() * 100;

            var tempKronor = tempKronorSubtraction / 100;
            var tempÖren = tempÖrenSubbtration % 100;

            return new Kronor(tempKronor, tempÖren);

            /* if (amount - other < 0)
             {
                 throw new ArgumentException("Negative amount");
             }
             return amount -= other;*/

            //var temp = this.ÖrenPart() - other.KronorPart() + //tagit bort parentsen
            //    (this.KronorPart() * 100 - other.ÖrenPart() * 10);
            //var tempKronor = temp / 100;
            //var tempÖren = temp % 100;

            //return new Kronor(tempKronor, tempÖren);
        }
        /*
         * Returnerar sant om kronorna har ett positivt värde
         */
        public bool isPositive()
        {
            return öre > 0;
        }

        /*
         * Returnerar sant om kronorna har ett negativt värde
         */
        public bool isNegative()
        {
            return öre < 0;
        }

        /*
         * Returnerar sant om kronorna har ett värde på 0
         */
        public bool isZero()
        {
            return öre == 0;
        }
    }
}
