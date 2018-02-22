using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDemo.Model.Response
{
    public class BaseResponse: ISerializable
    {
        /// <summary>
        /// 表示业务是否正常
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回消息,成功的消息和错误消息都在这里
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 用于返回复杂结果
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 自定义序列化方法
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // 运用info对象来添加你所需要序列化的项
            info.AddValue("IsSuccess", IsSuccess);
            info.AddValue("Message", Message);
            if (Data != null)
            {
                info.AddValue("Data", Convert.ChangeType(Data, Data.GetType()));
            }
            else
            {
                info.AddValue("Data", null);
            }
        }

        public BaseResponse() { }
    }
}
