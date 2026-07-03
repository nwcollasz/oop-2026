namespace WorkerComposition.Entities
{
    public class Departaments
    {
        public string Name { get; set; } // nome do departamento

        public Departaments()
        {
        }

        public Departaments(string name) // construtor que recebe o nome do departamento
        {
            Name = name;
        }

    }
}