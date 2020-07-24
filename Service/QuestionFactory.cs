using System;
using System.Collections.Generic;

namespace Service
{
    public class QuestionFactory<T>
    {
        private QuestionFactory() { }

        static readonly Dictionary<int, Func<T>> _dict
         = new Dictionary<int, Func<T>>();

        public static T Create(int id)
        {
            Func<T> constructor = null;
            if (_dict.TryGetValue(id, out constructor))
                return constructor();

            throw new ArgumentException("Erro, class not registered");
        }

        public static void Register(int id, Func<T> ctor)
        {
            if(!_dict.ContainsKey(id))
                _dict.Add(id, ctor);
        }
    }
}
