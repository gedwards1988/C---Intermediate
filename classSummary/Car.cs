namespace classSummary
{
    class Car
    {
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if(value > 500)
                {
                    _speed = 500;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        
        
        public Car(int _speed)
        {
            Speed = _speed;
        }

    }
}