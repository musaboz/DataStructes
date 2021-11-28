using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Channels;
using DataStructures.Array;
using DataStructures.LinkedList.DoublyLinkedList;

namespace Apps
{
    class Apps
    {

    }

    /*
    private static void StackApps01()
    {
        var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
        var stack1 = new Stack<char>();
        var stack2 = new Stack<char>(StackType.LinkedList);

        foreach (var c in charset)
        {
            Console.WriteLine(c);
            stack1.Push(c);
            stack2.Push(c);
        }

        Console.WriteLine("\nPeek");
        Console.WriteLine($"Stack1: {stack1.Peek()}");
        Console.WriteLine($"Stack2: {stack2.Peek()}");

        Console.WriteLine("\nCount");
        Console.WriteLine($"Stack1: {stack1.Count}");
        Console.WriteLine($"Stack2: {stack2.Count}");

        Console.WriteLine("\nPop");
        Console.WriteLine($"Stack1: {stack1.Pop()} has been removed");
        Console.WriteLine($"Stack2: {stack2.Pop()} has been removed");
    }
    */

    /*
private static void DoublyLinkedListApp04()   
{
    var list = new DoublyLinkedList<int>();
    list.AddFirst(12);
    list.AddFirst(23);
    // 23 12

    list.AddLast(44);
    list.AddLast(55);
    // 23 12 44 55

    list.AddBefore(list.Head, new DoublyLinkedListNode<int>(13));
    // 13 23 12 44 55

    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}
*/

    /*
    private static void DoublyLinkedListApp03()
    {
        var list = new DoublyLinkedList<int>(new int[]
            {23, 44, 55, 61});
        list.Remove(55);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    */

    /*
    private static void DoublyLinkedListApp02()
    {
        var list = new
            DoublyLinkedList<char>(new List<char>()
                {'a', 'b', 'c'});

        Console.WriteLine($"{list.RemoveFirst()} has been removed from the list.");
        Console.WriteLine($"{list.RemoveLast()} has been removed from the list.");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    */

    /*
    private static void DoublyLinkedListApp01()
    {
        var list = new DoublyLinkedList<int>();
        list.AddFirst(12);
        list.AddFirst(23);
        // 23 12

        list.AddLast(44);
        list.AddLast(55);
        // 23 12 44 55

        list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(13));
        // 23 12 13 44 55

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    */

    /*
    private static void PostFixExampleApp01()
    {
    Console.WriteLine(PostFixExample.Run("231*+9-"));
    }
    */

    /*
        private static void QueueApps01()
        {
            var numbers = new int[] {10, 20, 30};
            var q1 = new Queue<int>();
            var q2 = new Queue<int>(QueueType.LinkedList);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                q1.EnQueue(number);
                q2.EnQueue(number);
            }

            Console.WriteLine($"q1 Count: {q1.Count}");
            Console.WriteLine($"q2 Count: {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1.");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q2.");

            Console.WriteLine($"q1 Peek: {q1.Peek()}");
            Console.WriteLine($"q2 Peek: {q2.Peek()}");
        }
        */

    /*
        private static void RecursiveBinarySearchTreeApp()
        {
            var BST = new BST<int>
                (new int[] {23, 16, 45, 3, 22, 37, 99});

            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine();
            bt.ClearList();

            bt.PreOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine();
            bt.ClearList();

            bt.PostOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));
        }
        */

    /*
        private static void IterativeSearchTreeTraversalApp01()
        {
            var BST = new BST<int>
                (new List<int>() {23, 16, 45, 3, 22, 37, 99});

            var bt = new BinaryTree<int>();

            bt.PreOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine();

            bt.PreOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine("\nLevel-Order Traversal\n");

            bt.LevelOrderNonRecursiveTraversal(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));
        }
        */

    /*
        private static void BST_Find_Apps01()
        {
            BST<int> BST = new BST<int>
                {23, 16, 45, 3, 22, 37, 99};
            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine();

            Console.WriteLine($"Minimum value: {BST.FindMin(BST.Root)}");
            Console.WriteLine($"Maximum value: {BST.FindMax(BST.Root.Left)}");

            var keyNode = BST.Find(BST.Root, 16);

            try
            {
                Console.WriteLine($"{keyNode.Value}" +
                                  $"- Left: {keyNode.Left.Value}" +
                                  $"- Right:{keyNode.Right.Value}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"{e.Message} Değer Boş!");
            }
        }
        */

    /*
        private static void BST_Remove()
        {
            var BST = new BST<int>(new List<int>()
                {60, 40, 70, 20, 45, 65, 85});

            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine();

            BST.Remove(BST.Root, 20);
            BST.Remove(BST.Root, 40);
            BST.Remove(BST.Root, 60);

            bt.ClearList();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3}"));
        }
        */

