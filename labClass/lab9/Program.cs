using System.Linq;
int[] array={-5,-4,-3,-2,-1,0,1,2,3,4,5};
var selectednumbers = from i in array
    where i > 0
    select i;
var selectedeven=from i in array
    
    where i%2==0
    select i;
int sum = 0;
foreach (int num in selectednumbers)
{
    sum += num;
}
int mult=1;
foreach (int num in selectednumbers)
{
    mult *= num;
}


Console.WriteLine($"Сумма:{sum}");
Console.WriteLine($"Произведение:{mult}");
Console.WriteLine($"Кол-во четных:{(from x in selectedeven select x).Count()}");
foreach(int i in array){
    if(i%2!=0){
         array = Array.FindAll(array, j => j !=i ).ToArray();
    }
}
//2 часть после удаления нечетныхы
 selectednumbers = from i in array
    where i > 0
    select i;
selectedeven=from i in array
    
    where i%2==0
    select i;
 sum = 0;
foreach (int num in selectednumbers)
{
    sum += num;
}
mult=1;
foreach (int num in selectednumbers)
{
    mult *= num;
}
Console.WriteLine($"Сумма:{sum}");
Console.WriteLine($"Произведение:{mult}");
Console.WriteLine($"Кол-во четных:{(from x in selectedeven select x).Count()}");