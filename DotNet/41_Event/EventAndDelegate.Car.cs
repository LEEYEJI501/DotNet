using System;

namespace EventAndDelegateDemo
{
    // 이벤트 게시자(publisher)
    class Car
    {
        private int _fuelGauge;
        public int FuelGauge
        {
            get { return _fuelGauge; }
            set 
            { 
                _fuelGauge = value;
                OnFuelEmptyReached();
            }
        }

        public Car()
        {
            _fuelGauge = 25;
        }

        public void Go()
        {
            Console.WriteLine("운전");
            FuelGauge -= 5;
        }
        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached;
        public event Action FuelEmptyReached;
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태 : {_fuelGauge}%");
            if (_fuelGauge < 20)
            {
                if (FuelEmptyReached != null)
                    FuelEmptyReached?.Invoke();
            }
        }
    }
}
