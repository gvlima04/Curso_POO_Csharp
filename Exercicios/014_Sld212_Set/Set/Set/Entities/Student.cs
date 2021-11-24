namespace Set.Entities
{

    class Student
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


    }
}
