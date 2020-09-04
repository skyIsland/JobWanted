using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobWanted
{
    /// <summary>
    /// 区域编码数据
    /// </summary>
    public class CodesData
    {
        #region  0:智联 1:前程 2:猎聘
        public static Dictionary<string, string[]> codes = new Dictionary<string, string[]>();
        /// <summary> 
        /// 获取区域编码
        /// </summary>
        /// <param name="city">区域（中文）</param>
        /// <param name="type">类型（0:【智联】1:【前程】2:【猎聘】）3:【BOSS】</param>
        /// <returns></returns>
        public static string GetCityCode(RecruitEnum type, string city)
        {
            /*智联
             * [{"code":"530","text":"北京"},{"code":"538","text":"上海"},{"code":"765","text":"深圳"},{"code":"763","text":"广州"},{"code":"531","text":"天津"},{"code":"801","text":"成都"},{"code":"653","text":"杭州"},{"code":"736","text":"武汉"},{"code":"600","text":"大连"},{"code":"613","text":"长春"},{"code":"635","text":"南京"},{"code":"702","text":"济南"},{"code":"703","text":"青岛"},{"code":"639","text":"苏州"},{"code":"599","text":"沈阳"},{"code":"854","text":"西安"},{"code":"719","text":"郑州"},{"code":"749","text":"长沙"},{"code":"551","text":"重庆"},{"code":"622","text":"哈尔滨"},{"code":"636","text":"无锡"},{"code":"654","text":"宁波"},{"code":"681","text":"福州"},{"code":"682","text":"厦门"},{"code":"565","text":"石家庄"},{"code":"664","text":"合肥"},{"code":"773","text":"惠州"}]
             */

            city = city.Trim().TrimEnd('市');
            if (codes.Count <= 0)
            {
                codes.Add("北京", new string[] { "530", "010", "101010100" });
                codes.Add("上海", new string[] { "538", "020", "101020100" });
                codes.Add("深圳", new string[] { "765", "050090", "101280600" });
                codes.Add("广州", new string[] { "763", "050020", "101280100" });
                codes.Add("杭州", new string[] { "531", "070020", "101210100" });
                codes.Add("成都", new string[] { "801", "280020", "101270100" });
                codes.Add("南京", new string[] { "635", "060020", "101190100" });
                codes.Add("武汉", new string[] { "736", "170020", "101200100" });
                codes.Add("西安", new string[] { "854", "270020", "101110100" });
                codes.Add("厦门", new string[] { "682", "090040", "101230200" });
                codes.Add("长沙", new string[] { "749", "180020", "101250100" });
                codes.Add("苏州", new string[] { "639", "060080", "101190400" });
                codes.Add("天津", new string[] { "531", "030", "101030100" });
                codes.Add("重庆", new string[] { "060000", "040", "101040100" });
                codes.Add("郑州", new string[] { "170200", "150020", "101180100" });
                codes.Add("青岛", new string[] { "120300", "250070", "101120200" });
                codes.Add("合肥", new string[] { "150200", "080020", "101220100" });
                codes.Add("福州", new string[] { "110200", "090020", "101230100" });
                codes.Add("济南", new string[] { "120200", "250020", "101120100" });
                codes.Add("大连", new string[] { "230300", "210040", "101070200" });
                codes.Add("珠海", new string[] { "030500", "050140", "101280700" });
                codes.Add("无锡", new string[] { "070400", "060100", "101190200" });
                codes.Add("佛山", new string[] { "030600", "050050", "101280800" });
                codes.Add("东莞", new string[] { "030800", "050040", "101281600" });
                codes.Add("宁波", new string[] { "080300", "070030", "101210400" });
                codes.Add("常州", new string[] { "070500", "060040", "101191100" });
                codes.Add("沈阳", new string[] { "230200", "210020", "101070100" });
                codes.Add("石家庄", new string[] { "160200", "140020", "101090100" });
                codes.Add("昆明", new string[] { "250200", "310020", "101290100" });
                codes.Add("南昌", new string[] { "130200", "200020", "101240100" });
                codes.Add("南宁", new string[] { "140200", "110020", "101300100" });
                codes.Add("哈尔滨", new string[] { "220200", "160020", "101050100" });
                codes.Add("海口", new string[] { "100200", "130020", "101310100" });
                codes.Add("中山", new string[] { "030700", "050130", "101281700" });
                codes.Add("惠州", new string[] { "030300", "050060", "101280300" });
                codes.Add("贵阳", new string[] { "260200", "120020", "101260100" });
                codes.Add("长春", new string[] { "240200", "190020", "101060100" });
                codes.Add("太原", new string[] { "210200", "260020", "101100100" });
                codes.Add("嘉兴", new string[] { "080700", "070090", "101210300" });
                codes.Add("泰安", new string[] { "121100", "250090", "101120800" });
                codes.Add("昆山", new string[] { "070600", "060050", "101191400" });
                codes.Add("烟台", new string[] { "120400", "250120", "101120500" });
                codes.Add("兰州", new string[] { "270200", "100020", "101160100" });
                codes.Add("泉州", new string[] { "110400", "090030", "101230500" });
            }
            if (codes.Keys.Contains(city))
                return codes[city][(int)type];
            return null;
        }
        #endregion
    }
}
