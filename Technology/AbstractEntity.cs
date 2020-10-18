using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        private static int NextId = 1;
        public int Id { get; }

        public AbstractEntity()
        {
            Id = NextId;
            
            NextId++;
        }
    }
}