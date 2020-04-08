using AppStartCMD.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppStartCMD.Data
{
    public class InMemoryMateriaData : IMateriaData
    {
        readonly List<Materia> materias;

        public InMemoryMateriaData()
        {
            materias = new List<Materia>()
            {
                new Materia()
                {
                    Id = 1,
                    Titulo = "Caixa lança site e aplicativo para solicitar auxílio emergencial de R$ 600",
                    Resumo = "Terão direito ao benefício, que será pago por até três meses, trabalhadores informais, desempregados, MEIs e contribuintes individuais do INSS, que cumpram requisito de renda média.",
                    Texto = "A Caixa Econômica Federal disponibilizou nesta terça-feira (7) o site e o aplicativo por meio do qual informais, autônomos, desempregados e MEIs podem solicitar o auxílio emergencial de R$ 600. O aplicativo deve ser usado pelos trabalhadores que forem Microempreendedores Individuais (MEIs), trabalhadores informais sem registro e contribuintes individuais do INSS.Aqueles que já recebem o Bolsa Família, ou que estão inscritos no Cadastro Único, não precisam se inscrever pelo aplicativo.O pagamento será feito automaticamente. (Clique aqui para ver como saber se você está no Cadastro Único).",
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    Publicado = true
                },
                new Materia()
                {
                    Id = 2,
                    Titulo = "MP-SP pede quase R$ 40 milhões ao Corinthians por falta de contrapartidas pela Arena",
                    Resumo = "Clube garante que já 'devolveu' cerca de R$ 6 milhões até dezembro do ano passado",
                    Texto = "O Ministério Público de São Paulo atualizou os valores cobrados do Corinthians pela falta de contrapartidas sociais ao município de São Paulo na cessão do terreno onde hoje está a Arena Corinthians. Com juros e correção, a multa de R$ 8 milhões saltou para R$ 39,7 milhões. Os valores estão presentes num requerimento da Promotoria de Justiça da Habitação e Urbanismo da capital, com data de 13 de fevereiro de 2020. O pedido ainda não teve apreciação do juiz Randolfo Ferraz de Campos, responsável pela 14ª Vara da Fazenda Pública.",
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    Publicado = true
                }
            };
        }

        public IEnumerable<Materia> GetAll()
        {
            return from e in materias
                   orderby e.DataCriacao
                   select e;
        }

        public Materia GetById(int id)
        {
            return materias.SingleOrDefault(a => a.Id == id);
        }

        public Materia Insert(Materia insertedObj)
        {
            insertedObj.DataCriacao = DateTime.Now;
            insertedObj.DataAlteracao = DateTime.Now;
            insertedObj.Publicado = true;

            materias.Add(insertedObj);
            insertedObj.Id = materias.Max(a => a.Id) + 1;

            return insertedObj;
        }

        public Materia Update(Materia updatedObj)
        {
            var materia = materias.SingleOrDefault(a => a.Id == updatedObj.Id);
            if(materia != null)
            {
                materia.Titulo = updatedObj.Titulo;
                materia.Resumo = updatedObj.Resumo;
                materia.Texto = updatedObj.Texto;
                materia.DataAlteracao = DateTime.Now;
            }
            return materia;
        }

        public Materia Delete(int id)
        {
            var materia = materias.FirstOrDefault(a => a.Id == id);
            if(materia != null)
            {
                materias.Remove(materia);
            }

            return materia;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Materia> GetMateriaByString(string termo)
        {
            return from e in materias
                   where string.IsNullOrEmpty(termo) || e.Titulo.StartsWith(termo)
                   orderby e.DataCriacao
                   select e;
        }

        public int GetCount()
        {
            return materias.Count();
        }
    }
}
