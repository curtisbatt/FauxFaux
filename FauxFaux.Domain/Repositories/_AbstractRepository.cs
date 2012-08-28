using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain.Repositories
{
    public abstract class AbstractRepository<T> : IEnumerable<T>, IQueryable<T>
    {
        protected List<T> _items;

        public AbstractRepository(bool isMock = false)
        {
            if (!isMock)
            {
                _items = new List<T>();
            }
            else
            {
                InitializeMockData();
            }
        }

        protected abstract void InitializeMockData();

        public int IndexOf(T item)
        {
            return _items.IndexOf(item);
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        private void CopyTo(T[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        #endregion

        #region IQueryable
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public Type ElementType
        {
            get { return _items.AsQueryable().ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return _items.AsQueryable().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return _items.AsQueryable().Provider; }
        }
        #endregion
    }
}
