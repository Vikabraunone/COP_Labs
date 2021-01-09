namespace CommandPattern
{
    public class User
    {
        ICommand enrollStudent;
        ICommand changeInfoStudent;
        ICommand deductStudent;

        public User(ICommand enrollStudent, ICommand changeInfoStudent, ICommand deductStudent)
        {
            this.enrollStudent = enrollStudent;
            this.changeInfoStudent = changeInfoStudent;
            this.deductStudent = deductStudent;
        }

        public void Enroll()
        {
            enrollStudent.Execute();
        }

        public void Deduct()
        {
            deductStudent.Execute();
        }

        public void Change()
        {
            changeInfoStudent.Execute();
        }
    }
}
