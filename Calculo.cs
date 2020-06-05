namespace Aula11PolimorfismoOverload
{
    public class Calculo
    {
        public string Calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int vida){
            return $"O jogador está com {vida} de vida ";
        }

        public string Calcular(int vida, int escudo){
            return "A vida do jogador com escudo é "+(vida+escudo);
        
        }

        public string Calcular(int vida, int escudo, int poderDeAtk){
            return "A vida do jogador com escudo é "+(vida+escudo)+" e seu poder de ataque é de "+poderDeAtk;
        
        }

        public string Calcular(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }

        
    }
}