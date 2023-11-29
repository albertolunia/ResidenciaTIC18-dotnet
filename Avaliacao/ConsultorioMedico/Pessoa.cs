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

        public string FormatarCPF(string cpf){
            return cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }

        public string FormatarData(string data){
            return data.Insert(2, "/").Insert(5, "/");
        }
    }
}