using System.Collections;
using System.Collections.Generic;

namespace _08.Military_Elite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Soliders { get; }
    }
}