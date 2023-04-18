using System;

namespace Binary_Tree
    /* Класс Node представляет узел в дереве и содержит свойства для хранения данных, ссылок на левый и правый узлы,
     * а также конструктор для определения свойств.*/
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    // Класс Tree представляет само дерево и содержит поле root для хранения корневого узла. 
    public class Tree<T> where T : IComparable<T>
    {
        private Node<T> root;
        // Метод Add добавляет новый узел в дерево, используя алгоритм двоичного поиска.
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;

                while (true)
                {
                    if (data.CompareTo(current.Data) < 0)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            break;
                        }
                        current = current.Left;
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        }
                        current = current.Right;
                    }
                }
            }
        }
        // Метод Search находит узел с заданным значением, также используя алгоритм двоичного поиска.
        public Node<T> Search(T data)
        {
            Node<T> current = root;

            while (current != null)
            {
                if (data.CompareTo(current.Data) == 0)
                {
                    return current;
                }
                else if (data.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return null;
        }
    }
}
/*Оба класса параметризованы типом данных, который должен реализовать интерфейс IComparable<T>,
чтобы можно было сравнивать значения и определять порядок элементов в дереве.*/