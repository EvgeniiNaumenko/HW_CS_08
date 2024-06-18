using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//    Завдання 1
//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму. Створіть клас для кожної істоти
//Океанаріуму. Вони мають містити інформацію про кожну
//морську істоту. Реалізуйте підтримку ітератора для класу
//«Океанаріум». Протестуйте можливість використання
//foreach для Океанаріуму.
namespace HW_08_12_06_2024.Oceanarium
{
    internal class Oceanarium:IEnumerable
    {
        public string Name {  get; set; }
        public string Adress {  get; set; }
        public List<Creature> _creatures;
        public Oceanarium(string name)
        {
            Name = name;
            Adress = "NoAdress";
            _creatures = new List<Creature>();
        }
        public Creature this[int index]
        {
            get
            {
                if (index >= 0 && index < _creatures.Count)
                {
                    return _creatures[index];
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 0 && index < _creatures.Count)
                {
                    _creatures[index] = value;
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
        }
        public void AddCreature (Creature creature)
        {
            if (creature!=null)
            {
                 _creatures.Add(creature);
            }
        }
        
        public override string ToString()
        {
            foreach (Creature creature in _creatures)
            {
                Console.WriteLine(creature);
            }
            return "";
        }
        public IEnumerator<Creature> GetEnumerator()
        {
            foreach (var creature in _creatures)
            {
                yield return creature;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
