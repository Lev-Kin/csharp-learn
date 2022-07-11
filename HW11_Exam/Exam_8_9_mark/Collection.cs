using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LevanovExamCSharp
{
    [Serializable]

    public class Collection<T> : IEnumerable<T>
    {
        public List<T> list = new List<T>();
        public void Add(T obj) => list.Add(obj);
        public void Sort(IComparer<T> c) => list.Sort(c);
        public List<T> Find(Predicate<T> predicate) => list.Where(predicate as Func<T, bool>).ToList();
        public void Serialization(string fileName, BinaryFormatter formatter)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        public void Serialization(string fileName, XmlSerializer formatter)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)list).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)list).GetEnumerator();
    }
}

