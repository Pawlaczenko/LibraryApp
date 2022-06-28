using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Exceptions
{
    public class BorrowingConflictException : Exception
    {
        public Borrowing ExistingBorrowing { get; }
        public Borrowing IncomingBorrowing { get; }
        public BorrowingConflictException(Borrowing existingBorrowing, Borrowing incomingBorrowing)
        {
            ExistingBorrowing = existingBorrowing;
            IncomingBorrowing = incomingBorrowing;
        }

        public BorrowingConflictException(string? message, Borrowing existingBorrowing, Borrowing incomingBorrowing) : base(message)
        {
            ExistingBorrowing = existingBorrowing;
            IncomingBorrowing = incomingBorrowing;
        }

        public BorrowingConflictException(string? message, Borrowing existingBorrowing, Borrowing incomingBorrowing, Exception? innerException) : base(message, innerException)
        {
            ExistingBorrowing = existingBorrowing;
            IncomingBorrowing = incomingBorrowing;
        }

        protected BorrowingConflictException(SerializationInfo info, Borrowing existingBorrowing, Borrowing incomingBorrowing, StreamingContext context) : base(info, context)
        {
            ExistingBorrowing = existingBorrowing;
            IncomingBorrowing = incomingBorrowing;
        }
    }
}
