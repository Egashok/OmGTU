﻿using System.Linq;

var product=new List<string[]>();
var creator=new List<string[]>();
var countProduct=new List<string[]>();

while(true){
    Console.Clear();
    Console.WriteLine("Меню \n\n1.Добавить товар\n2.Добавить производителя\n3.Дабавить поставку\n4.Выборка\n0.Выход");
    string k = Console.ReadLine();
    Console.Clear();

    if (k=="1"){
        Console.Write("Введите наименование продукта: ");
        string name = Console.ReadLine();
        string product_id = Convert.ToString(product.Count());
        string[] prod = {name, product_id};
        product.Add(prod);
    }
    if (k=="2"){
        Console.Write("Введите наименование производителя: ");
        string name = Console.ReadLine();
        string creator_id = Convert.ToString(creator.Count());
        string[] cr = {name, creator_id};
        creator.Add(cr);
    }
    if (k=="3"){
        Console.Write("Введите id товара: ");
        string product_id = Console.ReadLine();
        Console.Write("Введите id производителя: ");
        string creator_id = Console.ReadLine();
        Console.Write("Введите количество: ");
        string count = Console.ReadLine();
        Console.Write("Введите дату: ");
        string date = Console.ReadLine();
        string[] c = {product_id, creator_id, count, date};
        countProduct.Add(c);
    }
    if (k=="4"){
        while(true){
            Console.WriteLine("1.По дате\n2.По товару\n3.По поставщику\n0.Выход");
            string k1 = Console.ReadLine();
            if(k1=="1"){
                Console.Write("Введите дату: ");
                string date = Console.ReadLine();
                var d = from i in countProduct
                where i[3] == date
                select i;

                foreach(var i in d){
                    Console.WriteLine($"id товара {i[0]} id производителя {i[1]} количество {i[2]}");    
                }
            }
            if(k1=="2"){
                string product_id = "0";
                Console.Write("Введите название товар: ");
                string product_name = Console.ReadLine();
                for(int i = 0;i<product.Count();i++){
                    if(product[i][1]==product_name){
                        product_id = product[i][0];
                    }
                }

                var p = from i in countProduct
                where i[0] == product_id
                select i;

                foreach(var i in p){
                    Console.WriteLine($"id производителя {i[1]} количество {i[2]} дата {i[3]}");    
                }
            }
            if(k1=="3"){
                string creator_id = "0";
                Console.Write("Введите производителя: ");
                string creator_name = Console.ReadLine();
                for(int i = 0;i<creator.Count();i++){
                    if(product[i][1]==creator_name){
                        creator_id = product[i][0];
                    }
                }

                var c = from i in countProduct
                where i[1] == creator_id
                select i;

                foreach(var i in c){
                    Console.WriteLine($"id товара {i[0]} количество {i[2]} дата {i[3]}");    
                }
            }
            if(k1=="0"){
               break; 
            }
        }
    }
    if (k=="0"){
        break;
    }
}
 