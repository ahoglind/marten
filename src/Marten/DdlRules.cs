﻿using System.Collections.Generic;

namespace Marten
{
    public class DdlRules
    {
        /// <summary>
        /// Alters the syntax used to create tables in DDL
        /// </summary>
        public CreationStyle TableCreation { get; set; } = CreationStyle.DropThenCreate;

        /// <summary>
        /// Alters the user rights for the upsert functions in DDL
        /// </summary>
        public SecurityRights UpsertRights { get; set; } = SecurityRights.Invoker;


        /// <summary>
        /// Adds declarations to the DDL to give a specific DB role rights to read, update,
        /// and insert rows into document tables
        /// </summary>
        public IList<string> Grants { get; } = new List<string>();

        /// <summary>
        /// Option to use this database role during DDL scripts
        /// </summary>
        public string Role { get; set; }

    }
}