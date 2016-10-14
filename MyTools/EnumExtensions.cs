using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            try
            {
                //Get the Type
                Type type = value.GetType();

                //Get FieldInfo for this type
                var fieldInfo = type.GetField(value.ToString());
                //Get The stringValueAttribute
                var attribute = fieldInfo?.GetCustomAttributes(
                    typeof(DisplayValueAttributes), false).Cast<DisplayValueAttributes>().FirstOrDefault();
                //return the first if there was a match.
                return attribute?.Value;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 是枚举类型
        /// </summary>
        /// <param name="value"></param>
        /// <param name="e"></param>
        /// <returns></returns>

        public static bool IsEnumType(this int value, Enum e)
        {
            return value == Convert.ToInt32(e);

        }
        /// <summary>
        /// 获取枚举值
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static int GetEnumValue(this Enum e)
        {
            return Convert.ToInt32(e);
        }
        /// <summary>
        /// 获取枚举名称
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string GetEnumName(this Enum e)
        {
            return Enum.GetName(e.GetType(), e);
        }

        public static string GetValue<Type>(this Enum e, string name) where Type : struct , IConvertible
        {
            var Names= Enum.GetNames(typeof (Type));
            var type = typeof(Type);
            foreach (var item in Names)
            {
                if (item.Contains(name))
                {
                    var fieldInfo= type.GetField(item);
                    var attribute = fieldInfo.GetCustomAttributes(typeof (DisplayValueAttributes), false);
                        
                }
                    
            }
            return null;
        }
    }
}
