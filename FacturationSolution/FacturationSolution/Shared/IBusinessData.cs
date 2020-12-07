using System.Collections.Generic;

namespace FacturationSolution.Shared
{
    public interface IBusinessData
    {
        IEnumerable<FactureClient> Factures { get; }
    }
}