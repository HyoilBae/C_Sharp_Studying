using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class Genre : IEnumerable<Genre>
    {
        public int Depth = 0;
        public string Name { get; set; }
        public List<Genre> Children = new List<Genre>();

        public Genre(string name)
        {
            Name = name;
        }

        public Genre AddChild(string name)
        {
            Genre child = new Genre(name);
            child.Depth = Depth + 1;
            Children.Add(child);
            return child;
        }

        public List<Genre> Preorder()
        {
            List<Genre> nodes = new List<Genre>();

            TraversePreorder(nodes);

            return nodes;
        }

        private void TraversePreorder(List<Genre> nodes)
        {
            nodes.Add(this);

            foreach (Genre child in Children)
            {
                child.TraversePreorder(nodes);
            }
        }

        public IEnumerator<Genre> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetEnumerable()
        {
            List<Genre> traverse = Preorder();

            foreach (Genre item in traverse)
            {
                yield return item;
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new GenreEnumerator(this);
        }
    }
}
