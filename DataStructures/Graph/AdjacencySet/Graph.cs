using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graph.AdjacencySet
{
    public class Graph<T> : IGraph<T>
    {
        private Dictionary<T, GraphVertex<T>> vertices;

        public bool isWeightedGraph => false;

        public int Count => vertices.Count;

        // ReferenceVertex, kök düğüm gibidir.
        public IGraphVertex<T> ReferenceVertex =>
            vertices[this.First()];

        // Her defasında bir düğüm almış oluruz.
        public IEnumerable<IGraphVertex<T>> VerticesAsEnumerable => vertices.Select(x => x.Value);

        public Graph()
        {
            vertices = new Dictionary<T, GraphVertex<T>>();
        }

        public Graph(IEnumerable<T> collection)
        {
            vertices = new Dictionary<T, GraphVertex<T>>();
            foreach (var item in collection)
            {
                AddVertex(item);
            }
        }

        public void AddVertex(T key)
        {
            // Buradaki T bir değer olduğu için bunu düğüm haline yani GraphVertex haline dönüştürmemiz gerekir.
            if (key == null)
                throw new ArgumentNullException();

            var newVertex = new GraphVertex<T>(key);
            vertices.Add(key, newVertex);
        }

        IGraph<T> IGraph<T>.Clone()
        {
            return Clone();
        }

        public Graph<T> Clone()
        {
            var graph = new Graph<T>();

            foreach (var vertex in vertices)
                graph.AddVertex(vertex.Key);

            foreach (var vertex in vertices)
            {
                // Burada GetEnumerate metodu çalıştığı için her defasında bize bir düğüm veriyor ve biz bu vertex üzerinden hareket edeceğiz.
                foreach (var edge in vertex.Value.Edges)
                {
                    graph.AddEdge(vertex.Value.Key, edge.Key);
                }
            }

            return graph;
        }

        public bool ContainsVertex(T key)
        {
            return vertices.ContainsKey(key);
        }

        public IEnumerable<T> Edges(T key)
        {
            // IEnumerable içerisindeki GetEnumerator'dan dolayı her defasında 1 örnek olacak şekilde bu ifadenin dönüş yapmasını sağlamalıyız.
            if (key == null)
                throw new ArgumentNullException();

            return vertices[key].Edges.Select(e => e.Key);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return vertices.Select(x => x.Key).GetEnumerator();
        }

        public IGraphVertex<T> GetVertex(T key)
        {
            // Burada her defasında bir anahtar değere bağlı olarak düğüm ifadesi döneceğiz.
            return vertices[key];
        }

        public bool HasEdge(T source, T dest)
        {
            // Burada iki türlü de yol olduğunu unutmayalım. Yani bu yönlü bir graf değildir.
            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new ArgumentException("Source or destination vertex is not in this graph!");

            return vertices[source].Edges.Contains(vertices[dest]) && vertices[dest].Edges.Contains(vertices[source]);
        }

        public void AddEdge(T source, T dest)
        {
            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new ArgumentException("Source or destination vertex is not in this graph!");

            if (vertices[source].Edges.Contains(vertices[dest]) || vertices[dest].Edges.Contains(vertices[source]))
                throw new Exception("The edge has been already defined!");

            vertices[source].Edges.Add(vertices[dest]);
            vertices[dest].Edges.Add(vertices[source]);
        }

        public void RemoveEdge(T source, T dest)
        {
            if (source == null || dest == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(source) || !vertices.ContainsKey(dest))
                throw new Exception("Source or destination vertex is not in this graph!");

            if (!vertices[source].Edges.Contains(vertices[dest]) || !vertices[dest].Edges.Contains(vertices[source]))
                throw new Exception("The edge does not exist!");

            vertices[source].Edges.Remove(vertices[dest]);
            vertices[dest].Edges.Remove(vertices[source]);
        }

        public void RemoveVertex(T key)
        {
            // Önce ilgili düğümün diğer düğümlerle olan ilişkisini kaldır.
            if (key == null)
                throw new ArgumentNullException();

            if (!vertices.ContainsKey(key))
                throw new ArgumentException("The vertex is not in this graph");

            foreach (var vertex in vertices[key].Edges)
                vertex.Edges.Remove(vertices[key]);
            
            // Daha sonra kendisini sil
            vertices.Remove(key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class GraphVertex<T> : IGraphVertex<T>
        {
            public T Key { get; set; }

            public HashSet<GraphVertex<T>> Edges { get; private set; }

            public GraphVertex(T key)
            {
                Key = key;
                Edges = new HashSet<GraphVertex<T>>();
            }

            IEnumerable<IEdge<T>> IGraphVertex<T>.Edges =>
                Edges.Select(x => new Edge<T, int>(x, 1));

            public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
            {
                return new Edge<T, int>(targetVertex, 1);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return Edges.Select(x => x.Key).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public override string ToString()
            {
                return $"{Key}";
            }
        }
    }
}
