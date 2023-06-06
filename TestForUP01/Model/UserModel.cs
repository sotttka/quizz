namespace TestForUP01.Model
{
    public class UserModel
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Patronymic { get; private set; }

        public ClassModel Class { get; private set; }


        public UserModel(string name, string surname, string patronymic, ClassModel classModel)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Class = classModel;
        }
    }
}
