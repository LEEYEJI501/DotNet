public interface IKs { }
public class GoodCar { }
public class BadCar { public BadCar(string message) { } }
public class OfficeCamper : GoodCar, IKs { }

public class CarValue<T> where T : struct { } // 값 형식만
public class CarReference<T> where T : class { } // 참조 형식만

public class CarNew<T> where T : new() { } // Default 생성자
public class NiceCar { }
public class SosoCar { public SosoCar(string message) { } }

public class TypeConstraint
{
    static void Main()
    {
        CarValue<int> c = new CarValue<int>(); // struct 성공
        //CarValue<string> c = new CarValue<string>(); // 컴파일 에러

        CarReference<string> cs = new CarReference<string>(); // class 성공
        //CarReference<decimal> cs = new CarReference<decimal>(); // 컴파일 에러

        CarNew<NiceCar> nc = new CarNew<NiceCar>(); // new 성공
        //CarNew<SosoCar> sc = new CarNew<SosoCar>(); 
            // 매개변수 있는 생성자를 T에 전달 시 에러
            // -> 기본 생성자가 없을 때 CarNew<T>에 전달했기 때문
    }
}