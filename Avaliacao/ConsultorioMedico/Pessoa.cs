namespace ConsultorioMedico{
    class Pessoa{
        private string _nome;
        private string _dataNascimento;
        private string _cpf;

        public string Nome{
            get{
                return _nome;
            }
            set{
                _nome = value;
            }
        }

        public string DataNascimento{
            get{
                return _dataNascimento;
            }
            set{
                _dataNascimento = value;
            }
        }

        public string Cpf{
            get{
                return _cpf;
            }
            set{
                _cpf = value;
            }
        }
    }
}