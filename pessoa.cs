using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplopoo
{
    internal class pessoa
    {
        // nome, Rg, cpf, email
        public string nome;
        public string rg;
        public string cpf;
        public string email;

        public pessoa()

        {
            this.nome = "";
            this.rg = "";
            this. cpf = "";
            this. email = "";


        }
        // construtor com parametros
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nome">mome da pessoa</param>
        /// <param name="_rg">numero rg</param>
        /// <param name="_cpf">numero cpf</param>
        /// <param name="_email">endereço email</param>
        public Pessoa(string _nome, string _rg, string _cpf, string _email)

        {
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.email = _email;

            
        }

        // metodo para recuperar ddos

        public Pessoa getPessoa()

        //instanciamos a classe pessoa usando o construtor vazio
        {
            pessoa Pessoa = new pessoa();
            //alimentamos o atributo
            Pessoa.nome = this.nome;
            Pessoa.rg = this.rg;
            Pessoa.cpf = this.cpf;
            return pessoa;

            public string NOME
            {
                get { return this.nome; }
                set { this.nome = value; }
             }
             public string EMAIL
        {
                 get { return this.email; }
                 set { this.email = value; }
        }
    }






            








    }
}
