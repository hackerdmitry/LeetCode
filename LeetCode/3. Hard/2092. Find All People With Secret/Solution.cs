using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2092._Find_All_People_With_Secret;

public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        var persons = Enumerable.Range(0, n).Select(i => new Person(i)).ToArray();
        persons[0].SecretTime = 0;
        persons[firstPerson].SecretTime = 0;

        foreach (var meeting in meetings)
            if (meeting[0] > meeting[1])
                (meeting[0], meeting[1]) = (meeting[1], meeting[0]);

        foreach (var meeting in meetings.OrderBy(x => x[2]).ThenBy(x => x[0]).ThenBy(x => x[1]))
        {
            persons[meeting[0]].AddNeighbour(persons[meeting[1]], meeting[2]);
            persons[meeting[1]].AddNeighbour(persons[meeting[0]], meeting[2]);
        }

        var queue = new PriorityQueue<Person, int>();
        queue.Enqueue(persons[0], 0);
        queue.Enqueue(persons[firstPerson], 0);

        while (queue.Count > 0)
        {
            var person = queue.Dequeue();
            foreach (var neighbour in person.GetPersonsWhomSecretRevealed())
                queue.Enqueue(neighbour, neighbour.SecretTime);
        }

        return persons.Where(x => x.SecretTime != -1).Select(x => x.Index).ToArray();
    }

    private class Person
    {
        public int Index { get; set; }
        public int SecretTime { get; set; } = -1;
        public LinkedList<(Person Person, int Time)> Neighbours { get; set; }

        public Person(int index)
        {
            Index = index;
        }

        public void AddNeighbour(Person person, int time)
        {
            if (Neighbours == null)
                Neighbours = new();
            Neighbours.AddLast((person, time));
        }

        public IEnumerable<Person> GetPersonsWhomSecretRevealed()
        {
            if (Neighbours == null)
                yield break;

            foreach (var (neighbour, secretTime) in Neighbours
                         .Where(x => x.Time >= SecretTime)
                         .Where(x => x.Person.SecretTime == -1))
            {
                neighbour.SecretTime = secretTime;
                yield return neighbour;
            }
        }
    }
}
