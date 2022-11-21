using System;

namespace DataAcessLayer
{
    public class ProcedureException : Exception
    {

        public ProcedureException()
        {
        }

        public ProcedureException(string errorMessage) :base(errorMessage)
        {
        }
    }
}
