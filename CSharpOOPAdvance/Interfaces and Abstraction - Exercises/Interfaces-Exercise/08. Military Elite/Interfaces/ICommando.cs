using System.Collections;
using System.Collections.Generic;

namespace _08.Military_Elite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }

        void CompleteMission();
    }
}