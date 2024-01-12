﻿using System.Runtime.CompilerServices;
using BepuPhysics.Collidables;
using Stride.BepuPhysics.Configurations;
using Stride.BepuPhysics.Extensions;

namespace Stride.BepuPhysics.Definitions.Raycast
{
    public static class TestHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllowTest(BepuSimulation sim, byte collisionMask, CollidableReference collidable)
        {
            var result = collidable.GetContainerFromCollidable(sim);
            var a = collisionMask;
            var b = result.ColliderGroupMask;
            var com = a & b;
            return com == a || com == b && com != 0;
        }
    }
}