class LinkedListNode
    {
        private int valor;
        private LinkedListNode proximoNo;

        public LinkedListNode(int valor, LinkedListNode proximoNo)
        {
            this.valor = valor;
            this.proximoNo = proximoNo;
        }

        public LinkedListNode(int valor)
        {
            this.valor = valor;
        }

        public int GetValor()
        {
            return valor;
        }
        public LinkedListNode GetProximoNo()
        {
            return proximoNo;
        } 
        public void SetProximoNo(LinkedListNode proximoNo)
        {
            this.proximoNo = proximoNo;
        }
    }
