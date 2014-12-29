﻿namespace System.Configuration
{
    internal class ConfigurationPropertyAttribute : Attribute
    {
        private string v;

        public ConfigurationPropertyAttribute(string v)
        {
            this.v = v;
        }

        public string DefaultValue { get; set; }
    }
}