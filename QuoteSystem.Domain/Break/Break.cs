using System;
using System.Collections.Generic;
using System.Text;
using QuoteSystem.Domain.Shared;

namespace QuoteSystem.Domain.Break
{
    public class Break : IAggregateRoot
    {
        
        private Break()
        {

        }
        public int BreakId { get; private set; }

        public Material Material { get; private set; }

        public ICollection<FMSI> FMSIs { get; private set; }

        public ICollection<TRW> TRWs { get; private set; }

        public ICollection<TEXTAR> TEXTARs { get; private set; }

        public Size BreakSize { get; private set; }

        public Size SteelBackSize { get; private set; }

        public decimal Area { get; private set; }


        public decimal GetMaterialAmount()
        {
            return (Area * (BreakSize.Thickness - SteelBackSize.Thickness) / 10 * Material.FeedRate * 1.03m + 10) * 4;
        }
    }
}
