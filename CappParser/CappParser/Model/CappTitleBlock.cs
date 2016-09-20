using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CappParser
{
    /// <summary>Capp标题部分的数据模型 </summary>
  public  class CappTitleBlock
    {
        /// <summary> 产品型号 </summary>
        public string ProductNo { get; set; }

        /// <summary> 产品名称 </summary>
        public string ProductName { get; set; }

        /// <summary> 零件图号 </summary>
        public string DrawNo { get; set; }

        /// <summary> 零件名称 </summary>
        public string DrawName { get; set; }

        /// <summary> 毛坯种类 </summary>
        public string BlankType { get; set; }

        /// <summary> 材料牌号 </summary>
        public string Material { get; set; }

        /// <summary> 毛坯尺寸 </summary>
        public string BlankDimension { get; set; }

        /// <summary> 每毛坯可制件数 </summary>
        public int? NumFromBlank { get; set; }

        /// <summary> 每台件数 </summary>
        public int? Num { get; set; }

        /// <summary> 备注 </summary>
        public string Remark { get; set; }
    }
}
