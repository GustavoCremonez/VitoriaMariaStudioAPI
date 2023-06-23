using System.ComponentModel;
using System.Reflection;

public static class EnumHelper
{
    public static string GetEnumDescription(Enum value)
    {
        FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
        DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
            return attributes[0].Description;

        return value.ToString();
    }
}