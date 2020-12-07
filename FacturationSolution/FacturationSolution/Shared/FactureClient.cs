using System;

namespace FacturationSolution.Shared
{
    public class FactureClient
    {
        public string client { get; set; }
        public DateTime emission { get; set; }
        
        public DateTime reglementation { get; set; }
        
        public int numero { get; set; }
        public int montants_dû { get; set; }
        public int montants_regler { get; set; }

        public FactureClient(string client, DateTime emission, DateTime reglementation, int numero, int montants_dû, int montantsRegler)
        {
            this.client = client;
            this.emission = emission;
            this.reglementation = reglementation;
            this.numero = numero;
            this.montants_dû = montants_dû;
            this.montants_regler = montantsRegler;
        }
        
    }
}