    /*
        private static void BST_MaxDepth()
        {
            var bst = new BST<byte>(new byte[] {60, 40, 70, 20, 45, 65, 85, 90});

            new BinaryTree<byte>().InOrder(bst.Root)
                .ForEach(node => Console.Write($"{node,-3}"));

            Console.WriteLine($"\nMin: {bst.FindMin(bst.Root)}");
            Console.WriteLine($"Max: {bst.FindMax(bst.Root)}");
            Console.WriteLine($"Depth: {BinaryTree<byte>.MaxDepth(bst.Root)}");
        }
        */

    /*
        private static void BinaryTreeDeepestNode()
        {
            var bt = new BinaryTree<char>();

            bt.Root = new Node<char>('F');
            bt.Root.Left = new Node<char>('A');
            bt.Root.Right = new Node<char>('T');
            bt.Root.Left.Left = new Node<char>('D');

            bt.LevelOrderNonRecursiveTraversal(bt.Root)
                .ForEach(node => Console.WriteLine(node));

            Console.WriteLine($"Deepest Node: {bt.DeepestNode(bt.Root)}");
            Console.WriteLine($"Deepest Node: {bt.DeepestNode()}");
            Console.WriteLine($"Max. Depth  : {BinaryTree<char>.MaxDepth(bt.Root)}");
        }
        */

    /*
        private static void BSTNumberOfNodes()
        {
            var bst = new BST<int>(new int[] {23, 16, 45, 3, 22, 37, 99});

            bst.Remove(bst.Root, 3);
            bst.Remove(bst.Root, 99);

            Console.WriteLine($"Number of leafs         : {BinaryTree<int>.NumberOfLeafs(bst.Root)}");

            Console.WriteLine($"Number of full nodes    : {BinaryTree<int>.NumberOfFullNodes(bst.Root)}");

            Console.WriteLine($"Number of half nodes    : {BinaryTree<int>.NumberOfHalfNodes(bst.Root)}");
        }
        */

    /*
        private static void BSTFindPaths()
        {
            var bst = new BST<int>(new int[] {23, 16, 45, 3, 22, 37, 99, 100, 120, 130});

            bst.Remove(bst.Root, 22);

            new BinaryTree<int>().PrintPaths(bst.Root);
        }
        */

    /*
    private static void MaxHeapApp01()
    {
    var heap = new MaxHeap<int>(new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });

    heap.DeleteMinMax();

    foreach (var item in heap)
    {
        Console.Write($"{item,-3}");
    }
    }
    */

    /*
    private static void MinHeapApp01()
    {
    var heap = new MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3, 2 });

    Console.WriteLine($"{heap.DeleteMinMax()} has been removed.");

    foreach (var item in heap)
    {
        Console.WriteLine(item);
    }
    }
    */

    /*
        private static void BinaryHeapApp01()
        {
            var heap = new BinaryHeap<int>(SortDirection.Ascending, new int[] {54, 45, 36, 27, 29, 18, 21, 99});

            // Ascending ise MinHeap, Descending ise MaxHeap yapısı oluşur.

            foreach (var item in heap)
            {
                Console.Write($"{item,-3}");
            }
        }
        */

    /*
    private static void DisjointSetApp()
    {
        var disjointSet = new DisjointSet<int>
                        (new int[] { 0, 1, 2, 3, 4, 5, 6 });

        disjointSet.Union(5, 6);
        disjointSet.Union(1, 2);
        disjointSet.Union(0, 2);

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
        }
    }
    */

    /*
        private static void GraphApp01()
        {
            var graph = new Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'D');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('D', 'E');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'G');

            Console.WriteLine("Is there an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes!" : "No!");

            Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes!" : "No!");

            Console.WriteLine("Is there an edge between B and D? {0}", graph.HasEdge('B', 'D') ? "Yes!" : "No!");

            Console.WriteLine("Is there an edge between D and B? {0}", graph.HasEdge('D', 'B') ? "Yes!" : "No!");

            foreach (var key in graph)
            {
                Console.WriteLine(key);
                foreach (var vertex in graph.GetVertex(key).Edges)
                {
                    Console.WriteLine($"   {vertex}");
                }

            }

            Console.WriteLine($"Number of vertex in the graph: {graph.Count}");
        }
        */

    /*
        private static void WeightedGraphApp01()
        {
            var graph = new WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });

            graph.AddEdge('A', 'B', 1.2);
            graph.AddEdge('A', 'D', 2.3);
            graph.AddEdge('D', 'C', 5.5);

            Console.WriteLine("Is there an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes." : "No.");

            Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes." : "No.");

            foreach (char vertex in graph)
            {
                Console.WriteLine(vertex);
                foreach (char key in graph.GetVertex(vertex))
                {
                    var node = graph.GetVertex(key);
                    Console.WriteLine($"   {vertex} - " +
                        $"{node.GetEdge(graph.GetVertex(vertex)).Weight<double>()} - " +
                        $"{key}");
                }
            }

            Console.WriteLine($"Number of vertex in graph: {graph.Count}");
        }
        */

