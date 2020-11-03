namespace exercicio1
{
    public class Guerreiro : Personagem {

        public Guerreiro(string nome) {
            this.Nome = nome;
            this.Ataque = 30;
            this.Defesa = 20;
            this.PV = 10;
            this.Tipo = "Guerreiro";
        }

        public int Atacar() {
            return this.Ataque + 1;
        }

        public int AtacarComEspada(string tipo) {
            if (tipo == "curta")
            {
                return this.Ataque + 3;
            }
            else if (tipo == "longa")
            {
                return this.Ataque + 5;
            }
            else {
                return this.Ataque;
            }
        }

        public void Defender(int ataqueInimigo) {
            if (ataqueInimigo > this.Defesa)
            {
                this.PV -= ataqueInimigo - this.Defesa;
            }
        }
    }
}    
