
using System.Collections.Generic;

namespace CappParser
{
    /// <summary>
    /// CappParser抽象基类
    /// </summary>
    public abstract class BaseCappParser : ICappParser
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 判断文件路径的有效性
        /// </summary>
        /// <returns></returns>
        public virtual bool IsValidate()
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 返回空对象
        /// </summary>
        /// <returns></returns>
        public virtual CappTitleBlock GetTitleBlock()
        {
            return new CappTitleBlock();
        }

        /// <summary>
        /// 返回空表
        /// </summary>
        /// <returns></returns>
        public virtual List<ProcessItemBlock> GetProcesses()
        {
            return new List<ProcessItemBlock>();
        }




        public virtual CappCard GetCappCard()
        {
            CappCard card = new CappCard()
            {
                Title = GetTitleBlock(),
                Processes = GetProcesses()
            };
            return card;
        }


        public abstract void SetTitleBlock(string paraName, string paraValue);


        public abstract void SaveDoc(string path);
    }
}