namespace LinkedList
{
    class LinkedList
    {
        private LinkedListNode head;

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
            while(valor != null)
            {
                if(valor == valor)
                {
                    return true;
                }
                return false;
            }
        }
        
        public bool Remove(int valor)
        {
            while(valor != null)
            {
                if(valor = IReadOnlyList.Equals(LinkedListNode))
                {
                    valor = null;
                    return true;
                }
                return false;
            }
        }
    }
}
