using System;
using System.Collections.Generic;
using DataStructures.Heap;
using DataStructures.Shared;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Prims<T, TW>
        where T : IComparable
        where TW : IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            var edges = new List<MSTEdge<T, TW>>();

            DFS(graph,
                graph.ReferenceVertex,
                new BinaryHeap<MSTEdge<T, TW>>(SortDirection.Ascending),
                new HashSet<T>(),
                edges);

            return edges;
        }

        private void DFS(IGraph<T> graph,
            IGraphVertex<T> currentVertex,
            BinaryHeap<MSTEdge<T, TW>> spNeighbours,
            HashSet<T> spVertices,
            List<MSTEdge<T, TW>> spEdges)
        {
            while (true)
            {
                // kenarlara dikkat
                foreach (var edge in currentVertex.Edges)
                {
                    // Burada kenarları dolaşacak ve bunları minHeap içerisinde organize edecek
                    spNeighbours.Add(new MSTEdge<T, TW>                 
                        (currentVertex.Key,
                        edge.TargetVertexKey,
                        edge.Weight<TW>()));
                }

                // minEdge: MinHeap içerisinde kökte en küçük değer tutulduğu için dolayısıyla o değere ulaştığımızda en küçük değeri almış oluruz.
                var minEdge = spNeighbours.DeleteMinMax();

                // var olan kenarları dikkate alma
                while (spVertices.Contains(minEdge.Source)
                    && spVertices.Contains(minEdge.Destination))
                {
                    // var olan bir şey varsa burada atlayıp diğer en küçük elemana geçiş yaptık.
                    minEdge = spNeighbours.DeleteMinMax();
                    if (spNeighbours.Count == 0)
                        return;
                }

                // vertex takibi
                if (!spVertices.Contains(minEdge.Source))
                {
                    spVertices.Add(minEdge.Source);
                }

                spVertices.Add(minEdge.Destination);
                spEdges.Add(minEdge);

                currentVertex = graph.GetVertex(minEdge.Destination);
            }
        }
    }
}
