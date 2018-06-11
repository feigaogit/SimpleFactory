using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Bases
{
    /// <summary>
    /// pizza
    /// </summary>
    public interface IPizza
    {
        /// <summary>
        /// pizza的类型
        /// </summary>
        string Type { get; }
        /// <summary>
        /// 准备
        /// </summary>
        void Prepare();
        /// <summary>
        /// 烘焙
        /// </summary>
        void Bake();
        /// <summary>
        /// 切
        /// </summary>
        void Cut();
        /// <summary>
        /// 装盒
        /// </summary>
        void Box();
    }
}
