//Программа на C# дает не коректные результаты,сделал на python






double[,] matrix=new double[5,5]
{{double.PositiveInfinity, 4, 5, 7, 5},
{8, double.PositiveInfinity,5, 6, 6},
{3,5, double.PositiveInfinity, 9, 6},
{3,5,6,double.PositiveInfinity, 2},
{6, 2, 3, 8, double.PositiveInfinity}};
List<double[,]>matList=new List<double[,]>();
matList.Add(matrix);
double nowstr=5;
double sum=0;
double minval=0;
double nowcolumn=5;
List<double> minlist=new List<double>();
    while(nowcolumn!=1){
        //Нахожу минимальные по строке
        minlist.Clear();
         List<double> list=new List<double>();
        foreach(var i in matrix){
            list.Add(i);
            if(list.Count==nowstr){
                minlist.Add(list.Min());
                list.Clear();
                
            }
        }
        //Отнимаю минимальные по строкам
        for(int i=0;i<nowstr;i++){
           for(int j=0;j<nowcolumn;j++){
                matrix[i,j]-=minlist[i];
           }
        } 
        //Нахожу минимальные по строкам
        // matList.Add(matrix);
        minlist.Clear();    
        for(int i=0;i<nowcolumn;i++){
            list.Clear();
           for(int j=0;j<nowstr;j++){
                list.Add(matrix[j,i]);
           }
            minlist.Add(list.Min());
        } 
        //Отнимаю минимальные по столбцам
        for(int i=0;i<nowcolumn;i++){
           for(int j=0;j<nowstr;j++){
                matrix[j,i]-=minlist[i];
           }
        } 
        // matList.Add(matrix);
        double maxzero=0;
        int izero=0;
        int jzero=0;
        for(int i=0;i<nowcolumn;i++){
           for(int j=0;i<nowstr;i++){
                if(matrix[i,j]==0){
                    double minstr=Double.PositiveInfinity;
                    double mincol=Double.PositiveInfinity;
                            if(matrix[i,j]==0){
                                int delx=i;
                                int dely=j;
                                for(int x=0;x<nowcolumn;x++){
                                        if(x==delx){
                                     for(int y=0;y<nowcolumn;y++){
                                                if(dely==y){
                                                    minstr=Math.Min(minstr,matrix[x,y]);
                                                }
                                }
                                        }
                                }
                            }
                    Console.WriteLine(minstr);
                    for(int t=0;t<nowcolumn;t++){
                        if(t!=i){
                            mincol=Math.Min(mincol,matrix[t,j]);
                        }
                    }
                    if( minstr + mincol > maxzero){
                    maxzero = minstr+ mincol;
                    izero = i;
                    jzero = j;
                    }
                }
            } 
        }
        nowstr--;
        nowcolumn--;
        int ind=0;
        int jnd=0;
      
        matrix[izero,jzero] = Double.PositiveInfinity;
        double[,] copy=new double[Convert.ToInt32(nowcolumn),Convert.ToInt32(nowcolumn)];
        for(int i=0;i<nowcolumn-1;i++){
            jnd=0;
            if(i!=izero){

                for(int j=0;j<nowcolumn-1;j++)   { 
                   
                    if(j!=jzero){
                       
                        copy[ind,jnd]=matrix[i,j];
                        jnd+=1;
                    }
               
                }
                ind+=1;
            }
        }
 
            matrix=copy.Clone() as double[,];
     sum += minlist[minlist.Count-1];
    
}  
Console.WriteLine(sum);
        
