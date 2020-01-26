
using StopBeingJerk.Dto.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace StopBeingJerk.Shared
{
    public static class EnumHelper
    {
        public static IEnumerable<AutoCompleteDto> GetValuesForAutocomplete(Type type)
        {
            Array values = Enum.GetValues(type);
            var result = new List<AutoCompleteDto>();

            foreach (int val in values)
            {
                var memInfo = type.GetMember(type.GetEnumName(val));
                var descriptionAttribute = memInfo[0]
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute;

                if (descriptionAttribute != null)
                {
                    result.Add(new AutoCompleteDto() { Name = descriptionAttribute.Description, Value = val.ToString() });
                }
            }

            return result;
        }
    }
}

