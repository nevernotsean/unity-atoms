using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtom
{
    /// <summary>
    /// None generic Unity Event of type `CollisionPair`. Inherits from `UnityEvent&lt;CollisionPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionPairUnityEvent : UnityEvent<CollisionPair> { }
}
