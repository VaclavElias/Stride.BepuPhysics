﻿using System.ComponentModel;
using BepuPhysicIntegrationTest.Integration.Processors;
using BepuPhysics;
using Stride.Core;
using Stride.Engine;
using Stride.Engine.Design;

namespace BepuPhysicIntegrationTest.Integration.Components.Containers
{
    [DataContract]
    [DefaultEntityComponentProcessor(typeof(ContainerProcessor), ExecutionMode = ExecutionMode.Runtime)]
    [ComponentCategory("Bepu - Containers")]
    public class StaticMeshContainerComponent : StaticContainerComponent
    {

        private float _mass = 1f;
        private bool _closed = true;

        public float Mass
        {
            get => _mass;
            set
            {
                _mass = value;
                if (ContainerData?.Exist == true)
                    ContainerData.BuildOrUpdateContainer();
            }
        }
        public bool Closed
        {
            get => _closed;
            set
            {
                _closed = value;
                if (ContainerData?.Exist == true)
                    ContainerData.BuildOrUpdateContainer();
            }
        }


        public ModelComponent? ModelData { get; set; }

    }
}