namespace ConsultorioMedico{
    class Paciente{
        private string _nome;
        private string _dataNascimento;
        private string _cpf;
        private string _sexo;
        private string _sintomas;

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

        public string Sexo{
            get{
                return _sexo;
            }
            set{
                if(value == "M" || value == "F")
                    _sexo = value;
            }
        }

        public string Sintomas{
            get{
                return _sintomas;
            }
            set{
                _sintomas = value;
            }
        }
    }
}