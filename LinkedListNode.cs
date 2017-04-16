class LinkedList
    {
        
        public LinkedListNode head { get; set; }
        public void Add(int valor)
        {
            head = new LinkedListNode(valor, head);
        }
        public void Clear()
        {
            head = null;
        }

        public bool Contains(int valor)
        {
            while (valor != null)
            {
                if (valor == valor)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(int valor)
        {
            while (valor != null)
            {
               /* if (valor = IReadOnlyList.Equals(LinkedListNode.))
                {*/
                   
                    return true;
                //}

            }
            return false;
        }

        public void exibir()
        {
         
            Console.WriteLine(head.GetValor());
        }

    }
}
