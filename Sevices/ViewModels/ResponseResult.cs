using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices.ViewModels
{
    public class ResponseResult<T>
    {
        public ResponseResult()
        {
            this.IsSuccessed = true;
        }
        public ResponseResult(T[] data)
        {
            this.IsSuccessed = true;
            this.Data = data;
        }
        public ResponseResult(string errrorMessage)
        {
            this.IsSuccessed = false;
            this.ErrrorMessages = errrorMessage;
        }
        public bool IsSuccessed { get; set; }
        public T[] Data { get; set; }
        public string ErrrorMessages { get; set; }
    }
}
