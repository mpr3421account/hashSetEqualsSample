using hashSetEqualsSample.Entities;

HashSet<Product> a = new HashSet<Product>();//validando igualdade num objeto tipo Referência (Classe)
a.Add(new Product("TV", 900.0));
a.Add(new Product("Notebook", 1200.0));

HashSet<Point> b = new HashSet<Point>();//validando igualdade num objeto tipo Valor (Struct)
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Product prod = new Product("Notebook", 1200.0);//verificando se o valor Notebook e preço constam no Product a ( Vai dar falso porque está validando através de referência de memória e não conteúdo)
Console.WriteLine(a.Contains(prod));