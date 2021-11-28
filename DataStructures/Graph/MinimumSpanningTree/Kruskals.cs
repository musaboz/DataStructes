using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Heap;
using DataStructures.Set;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Kruskals<T, TW>
        where T : IComparable
        where TW : IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        // En az maliyete sahip kapsama ağacını bulacağız.
        {
            // 1. Kenar listesi oluştur (DFS)
            var edges = new List<MSTEdge<T, TW>>();
            DFS(graph.ReferenceVertex,
                new HashSet<T>(),
                new Dictionary<T, HashSet<T>>(),
                edges);

            // 2. Kenar sıralama (Küçükten büyüğe doğru)
            var heap = new BinaryHeap<MSTEdge<T, TW>>(Shared.SortDirection.Ascending);
            foreach (var edge in edges)
                heap.Add(edge);

            // HeapSort
            var sortedEdgeArray = new MSTEdge<T, TW>[edges.Count];

            for (int i = 0; i < edges.Count; i++)
                sortedEdgeArray[i] = heap.DeleteMinMax();

            // 3. MakeSet (Vertex'ler bir set oluşturacak)
            var disjointSet = new DisjointSet<T>();
            foreach (var vertex in graph.VerticesAsEnumerable)
            {
                disjointSet.MakeSet(vertex.Key);
            }

            // 4. FindSet - UNION (İlgili setleri u ve v şeklinde birleştireceğiz.)
            // Burada source ve destionation eğer farklı ayrık set içerisinde bulunursa birleştirme yapacağız, eğer aynıysa birleştirme yapmayacağız.

            var resultEdgeList = new List<MSTEdge<T, TW>>();
            for (int i = 0; i < edges.Count; i++)
            {
                var currentEdge = sortedEdgeArray[i];
                var setA = disjointSet.FindSet(currentEdge.Source);
                var setB = disjointSet.FindSet(currentEdge.Destination);

                if (setA.Equals(setB))
                    continue;

                resultEdgeList.Add(currentEdge);
                disjointSet.Union(setA, setB);
            }
            return resultEdgeList;
        }

        private void DFS(IGraphVertex<T> currentVertex, HashSet<T> visitedVertices,
            Dictionary<T, HashSet<T>> visitedEdges, List<MSTEdge<T, TW>> edges)
        {
            if (!visitedVertices.Contains(currentVertex.Key))
            {
                visitedVertices.Add(currentVertex.Key);
                foreach (var edge in currentVertex.Edges)
                {
                    if (!visitedEdges.ContainsKey(currentVertex.Key) || !visitedEdges[currentVertex.Key].Contains(edge.TargetVertexKey))
                    {
                        // kenar ekleme
                        edges.Add(new MSTEdge<T, TW>(currentVertex.Key, edge.TargetVertexKey, edge.Weight<TW>()));

                        // kenar güncelleme (visitedEdges) - source
                        if (!visitedEdges.ContainsKey(currentVertex.Key))
                        {
                            visitedEdges.Add(currentVertex.Key, new HashSet<T>());
                        }

                        visitedEdges[currentVertex.Key].Add(edge.TargetVertexKey);

                        // kenar güncelleme (visitedEdges) - destination
                        if (!visitedEdges.ContainsKey(edge.TargetVertexKey))
                        {
                            visitedEdges.Add(edge.TargetVertexKey, new HashSet<T>());
                        }

                        visitedEdges[edge.TargetVertexKey].Add(currentVertex.Key);

                        // Buraya kadar A'dan B'ye (A-B), B'den A'ya ilişkileri kurduk ve şimdi de recursive olarak çağıracağız.

                        DFS(edge.TargetVertex, visitedVertices, visitedEdges, edges);
                    }
                }
            }
        }
    }
}
