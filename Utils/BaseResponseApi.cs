using buildingBlocksCore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocksCore.Utils
{
    public class BaseResponseApi<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }

        public List<LNotification> Errors { get; set; }

        public BaseResponseApi()
        {
            Errors = new List<LNotification>();
        }


    }
}
