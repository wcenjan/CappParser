namespace CappParser
{
    /// <summary> 工序内容模型 </summary>
    public class ProcessItemBlock
    {
        /// <summary> 工序号 </summary>
        public int ProcessNo { get; set; }

        /// <summary> 工序名称 </summary>
        public string ProcessName { get; set; }

        /// <summary> 工序内容 </summary>
        public string ProcessContent { get; set; }

        /// <summary> 车间 </summary>
        public string JobShop { get; set; }

        /// <summary> 工段 </summary>
        public string JobSection { get; set; }

        /// <summary> 设备 </summary>
        public string Device { get; set; }

        /// <summary> 工艺装备 </summary>
        public string TechinalEquipment { get; set; }

        /// <summary> 准终工时 </summary>
        public int? EndHours { get; set; }

        /// <summary> 单件工时 </summary>
        public int? SingleHours { get; set; }
    }
}