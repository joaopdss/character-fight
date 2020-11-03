namespace exercicio1
{
    public class Mago : Personagem {
        public Mago(string nome) {
            this.Nome = nome;
            this.Ataque = 20;
            this.Defesa = 10;
            this.PV = 30;
            this.Tipo = "Mago";
        }

        public int Atacar() {
            return this.Ataque;
        }

        public int AtacarComMagia(string tipo) {
            if (tipo == "fogo")
            {
                return this.Ataque + 10;
            }
            else if (tipo == "gelo")
            {
                return this.Ataque + 15;
            }
            else if (tipo == "raio")
            {
                return this.Ataque + 25;
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