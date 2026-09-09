
namespace MeuPrimeiroPrograma.Caneta
{
    public class Caneta

    {
        public string Cor;
        public bool TemTampa;

        public Caneta(string cor, bool temTampa)
        { 
        
        Cor=cor;
           
         TemTampa=temTampa;    
        
        
        }






        public string Chamar()

        {

            string result = $" A caneta tem cor: {Cor}";


            if (TemTampa)

            {


                result += "Tem Tampa";



            }


            else
            {


                result += "Nao tem tampa";

            }


            return result;
        }
        }
}
