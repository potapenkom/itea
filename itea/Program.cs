using System;

namespace itea
{
    class Product
    {
        string name;
        int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }

    class Cart
    {
        Product[] products = new Product[10];
        public void addProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    break;
                }
            }
        }
        public void removeProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].getName() == product.getName())
            {  
                    products[i] = null;
                    break;
                }
            }
        }
        public void showCart()
        {
            Console.WriteLine("CART:");
            int total = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.WriteLine("\t" + products[i].getName() + " : " + products[i].getPrice());
                    total += products[i].getPrice();
                }
            }
            Console.WriteLine("\t\tCART TOTAL: " + total);
        }
    }
    class Figures 
    { 
        public string name;
        public string color;
        public int lineA;
        public int lineB;
        public int lineC;
        public int perimeter;
        string[] colors = new string[10] { "red", "white", "blue", "yellow", "green", "black", "pink", "orange", "brown", "grey" };

        public void setName(string name)
        {     
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setColor()
        {
            Random rnd = new Random();
            int rndColor = rnd.Next(1, 9);      
            color = colors[rndColor];
            }

            public string getColor()
            {
                return color;
            }

            public int getlineA()
            {
                return lineA;
            }

            public int getlineB()
            {
                return lineB;
            }

            public int getlineC()
            {
                return lineC;
            }
    }

    class Triangle : Figures
    {
 
        public void  setLine (int a, int b, int c )
        {
            lineA = a;
            lineB = b;
            lineC = c;
        }

        public int setPerimeter()
        {
            perimeter = lineA + lineB + lineC;
            return perimeter;
        }
        public void getInfo()
        {
            Console.WriteLine("Name figure is " + name + ". Line A is " + lineA + " line B is " + 
            lineB + " line C is " + lineC + ". Perimeter is " + perimeter + ". Color " + color);
        }
    }

    class Circle : Figures
     {
        private double  radius; 
        double PI = 3.14;
        double perimeter;
    public void setRadius (double r)
    {
        radius = r;
    }

   public double getPerimeter()
    {
        perimeter = PI * radius*2;
        return perimeter;
    }

    public void getInfo()
    {
         Console.WriteLine("Name figure is " + name + " .Radius is " + radius + ". Perimeter is " + perimeter + ". Color " + color);
    }
}
    class Rectangle : Figures{

        public void  setLine (int a, int b )
        {
            lineA = a;
            lineB = b;
        }
 
        public int setPerimeter()
        {
            perimeter = (lineA + lineB) * 2;
            return perimeter;
  }
        public void getInfo()
        {
            Console.WriteLine("Name figure is " + name + " .Line A is " + lineA + " line B is " + lineB +  ". Perimeter is "
            + perimeter+ ". Color " + color);
        }
}

    class Program
    {
        public static void Main(string[] args)
        {
               Product p1 = new Product("Coca-Cola", 15);
               Product p2 = new Product("Pepsi-Cola", 17);
               Product p3 = new Product("Milk", 26);
               Product p4 = new Product("Jack Daniels Fire", 450);
               Cart cart = new Cart();
               cart.addProduct(p1);
               cart.addProduct(p3);
               cart.addProduct(p4);
               cart.showCart();
               cart.removeProduct(p4);
               cart.removeProduct(p1);
               cart.showCart();
               Console.WriteLine("Select shape: \n 1.\tTriangle;\n 2.\tCircle;\n 3.\tRectangle;\n 4.\tExit;\n  ");                        
               int answer = Convert.ToInt32(Console.ReadLine());
               switch (answer)
               {
                    case 1:
                        Triangle triangle = new Triangle();
                        Console.WriteLine("Enter line: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter line: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter line: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        triangle.setLine(a, b, c);
                        triangle.setPerimeter();
                        triangle.setName("Triangle");
                        triangle.setColor();
                        triangle.getInfo();
                        break;
                    case 2:
                        Circle circle = new Circle();
                        Console.WriteLine("Enter radius: ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        circle.setRadius(r);
                        circle.setName("Circle");
                        circle.setColor();
                        circle.getPerimeter();
                        circle.getInfo();
                        break;
                    case 3:
                        Rectangle rectangle = new Rectangle();
                        Console.WriteLine("Enter line: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter line: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        rectangle.setLine(x, y);
                        rectangle.setPerimeter();
                        rectangle.setName("Rectangle");
                        rectangle.setColor();
                        rectangle.getInfo();
                        break;
                    case 4:
                        Console.WriteLine("You enter exit");
                        break;
                    default:
                        Console.WriteLine("Erroneous input");
                        break;
                }
        }
    }
}

