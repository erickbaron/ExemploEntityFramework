using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext context = new SistemaContext();

            #region inserir
            //Animal animal = new Animal();
            //animal.Nome = "TRex";
            //animal.Extinto = false;

            //context.Animais.Add(animal);
            //context.SaveChanges();
            //Console.WriteLine("Registro salvo com sucesso");
            #endregion inserir

            #region apagar
            //Animal animalApagar = context.Animais.Where(x => x.Nome == "Porco Aranha").First();
            //context.Animais.Remove(animalApagar);
            //context.SaveChanges();
            #endregion apagar

            #region editar
            //var cobra = context.Animais.First(x => x.Id == 2);
            //cobra.Nome = "Cabra";
            //context.SaveChanges();
            #endregion editar

            #region mostrar
            //List<Animal> animais = context.Animais.Where(x => x.Extinto == false && x.Nome.Contains("a")).OrderBy(x => x.Nome).ToList();
            //foreach (Animal animal in animais)
            //{
            //    Console.WriteLine($"{animal.Id} - {animal.Nome} - {animal.Extinto}");
            //}
            #endregion mostrar



            #region InserirRelacionado
            Habilidade habilidade = new Habilidade();
            habilidade.IdAnimal = 1;
            habilidade.Nome = "Invisibilidade";

            context.Habilidades.Add(habilidade);
            context.SaveChanges();
            #endregion InserirRelacionado

            #region MostrarRelacionado
            var habilidades = context.Habilidades.Include("Animal").ToList();

            foreach(Habilidade habilidadeAux in habilidades)
            {
                Console.WriteLine(habilidadeAux.Animal.Nome + " - "+
                    habilidadeAux.Nome);
            }
            #endregion MostrarRelacionado
        }
    }
}
