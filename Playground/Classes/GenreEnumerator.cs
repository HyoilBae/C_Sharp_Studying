using System;
using System.Collections;
using System.Collections.Generic;

namespace Playground.Classes
{
    public class GenreEnumerator : IEnumerator<Genre>
    {
        private int CurrentIndex;
        private List<Genre> Nodes;

        public GenreEnumerator(Genre root)
        {
            Nodes = root.Preorder();
            Reset();
        }

        public Genre Current
        {
            get
            {
                return GetCurrent();
            }
        }

        private Genre GetCurrent()
        {
            if (CurrentIndex < 0 || CurrentIndex >= Nodes.Count)
                throw new InvalidOperationException();

            return Nodes[CurrentIndex];
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return (CurrentIndex < Nodes.Count);
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }
}