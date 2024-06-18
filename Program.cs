using HW_08_12_06_2024.FootballTeam;
using HW_08_12_06_2024.Oceanarium;

namespace HW_08_12_06_2024
{
//    Завдання 1
//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму. Створіть клас для кожної істоти
//Океанаріуму. Вони мають містити інформацію про кожну
//морську істоту. Реалізуйте підтримку ітератора для класу
//«Океанаріум». Протестуйте можливість використання
//foreach для Океанаріуму.
//Завдання 2
//Створіть клас «Футбольна Команда». Клас має містити
//інформацію про гравців футбольної команди. Реалізуйте
//підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу
//«Футбольна Команда».
//Завдання 3
//Створіть клас «Кафе» з інформацією про працівників кафе. Реалізуйте підтримку ітератора для класу
//«Кафе». Протестуйте можливість використання foreach
//для «Кафе».
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первая задача
            Oceanarium.Shark shark = new Shark("White shark", "", 1.5);
            Oceanarium.GoldFish fish = new GoldFish("Gold fish", "", 0.1);
            Oceanarium.Oceanarium oceanarium = new Oceanarium.Oceanarium("Nemo");
            oceanarium.AddCreature(shark);
            oceanarium.AddCreature(fish);
            foreach (Creature creature in oceanarium)
            {
                creature.Description = creature.Name;
            }
            Console.WriteLine(oceanarium);

            // Вторая задача
            try
            {
                Team team = new Team ("Черноморец");
                Player player = new Player();
                Player player2 = new Player("Alex",25);
                team.AddPlayer(player);
                team.AddPlayer(player2);
                Console.WriteLine(team);
                team -= player;
                Player player3 = new Player("Bob", 27);
                Player player4 = new Player("John", 24);
                team.AddPlayer(player3);
                team.AddPlayer(player4);
                Console.WriteLine(team);
                team -= "Bob";
                Console.WriteLine(team);
                //Console.WriteLine(team[2]); // тут будет ошибка индекса
                foreach (Player pl in team)
                {
                    Console.WriteLine(pl.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }
    }
}
