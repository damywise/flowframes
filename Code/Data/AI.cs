﻿using Flowframes.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowframes.Data
{
    public struct AI
    {
        public enum Backend { Pytorch, Ncnn, Tensorflow, Other }
        public Backend backend;
        public string aiName;
        public string aiNameShort;
        public string friendlyName;
        public string description;
        public string pkgDir;
        public enum FactorSupport { Fixed, AnyPowerOfTwo, AnyInteger, AnyFloat }
        public FactorSupport factorSupport;
        public int[] supportedFactors;

        public AI(Backend backend, string aiName, string friendlyName, string desc, string pkgDir, FactorSupport factorSupport = FactorSupport.Fixed, int[] factors = null)
        {
            this.backend = backend;
            this.aiName = aiName;
            this.aiNameShort = aiName.Split(' ')[0].Split('_')[0];
            this.friendlyName = friendlyName;
            this.description = desc;
            this.pkgDir = pkgDir;
            this.supportedFactors = factors;
            this.factorSupport = factorSupport;
        }
    }
}
