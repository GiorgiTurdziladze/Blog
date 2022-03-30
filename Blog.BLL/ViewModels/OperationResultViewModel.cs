using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.BLL.ViewModels
{
    public class OperationResultViewModel
    {
        public Boolean Result { get; set; }

        public String Message { get; set; }

        public object Data { get; set; }
        public String UrlAction { get; set; }

        public OperationResultViewModel()
        {

        }

        public OperationResultViewModel(bool result)
        {
            if (result)
                SetSuccess();
        }

        public void SetSuccess()
        {
            Message = "Operation Succeeded";
            Result = true;
        }

        public void SetSuccess(String message)
        {
            Message = message;
            Result = true;
        }

        public void SetError(String message)
        {
            Message = message;
            Result = false;
        }

    }
}
