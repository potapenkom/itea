using System;

namespace itea
{
    class Student
    {
        private bool IsDrunk;
        public void setIsDrunk(bool state)
        {
            IsDrunk = state;
        }
        public bool getIsDrunk()
        {
            return IsDrunk;
        }
        private int studentTails;
        public void setStudentTails(int tails)
        {
            studentTails = tails;
        }
        public int getStudentTails()
        {
            return studentTails;
        }

        private int studentIq;
        public void setStudentIq(int iq)
        {
            studentIq = iq;
        }
        public int getStudentIq()
        {
            return studentIq;
        }
        private string studentName;
        public void setStudentName()
        {
            Console.Write("Enter your name: ");
            studentName = Console.ReadLine();
        }
        public string getStudentName()
        {
            return studentName;
        }

        private string studentFaculty;
        public void setStudentFaculty()
        {
            Console.Write("Enter your faculty: ");
            studentFaculty = Console.ReadLine();
        }
        public string getStudentFaculty()
        {
            return studentFaculty;
        }

        public void getInfo()
        {
            Console.WriteLine("Student name is " + studentName + " Student studying at the faculty " + 
                studentFaculty + ". Today he is " + (IsDrunk ? "drunk" : "sober") + " Iq level is equal- " 
                + studentIq + " The student has "  + studentTails + " tails");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int iqLevel = rnd.Next(1, 155);
            int tailCount = rnd.Next(0, 8);
            bool result = rnd.Next(100) < 50 ? true : false;
            Student student = new Student();
            student.setStudentName();
            student.setStudentFaculty();
            student.setIsDrunk(result);
            student.setStudentTails(tailCount);
            student.setStudentIq(iqLevel);
            student.getInfo();
            bool IsDrunk = student.getIsDrunk();
            int iq = student.getStudentIq();
            int tails = student.getStudentTails();
            if (IsDrunk == true && iq < 70 || IsDrunk == true && tails > 3 || iq < 70 && tails > 3)
            {
                Console.WriteLine("Student expelled");
            }
            else
            {
                student.setIsDrunk(result);
                IsDrunk = student.getIsDrunk();
                student.getInfo();
                if (IsDrunk == false)
                {
                    iq += 10;
                    student.getInfo();
                }
                student.getInfo();
            }
        }

    }
}

