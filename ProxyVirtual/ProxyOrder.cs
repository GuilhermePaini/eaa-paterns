namespace ProxyVirtual;

public class ProxyOrder : IOrder {
    private static IOrder? realOrder;

    public ProxyOrder() {
    }

    public void ProcessOrder() {
        if(realOrder == null)
            realOrder = new RealOrder();

        realOrder.ProcessOrder();
    }
}