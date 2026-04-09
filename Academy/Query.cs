using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
     class Query
    {
        public string Fields { get; set; }
        public string Tables { get; set; }
        public string Conditions { get; set; }
        public Query(string fields, string tables, string condition = "")
        { 
            this.Fields = fields;
            this.Tables = tables;
            this.Conditions = condition;
        }
        public override string ToString()
        {
            string cmd = $"SELECT {Fields} FROM {Tables}";
            if (Conditions != "") cmd += $" WHERE {Conditions}";
            return cmd;
        }
    }
}
