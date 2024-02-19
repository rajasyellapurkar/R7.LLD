using System;

namespace R7.DesignPattern.BuilderDesignPattern
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private int id;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        private Student()
        {
            
        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }

        public class Builder
        {
            private Student student;
            internal Builder()
            {
                student = new Student();
            }

            public Builder SetName(string fName)
            {
                student.firstName = fName;
                return this;
            }

            public Builder SetLastName(string lastName) 
            { 
                student.lastName = lastName;
                return this;
            }

            public Builder SetDoB(DateTime dateOfBirth) 
            {
                student.dateOfBirth = dateOfBirth;
                return this;
            }

            public Builder SetId(int id)
            {
                student.id = id;
                return this;
            }

            public Student ValidateAndBuild()
            {
                Validate();
                return student;
            }

            private void Validate()
            {
                if(student.dateOfBirth > DateTime.Now)
                {
                    throw new ArgumentException("Invalid dateOfBirth");
                }
            }
        }
    }
}
