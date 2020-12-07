using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using FacturationSolution.Pages;
using Microsoft.AspNetCore.Components.Forms;

namespace FacturationSolution.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<FactureClient> Factures { get; }
        public BusinessData()
        {
            Factures = new FactureClient[]
            {
                new FactureClient("EDF", new DateTime(2020, 05, 19), new DateTime(2020, 06, 25), 20, 600, 800),
                new FactureClient("SOGETI", new DateTime(2020, 05, 19), new DateTime(2020, 06, 25), 20, 600, 800),
                new FactureClient("SOGETI", new DateTime(2020, 05, 19), new DateTime(2020, 06, 25), 20, 600, 800)
            };
            
        }
    }

}