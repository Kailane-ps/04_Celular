namespace celular_2
{
    public class Celular1
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public string Ligar(){
            ligado = true;
            return "Celular ligado";
        }

        public string Desligar(){
            ligado = false;
            return "Celular desligado";
        }

        public string Mensagem(){
            return "Enviando Mensagem";
        }

        public string Ligacao(){
            return "Fazendo Ligação";
        }
    }
}