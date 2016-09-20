using System.Collections.Generic;

namespace CappParser
{
    public interface ICappParser
    {
        /// <summary>
        /// 判断是否为有效文件
        /// </summary>
        /// <returns></returns>
        bool IsValidate();

        string FilePath { get; set; }

        /// <summary>
        /// 得到标题栏
        /// </summary>
        /// <returns></returns>
        CappTitleBlock GetTitleBlock();

        /// <summary>
        /// 得到工序列表
        /// </summary>
        /// <returns></returns>
        List<ProcessItemBlock> GetProcesses();

        /// <summary>
        /// 得到工艺卡片对象
        /// </summary>
        /// <returns></returns>
        CappCard GetCappCard();

        void SetTitleBlock(string paraName, string paraValue);

        void SaveDoc(string path);
    }
}