﻿using BepuPhysicIntegrationTest.Integration.Processors;
using BepuPhysics.Constraints;
using Stride.Core;
using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Engine.Design;

namespace BepuPhysicIntegrationTest.Integration.Components.Constraints
{
    [DataContract]
    [DefaultEntityComponentProcessor(typeof(ConstraintProcessor), ExecutionMode = ExecutionMode.Runtime)]
    [ComponentCategory("Bepu - Constraint")]
    public class AngularSwivelHingeConstraintComponent : ConstraintComponent
    {
        internal AngularSwivelHinge _bepuConstraint = new() { SpringSettings = new SpringSettings(30, 5) };

        public Vector3 LocalSwivelAxisA
        {
            get
            {
                return _bepuConstraint.LocalSwivelAxisA.ToStrideVector();
            }
            set
            {
                _bepuConstraint.LocalSwivelAxisA = value.ToNumericVector();
                if (ConstraintData?.Exist == true)
                    ConstraintData.BepuSimulation.Simulation.Solver.ApplyDescription(ConstraintData.CHandle, _bepuConstraint);
            }
        }

        public Vector3 LocalHingeAxisB
        {
            get
            {
                return _bepuConstraint.LocalHingeAxisB.ToStrideVector();
            }
            set
            {
                _bepuConstraint.LocalHingeAxisB = value.ToNumericVector();
                if (ConstraintData?.Exist == true)
                    ConstraintData.BepuSimulation.Simulation.Solver.ApplyDescription(ConstraintData.CHandle, _bepuConstraint);
            }
        }

        public SpringSettings SpringSettings
        {
            get
            {
                return _bepuConstraint.SpringSettings;
            }
            set
            {
                _bepuConstraint.SpringSettings = value;
                if (ConstraintData?.Exist == true)
                    ConstraintData.BepuSimulation.Simulation.Solver.ApplyDescription(ConstraintData.CHandle, _bepuConstraint);
            }
        }
    }
}
