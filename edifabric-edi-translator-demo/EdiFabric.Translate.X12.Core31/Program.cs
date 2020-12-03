﻿using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.X12.Core20
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for X12 004010
            //  Download additional X12 versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Invoices_810.txt"), "EdiFabric.Templates.X12", new X12ReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            var invoices = ediItems.OfType<TS810>();
        }
    }
}