List<string> ribrs=new List<string>();
Console.WriteLine("Введите рёбра:");//кроме нуля
while(true){
    string ribr=Console.ReadLine();
    if(ribr!="0"){
    ribrs.Add(ribr);
    }
    else{
        break;
    }
}
