﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calamari.Kubernetes
{
    public static class SpecialVariables
    {
        public const string ClusterUrl = "Octopus.Action.Kubernetes.ClusterUrl";
        public const string Namespace = "Octopus.Action.Kubernetes.Namespace";
        public const string SkipTlsVerification = "Octopus.Action.Kubernetes.SkipTlsVerification";
    }
}
