using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace kpValko
{
    public static class EnumExtensions
    {
        public static void AddEnumValue(Type enumType, string value, object valueToAdd)
        {
            // Получаем информацию об объекте enum
            FieldInfo lastEnumField = enumType.GetFields(BindingFlags.Static | BindingFlags.Public).LastOrDefault();
            object lastEnumValue = lastEnumField.GetValue(null);
            object newValue = Convert.ChangeType(valueToAdd, lastEnumValue.GetType());

            // Добавляем новый элемент enum
            string[] valueNames = Enum.GetNames(enumType);
            Array values = Enum.GetValues(enumType);
            valueNames[valueNames.Length - 1] = value;
            values.SetValue(newValue, values.Length - 1);
            FieldInfo field = enumType.GetField("value__", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(lastEnumValue, Convert.ToInt32(values.GetValue(values.Length - 1)));
        }
    }
}
