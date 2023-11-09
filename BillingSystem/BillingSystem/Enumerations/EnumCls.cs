using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Enumerations
{
    internal class EnumCls
    {
        public static readonly KbnEnum appearDeleted = new KbnEnum(1, "True" , "DeleteFlag");
        public static readonly KbnEnum disappearDeleted = new KbnEnum(0, "False", "False");
    }

    /// <summary>
    /// 区分グラス
    /// </summary>
    public class KbnEnum
    {
        public KbnEnum(int id, string name, string shortNm)
        {
            this.Id = id;
            this.Name = name;
            this.ShortName = shortNm;
        }


        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; }

        public string ShortName { get; }
    }
}
