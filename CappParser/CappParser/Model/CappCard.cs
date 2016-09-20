using System.Collections.Generic;

namespace CappParser
{
    /// <summary> 工艺卡片数据模型 </summary>
    public class CappCard
    {
        /// <summary>
        /// 标题内容
        /// </summary>
        public CappTitleBlock Title { get; set; }

        /// <summary>
        /// 工序列表
        /// </summary>
        public List<ProcessItemBlock> Processes { get; set; }
    }
}