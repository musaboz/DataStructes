using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public interface IGraph<T> : IEnumerable<T>
    {
        bool isWeightedGraph { get; }
        int Count { get; }
        IGraphVertex<T> ReferenceVertex { get; }
        IEnumerable<IGraphVertex<T>> VerticesAsEnumerable { get; }
        IEnumerable<T> Edges(T key);
        IGraph<T> Clone();
        bool ContainsVertex(T key);
        IGraphVertex<T> GetVertex(T key);
        bool HasEdge(T source, T dest);
        void AddVertex(T key);
        // Burada ağırlıklı ifadelerle ilgili bir fark olacağından dolayı "AddEdge" işlemini Interface'e dahil etmeyip manuel olarak gireceğiz.
        void RemoveVertex(T key);
        void RemoveEdge(T source, T dest);
    }

    public interface IDiGraph<T> : IGraph<T>
    {
        new IDiGraphVertex<T> ReferenceVertex { get; }
        new IEnumerable<IDiGraphVertex<T>> VerticesAsEnumerable { get; }
        new IDiGraphVertex<T> GetVertex(T key);
    }

    public interface IGraphVertex<T> : IEnumerable<T>
    {
        // Düğümü temsil eder.
        T Key { get; }
        IEnumerable<IEdge<T>> Edges { get; }
        IEdge<T> GetEdge(IGraphVertex<T> targetVertex);
    }

    public interface IDiGraphVertex<T> : IGraphVertex<T>
    {
        // Arasındaki ilişkileri göz önüne alırken sadece çıkan okları (outdegree) değerlendireceğiz.
        IDiEdge<T> GetOutEdge(IDiGraphVertex<T> targetVertex);
        IEnumerable<IDiEdge<T>> OutEdges { get; }
        IEnumerable<IDiEdge<T>> InEdges { get; }
        int OutEdgeCount { get; }
        int InEdgeCount { get; }
    }

    public interface IEdge<T>
    {
        T TargetVertexKey { get; }
        IGraphVertex<T> TargetVertex { get; }
        W Weight<W>() where W : IComparable;
    }

    public interface IDiEdge<T> : IEdge<T>
    {
        // Burada, IEdge interface'inden tek farkı TargetVertex field'ının dönüş class'ı olduğu için onu new'leyerek değiştirdik.
        new IDiGraphVertex<T> TargetVertex { get; }
    }


}
