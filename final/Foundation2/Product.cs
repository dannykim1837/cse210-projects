class Product{

    private string name;
    private string productId;
    private double price;
    private int quantity;



    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    public string getname(){

        return name;
    }

    public string getproductId(){

        return productId;
    }

    public double getprice(){

        return price * quantity;
    }

    public int getquantity(){
        return  quantity;
    }
}