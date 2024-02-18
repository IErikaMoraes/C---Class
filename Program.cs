namespace classes
{
    internal class Program
    {

        public class Animal
        {
            //VIRTUAL: permite a subreescrever a função primária da Classe de origem
            public virtual void Comer()
            {
                Console.WriteLine("Sou um animal e estou a comer");
            }

            public void Lavar()
            {
                Console.WriteLine("Sou um animal e estou a lavar-me");
            }

        }


        //HERANÇA
        public class Cão: Animal
        {
            //OVERRIDE: é possível sobreescrever a função de mesmo nome herdada da classe originária
            public override void Comer()
            {
                Console.WriteLine("Sou um Cão e estou a comer");
            }

            public void Ladrar()
            {
                Console.WriteLine("Sou um Cão e ladro");
            }

        }

        public class PastorAlemão: Cão
        {
            public void ChamarPastorAlemao()
            {
                Console.WriteLine("Chamar Alemão");
            }
        }


        public class Gato: Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Sou um gato e estou a comer");
            }

            public void miar() 
            {
                Console.WriteLine("Sou um gato e mio.");
            }

        }


        abstract class AnimalAbstrato
        {
            public int valor;

            public abstract string ComerAbstrato();
        }


        class CãoAbstrato: AnimalAbstrato
        {
            public override string ComerAbstrato()
            {
                return "sou um CãoAbstrato";
            }
        }


        class GatoAbstrato: AnimalAbstrato
        {
            public override string ComerAbstrato()
            {
                return "sou um GatoAbstrato";
            }


        }



        static void Main(string[] args)
        {

            Animal animal = new Animal();
            animal.Comer();
            animal.Lavar();


            Cão cão = new Cão();
            cão.Comer();
            cão.Lavar();
            cão.Ladrar();

            PastorAlemão pastorAlemao = new PastorAlemão();
            pastorAlemao.ChamarPastorAlemao();

            Gato gato = new Gato(); 
            gato.Comer();
            gato.Lavar();
            gato.miar();


            //CLASSES ABSTRATAS - a classe base não pode ser
            //instanciada diretamente, é preciso criar Classes "Descendentes" para aplicar a um objeto
            
            CãoAbstrato cãoAbst = new CãoAbstrato();
            cãoAbst.ComerAbstrato();
            cãoAbst.valor++;

            GatoAbstrato gatoAbstrato = new GatoAbstrato();
            gatoAbstrato.ComerAbstrato();
            gatoAbstrato.valor++;

        }
    }
}