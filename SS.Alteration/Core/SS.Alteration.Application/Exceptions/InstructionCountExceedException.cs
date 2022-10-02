namespace SS.Alteration.Application.Exceptions
{
    public class InstructionCountExceedException : Exception
    {
        public InstructionCountExceedException() : base("Instruction count can be maximum 2.")
        {
        }

        public InstructionCountExceedException(string message) : base(message)
        {
        }
    }
}
