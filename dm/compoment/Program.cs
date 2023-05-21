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
 var listComp=new List<List<string>>();
 var firstList=new List<string>();
 firstList.Add(Convert.ToString(ribrs[1][0]));
 firstList.Add(Convert.ToString(ribrs[1][1]));
 listComp.Add(firstList);
 bool flag=false;
 var peaks=new List<string>();
 foreach (var i in ribrs)
 {
     if(!peaks.Contains(Convert.ToString(i[0]))){
         peaks.Add(Convert.ToString(i[0]));
     }
     if(!peaks.Contains(Convert.ToString(i[1]))){
          peaks.Add(Convert.ToString(i[1]));
     }
 }   
string np="";
int comp=1;
//берем вершину->ищем соединенные->и по кругу ,берем незадействанные и начинаем новый компонент
var uspeaks=new List<string>();
uspeaks.Add(Convert.ToString(ribrs[0][0]));


while(peaks.Count!=0){
    foreach(var r in ribrs){
   foreach(var p in uspeaks){
     if(r.Contains(p) && !uspeaks.Contains(r.Replace(" ",p))){
        np=r.Replace(p,"");
    }
   }
   if(np!=""){
    uspeaks.Add(np);
    np="";
   }  
}
    foreach(var i in uspeaks){
        if(peaks.Contains(i)){
            peaks.Remove(i);
        }
    }
    if(peaks.Count!=0){
        uspeaks.Add(peaks[0]);
        comp+=1;
    }
}
Console.WriteLine(comp);
