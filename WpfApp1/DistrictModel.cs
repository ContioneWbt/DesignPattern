using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// 行政区表
    /// </summary>
    public class DistrictModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        private int id;
        /// <summary>
        /// 代码
        /// </summary>
        private int code;
        /// <summary>
        /// 名称
        /// </summary>
        private string name;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        /// <summary>
        /// 代码
        /// </summary>
        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

    }
}
