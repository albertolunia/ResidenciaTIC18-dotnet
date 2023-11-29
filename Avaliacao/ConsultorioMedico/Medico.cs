namespace ConsultorioMedico{
    class Medico{
        private string _nome;
        private string _dataNascimento;
        private string _cpf;
        private string _crm;

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

        public string Crm{
            get{
                return _crm;
            }
            set{
                _crm = value;
            }
        } 
    }
}