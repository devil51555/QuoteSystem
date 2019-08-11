using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteSystem.Domain.Break
{
    public class Material
    {

        public Material CreateMaterial(string name, decimal feedRate)
        {
            return new Material{
                Name  = name,
                FeedRate = feedRate
            };
        }

        private Material()
        {

        }
        public int MaterialId { get; private set; }

        public string Name { get; private set; }

        public decimal FeedRate { get; private set; }
    }
}
