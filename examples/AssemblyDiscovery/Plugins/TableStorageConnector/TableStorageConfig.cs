﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TableStorageConnector
{
    public class TableStorageConfig
    {
        public string StorageAccount { get; set; }
        public string StorageKey { get; set; }
        public string TableName { get; set; }
    }
}
