using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph.Search
{
    public class DepthFirst<T>
    {
        public bool Find(IGraph<T> graph, T vertexKey)
        {
            return DFS(graph.ReferenceVertex,
                new HashSet<T>(),
                vertexKey);
        }

        private bool DFS(IGraphVertex<T> current,
            HashSet<T> visited,
            T searchVertexKey)
        {
            visited.Add(current.Key);
            Console.WriteLine(current.Key);
            if (current.Key.Equals(searchVertexKey))
                return true;

            // Eşit değilse bir çevrime gideceğiz.
            foreach (var edge in current.Edges)
            {
                // Her defasında bir sonraki kenar, bir sonraki kenar şeklinde foreach ile ilerlemiş olacak.
                if (visited.Contains(edge.TargetVertexKey))
                    continue;

                if (DFS(edge.TargetVertex, visited, searchVertexKey))
                    return true;
            }
            return false;
        }
    }
}
