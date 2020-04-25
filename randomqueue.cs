/* RandomQueue
 * ----------------------------------------------
 * Datei:     randomqueue.cs
 * Version:   24.04.2014
 * Besitzer:  Mathias Rentsch (rentsch@online.de)
 * Lizenz:    GPL
 *
 * Die Anwendung und die Quelltextdateien sind freie Software und stehen unter der
 * GNU General Public License. Der Originaltext dieser Lizenz kann eingesehen werden
 * unter http://www.gnu.org/licenses/gpl.html.
 * 
 */

using System;
using System.Collections.Generic;

class RandomQueue
{
    private Random random;
    public Queue<int> queue;

    public RandomQueue(int maxValue, int lastIgnoreCount)
    {
        random = new Random(DateTime.Now.Millisecond);
        queue = new Queue<int>();
        if (maxValue < 3) throw new ArgumentOutOfRangeException("maxValue", "Der Konstruktorparameter maxValue ist kleiner 3 (da macht die Klasse keinen Sinn).");
        maxvalue = maxValue;
        if (lastIgnoreCount < 1) throw new ArgumentOutOfRangeException("lastIgnoreCount", "Der Konstruktorparameter lastIgnoreCount ist kleiner 1 (da macht die Klasse keinen Sinn).");
        if (lastIgnoreCount > maxvalue - 2) throw new ArgumentOutOfRangeException("lastIgnoreCount", "Der Konstruktorparameter lastIgnoreCount ist größer als maxValue kleiner 1 (da macht die Klasse keinen Sinn).");
        lastignorecount = lastIgnoreCount;
    }

    private int maxvalue;
    public int MaxValue
    {
        get
        {
            return maxvalue;
        }
    }

    private int lastignorecount;
    public int LastIngnoreCount
    {
        get
        {
            return lastignorecount;
        }
    }

    public int Next()
    {
        int newRandom;
        do
        {
            newRandom = random.Next(maxvalue);
        }
        while (queue.Contains(newRandom));

        queue.Enqueue(newRandom);

        if (queue.Count > lastignorecount) queue.Dequeue();

        return newRandom;
    }
}
