using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingFun
{
    class CarIsDeadException : Exception
    {
        private string messageDetails { get; set; }
        public DateTime ExceptionTime { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException(string messageDetails, DateTime exceptionTime, string causeOfError, string help)
        {
            this.messageDetails = messageDetails;
            ExceptionTime = exceptionTime;
            CauseOfError = causeOfError;
            HelpLink = help;
        }

        public override string Message => "The error is " + messageDetails;
    }
}
