using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker("pt_PT");

            var table = new Table();

            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name"));
            table.AddColumn(new TableColumn("Job"));

            for (int i = 0; i < int.Parse(args[0]);i++)
                {
                    table.AddRow($"{i}", $"{faker.Parse("{{name.firstName}} {{name.lastName}}")}",$"{faker.Parse("{{name.jobTitle}}")}");
                }
            AnsiConsole.Write(table);
        }
    }
}
