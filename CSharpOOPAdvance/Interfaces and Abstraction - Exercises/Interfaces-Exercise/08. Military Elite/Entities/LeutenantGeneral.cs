using System;
using System.Collections.Generic;
using System.Text;
using _08.Military_Elite.Interfaces;

namespace _08.Military_Elite.Entities
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IList<ISoldier> soliders)
            : base(id, firstName, lastName, salary)
        {
            this.Soliders = soliders;
        }

        public IList<ISoldier> Soliders { get; }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Privates:");
            sb.AppendLine($"   {string.Join(Environment.NewLine + "   ", this.Soliders)}");

            return sb.ToString().Trim();
        }
    }
}
