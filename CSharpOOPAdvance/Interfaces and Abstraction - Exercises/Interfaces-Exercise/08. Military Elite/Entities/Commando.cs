using System;
using _08.Military_Elite.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Military_Elite.Entities
{
    public class Commando : SpecialisedSoldier,ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corps,IList<IMission>missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IList<IMission> Missions { get; private set; }

        public void CompleteMission()
        {
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"   {string.Join(Environment.NewLine + "   ", this.Missions)}");

            return sb.ToString().Trim();
        }
    }
}
