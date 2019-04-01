using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// 表
    /// </summary>
    public class MapSpotModel
    {
        private int id;
        //名称
        private string name;
        //代码
        private int code;
        //个数
        private int allNumber;
        //面积
        private double allArea;

        //个数
        private int hCTureNumber;
        //面积
        private double hCTrueArea;
        //通过个数
        private int hCTruePassNumber;
        //不通过个数
        private int hCTrueNoPassNumber;
        //通过率
        private string hCTruePassingRate;

        //个数
        private int jLTureNumber;
        //面积
        private double jLTrueArea;
        //通过个数
        private int jLTruePassNumber;
        //不通过个数
        private int jLTrueNoPassNumber;
        //通过率
        private string jLTruePassingRate;

        private DistrictModel districtModels;
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
        /// 个数
        /// </summary>
        public int AllNumber
        {
            get
            {
                return allNumber;
            }

            set
            {
                allNumber = value;
            }
        }

        /// <summary>
        /// 面积
        /// </summary>
        public double AllArea
        {
            get
            {
                return allArea;
            }

            set
            {
                allArea = value;
            }
        }

        /// <summary>
        /// 个数
        /// </summary>
        public int HCTureNumber
        {
            get
            {
                return hCTureNumber;
            }

            set
            {
                hCTureNumber = value;
            }
        }

        /// <summary>
        /// 面积
        /// </summary>
        public double HCTrueArea
        {
            get
            {
                return hCTrueArea;
            }

            set
            {
                hCTrueArea = value;
            }
        }

        /// <summary>
        /// 通过个数
        /// </summary>
        public int HCTruePassNumber
        {
            get
            {
                return hCTruePassNumber;
            }

            set
            {
                hCTruePassNumber = value;
            }
        }

        /// <summary>
        /// 不通过个数
        /// </summary>
        public int HCTrueNoPassNumber
        {
            get
            {
                return hCTrueNoPassNumber;
            }

            set
            {
                hCTrueNoPassNumber = value;
            }
        }

        /// <summary>
        /// 通过率
        /// </summary>
        public string HCTruePassingRate
        {
            get
            {
                return hCTruePassingRate;
            }

            set
            {
                hCTruePassingRate = value;
            }
        }

        /// <summary>
        /// 个数
        /// </summary>
        public int JLTureNumber
        {
            get
            {
                return jLTureNumber;
            }

            set
            {
                jLTureNumber = value;
            }
        }

        /// <summary>
        /// 面积
        /// </summary>
        public double JLTrueArea
        {
            get
            {
                return jLTrueArea;
            }

            set
            {
                jLTrueArea = value;
            }
        }

        /// <summary>
        /// 通过个数
        /// </summary>
        public int JLTruePassNumber
        {
            get
            {
                return jLTruePassNumber;
            }

            set
            {
                jLTruePassNumber = value;
            }
        }

        /// <summary>
        /// 不通过个数
        /// </summary>
        public int JLTrueNoPassNumber
        {
            get
            {
                return jLTrueNoPassNumber;
            }

            set
            {
                jLTrueNoPassNumber = value;
            }
        }

        /// <summary>
        /// 监理单位已审核图斑-通过率
        /// </summary>
        public string JLTruePassingRate
        {
            get
            {
                return jLTruePassingRate;
            }

            set
            {
                jLTruePassingRate = value;
            }
        }

        public DistrictModel DistrictModels
        {
            get
            {
                return districtModels;
            }

            set
            {
                districtModels = value;
            }
        }
    }
}
