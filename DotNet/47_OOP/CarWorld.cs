using System;
using System.Collections;

/*
 * 네임스페이스 : 클래스 이름 충돌 방지
 */
namespace CarWorld
{
    // 인터페이스 : 표준, 다중 상속
    interface IStandard { void Run(); }         // 추상화

    ///<summary>
    /// 클래스 : 설계도
    ///</summary>
    class Car : IStandard       // 상속
    {
        // 캡슐화
        #region 필드 : Private Member Variables
        private string name;        // 필드 : 부품
        private string[] names;         // 배열형 필드
        private readonly int _Length;       // 읽기전용 필드
        #endregion

        #region 생성자 : Constructors
        public Car()
        {
            this.name = "좋은 차";         // 필드를 기본값으로 초기화
        }
        public Car(string name)         // 생성자 : 시동, 필드 초기화
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.name = "좋은 차";
            _Length = length;       // 읽기전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length];         // 넘겨받은 값으로 요소 생성
        }
        #endregion

        #region 메서드 : Public Methods
        // 메서드 : 기능/동작
        public void Run() => Console.WriteLine("{0} 자동차가 달립니다.", name);
        #endregion

        #region 속성 : Public Properties
        public string Name      // 속성 : private 필드 -> 외부 공개
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region 소멸자 : Destructor
        ~Car()      // 소멸자 : 폐차, 만들어진 객체 소멸될 때
        {
            Console.WriteLine("{0} 자동차가 폐차됨.");
        }
        #endregion

        #region 인덱서 : Indexer
        public string this[int index]       // 인덱서 : 카탈로그화
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region 이터레이터 : Iterators
        public IEnumerator GetEnumerator()      // 반복기
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region 대리자 : Public Delegates
        public delegate void EventHandler();        // 대리자 : 다중 메서드 호출
        #endregion

        #region 이벤트 : Public Events
        public event EventHandler Click;        // 이벤트
        #endregion

        #region 이벤트 처리기 : Event Handlers
        public void OnClick()       // 이벤트 핸들러
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarRepair
    {
        // 다형성
        public CarRepair(IStandard car) => car.Run();
    }

    class CarWorld
    {
        static void Main()
        {
            // 클래스, 생성자, 메서드 테스트
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            // 속성 테스트
            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();

            // 인덱서 테스트
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            for (int i = 0; i< cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // 이터레이터 테스트
            foreach (string name in cars)
            {
                Console.WriteLine(name);
            }

            // 대리자, 이벤트, 이벤트 처리기 테스트
            Car btn = new Car("전기 자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();

            new CarRepair(campingCar);
            new CarRepair(sportCar);
        }
    }
}