using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_FrameWork.Application
{
    public class OperationResult
    {
        public bool IsSucceded { get; set; }
        public string Message { get; set; }

        public OperationResult() 
        { 
        IsSucceded = false;
        }

        public OperationResult Succeded(string message = "عملیات با موفقیت انجام شد.")
        {
            IsSucceded = true;
            Message = message;
            return this;
        }
        public OperationResult Failed(string message)
        {
            IsSucceded=false;
            Message = message;
            return this;
        }
    }
}
