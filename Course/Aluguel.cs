namespace Course {
    class Aluguel {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, int quarto) {
            Nome = nome;
            Quarto = quarto;
        }

        public Aluguel(string nome, string email, int quarto) : this(nome, quarto) {
            Email = email;
        }

        public override string ToString() {
            return Quarto 
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
