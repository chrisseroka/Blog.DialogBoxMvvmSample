namespace DialogBoxMvvmSample.ViewModel
{
    public class CustomerItemViewModel
    {
        private readonly string firstName;
        private readonly string lastName;

        public CustomerItemViewModel(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}