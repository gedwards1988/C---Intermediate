namespace Encapsulation
{
    class Person
    {
        private int _id;
        private string _userName;
        private string _password;


        public int ID
        {
           get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Person(int Id)
        {
            ID = Id;
        }


    }
}