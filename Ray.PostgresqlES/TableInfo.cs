﻿using System;

namespace Ray.PostgresqlES
{
    public class TableInfo
    {
        public string Table { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
