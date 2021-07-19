using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.Classes
{
    class TabelaTime : IEquatable<TabelaTime>, IComparable<TabelaTime>
    {
        public Time time;
        public int pontos;

        public int CompareTo([AllowNull] TabelaTime other)
        {
            if (other == null) return 1;
            if (other != null)
                return this.pontos.CompareTo(other.pontos);
            else
                throw new ArgumentException("Objeto inválido");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TabelaTime);
        }

        public bool Equals(TabelaTime other)
        {
            return other != null &&
                   EqualityComparer<Time>.Default.Equals(time, other.time);
        }
    }
}
