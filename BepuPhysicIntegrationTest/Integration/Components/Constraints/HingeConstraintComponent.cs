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
    public class HingeConstraintComponent : ConstraintComponent
    {
        internal Hinge _bepuConstraint = new() { SpringSettings = new(30, 5) };

        public Vector3 LocalOffsetA
        {
            get
            {
                return _bepuConstraint.LocalOffsetA.ToStrideVector();
            }
            set
            {
                _bepuConstraint.LocalOffsetA = value.ToNumericVector();
                if (ConstraintData?.Exist == true)
                    ConstraintData.BepuSimulation.Simulation.Solver.ApplyDescription(ConstraintData.CHandle, _bepuConstraint);
            }
        }

        public Vector3 LocalHingeAxisA
        {
            get
            {
                return _bepuConstraint.LocalHingeAxisA.ToStrideVector();
            }
            set
            {
                _bepuConstraint.LocalHingeAxisA = value.ToNumericVector();
                if (ConstraintData?.Exist == true)
                    ConstraintData.BepuSimulation.Simulation.Solver.ApplyDescription(ConstraintData.CHandle, _bepuConstraint);
            }
        }

        public Vector3 LocalOffsetB
        {
            get
            {
                return _bepuConstraint.LocalOffsetB.ToStrideVector();
            }
            set
            {
                _bepuConstraint.LocalOffsetB = value.ToNumericVector();
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
