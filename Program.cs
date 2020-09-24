using System;
using System.Collections;

namespace pratical_4_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            Console.WriteLine("1. Insert new Student");
            Console.WriteLine("2. View list of Students");
            Console.WriteLine("3. Search students");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\nSelect: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.addStudent();
                        break;
                    case 2:
                        program.viewStudents();
                        break;
                    case 3:
                        program.searchStudent();
                        break;
                    case 4:
                        return;
                }
            }
            while (choice != 4);
        }
        int count = 0;
        Hashtable listStudent = new Hashtable();
        public void addStudent()
        {
            Student st = new Student();
            st.ID = count;
            Console.WriteLine("Input Fullname: ");
            st.FullName = Console.ReadLine();
            Console.WriteLine("Input Date of Birth: ");
            st.DateofBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input Native: ");
            st.Native = Console.ReadLine();
            Console.WriteLine("Input Class: ");
            st.Class = Console.ReadLine();
            Console.WriteLine("Input PhoneNo: ");
            st.PhoneNo = Console.ReadLine();
            Console.WriteLine("Input Mobile: ");
            st.Mobile = int.Parse(Console.ReadLine());
            listStudent.Add(count, st);
            count++;
        }
        public void viewStudents()
        {
            foreach (Student item in listStudent.Values)
            item.Display();
        }
        public void searchStudent()
        {
            Console.WriteLine("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            foreach (Student item in listStudent.Values)
                if (item.FullName.Equals(name))
                item.Display();
                else Console.WriteLine("Loi khong tim thay ten");
        }
    }
}

