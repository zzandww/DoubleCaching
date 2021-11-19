﻿namespace zozo.Infrastructure.Caching
{
    internal class StringConverter : IConverter<string>
    {
        public string Deserialize(string value)
        {
            return value;
        }

        public string Serialize(object obj)
        {
            return obj.ToString();
        }
    }
}