Garage garage=new Garage();
Car car1=new Car("Lada","2114");
Car car2=new Car("Nissan","Sunny");
Car car3=new Car("Toyta","Camry");
garage.AddCar(car1);
garage.AddCar(car2);
garage.AddCar(car3);

WashCar wash=Wash.WashingCar;
wash(car3);
WashCars washS=Wash.WashingCars;
washS(garage);
garage.GetCars();
public class Garage{
    public List<Car> carList=new List<Car>();
    public void AddCar(Car car){
        carList.Add(car);
    }
    public void DeleteCar(Car car){
        carList.Remove(car);
    }
    public void GetCars(){
        foreach (var i in carList)
        {
            Console.WriteLine($"{i.mark} {i.model} {i.status}");
        }
    }
}
public class Car{
    public string mark;
    public string model;
    public string status="Не помыта";
    public Car(string mark,string model ){
        this.mark=mark;
        this.model=model;
    }
}
public class Wash{
    public static void WashingCars(Garage garage)
    {
        foreach (Car car in garage.carList)
        {
            car.status = "Помыта";
            Console.WriteLine($"{car.mark} {car.model} {car.status}");
        }
    }
    public static void WashingCar(Car car)
    {
        car.status = "Помыта";
        Console.WriteLine($"Машина {car.mark} {car.model} {car.status}");
    }
}
delegate void WashCars(Garage cars);
delegate void WashCar(Car car);