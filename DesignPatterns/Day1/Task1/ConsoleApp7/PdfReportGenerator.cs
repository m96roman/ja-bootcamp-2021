﻿using System.Collections.Generic;

namespace ConsoleApp7
{
    public class PdfReportGenerator : IReport
    {
        public string GenerateReport(List<Client> clients)
        {
            return $"pdf report for {clients.Count}";
        }
    }
}
