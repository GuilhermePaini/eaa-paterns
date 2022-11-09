namespace ProxyVirtual {
    internal class Program
    {
        private static void Main(string[] args)
        {
            RealOrder orderWithOutProxy = new RealOrder();
            Console.WriteLine("Finished!!");
            Console.WriteLine("==========");

            ProxyOrder proxyOrder = new ProxyOrder();
            proxyOrder.ProcessOrder();
            Console.WriteLine("Finished!!");
            Console.WriteLine("==========");
        }
    }
}