    /*
        private static void DiGraphApp01()
        {
            var graph = new DiGraph<char>
                            (new char[] { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('B', 'A');
            graph.AddEdge('A', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('C', 'A');
            graph.AddEdge('C', 'B');

            Console.WriteLine("Is there an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes!" : "No!");

            Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes!" : "No!");

            graph.RemoveVertex('C');

            foreach (var key in graph)
            {
                Console.WriteLine(key);
                foreach (var item in graph.GetVertex(key))
                {
                    Console.WriteLine($"   {item}");
                }
            }

            Console.WriteLine($"Number of vertex in graph: {graph.Count}");
        }
        */

    /*
        private static void WeightedDiGraphApp01()
        {
            var graph = new WeightedDiGraph<char, int>
                            (new char[] { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('A', 'C', 12);
            graph.AddEdge('A', 'D', 60);
            graph.AddEdge('B', 'A', 10);
            graph.AddEdge('C', 'D', 32);
            graph.AddEdge('C', 'B', 20);
            graph.AddEdge('E', 'A', 7);

            Console.WriteLine($"Number of vertex in this graph is: {graph.Count}");

            Console.WriteLine("Is an edge between A and B? {0}", graph.HasEdge('A', 'B') ? "Yes!" : "No!");

            Console.WriteLine("Is an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes!" : "No!");

            foreach (var vertexKey in graph)
            {
                Console.WriteLine(vertexKey);
                foreach (char key in graph.GetVertex(vertexKey))
                {
                    var nodeU = graph.GetVertex(vertexKey);
                    var nodeV = graph.GetVertex(key);
                    var w = nodeU.GetEdge(nodeV).Weight<int>();

                    Console.WriteLine($"   {vertexKey} - " +
                        $"({w}) - " +
                        $"{key}");
                }
            }

        }
        */

    /*
        private static void DFSAlgorithm()
        {
            var graph = new Graph<int>();

            for (int i = 0; i <= 11; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algorithm = new DepthFirst<int>();

            Console.WriteLine("{0}", algorithm.Find(graph, 9) ? "Yes!" : "No!");
        }
        */

    /*
        private static void BFSAlgorithmApp()
        {
            var graph = new Graph<int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algorithm = new BreadthFirst<int>();

            Console.WriteLine(algorithm.Find(graph, 23) ? "Yes!" : "No!");
        }
        */

    /*
        private static void PrimsAlgorithmApp01()
        {
            var graph = new WeightedGraph<int, int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new Prims<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        */

    /*
        private static void KruskalAlgorithmApp01()
        {
            // Graf oluştur
            var graph = new WeightedGraph<int, int>();

            // Vertex oluştur
            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            // Kenarları ekle
            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new Kruskals<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        */

    /*
        private static void SelectionSortApp()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            SelectionSort.Sort<int>(arr, SortDirection.Descending);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            SelectionSort.Sort<int>(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        */

    /*
        private static void BubbleSortApp()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            BubbleSort.Sort<int>(arr);

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            BubbleSort.Sort<int>(arr, SortDirection.Descending);

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        */

    /*
        private static void InsertionSortApp()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            InsertionSort.Sort<int>(arr, SortDirection.Descending);

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            InsertionSort.Sort<int>(arr);

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        */

    /*
        private static void QuickSortApp()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            QuickSort.Sort<int>(arr);

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        */

    /*
        private static void MergeSortApp()
        {
            var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            MergeSort.Sort<sbyte>(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        */

    /*
        private static void HeapSortApp()
        {
            var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            var heap = new MinHeap<sbyte>(arr);
            foreach (var item in heap)
            {
                Console.Write($"{heap.DeleteMinMax(),-5}");
            }
        }
        */

    /*
        private static void CustomTypesExamples()
        {
            var arr = new Student[]
                        {
                new Student(15, "Mehmet", 2.45),
                new Student(10, "Ahmet", 3.40),
                new Student(85, "Filiz", 1.30),
                new Student(65, "Can", 2.65),
                new Student(75, "Mete", 2.40),
                new Student(90, "Ömer", 3.10),
                new Student(12, "Fatma", 1.45),
                new Student(14, "Merve", 3.80),
                new Student(18, "Semih", 2.80)
                        };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            var newArr = new Array<Student>(arr);
            newArr.Add(new Student(22, "Aslı", 3.90));

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSinglyLinked<Student>\n");

            var linkedList = new SinglyLinkedList<Student>(newArr);

            linkedList.AddFirst(new Student(99, "Yigit", 4.00));

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBST<Student>\n");

            var bst = new BST<Student>(linkedList);

            foreach (var item in bst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMinHeap<Student>\n");

            var heap = new MinHeap<Student>(bst);

            foreach (var item in heap)
            {
                Console.WriteLine(heap.DeleteMinMax());
            }

            Console.WriteLine("\nMaxHeap<Student>\n");

            var maxHeap = new BinaryHeap<Student>(SortDirection.Descending, bst);

            foreach (var item in maxHeap)
            {
                Console.WriteLine(maxHeap.DeleteMinMax());
            }

            // Sıralama Algoritmaları
            Console.WriteLine("\nBubbleSort.Sort<Student>(arr)\n");

            BubbleSort.Sort<Student>(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nInsertionSort.Sort<Student>(arr)\n");

            InsertionSort.Sort<Student>(arr, SortDirection.Descending);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        */
}