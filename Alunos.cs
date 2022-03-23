using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplopoo
{
    public class Alunos : pessoa
    {
        private string ra;
        private string curso;

        public Alunos()
        {
            this.nome = "";
            this.ra = "";
            this.curso = "";
        }

        public Alunos(string ra, string curso)
        {
            this.nome = ra;
            this.curso = curso;

        }
        //getter setters
        public string RA
        {
            get { return this.ra; }
            set { this.ra = value; }

            public string Curso
            {
            get { return this.curso}
            set { this.curso = value; }
            }
        }
    }
}
