﻿using System;
using System.Diagnostics.Contracts;
using System.Net.Http;

namespace Crichton.Client
{
    [ContractClassFor(typeof(ITransitionRequestFilter))]
    internal abstract class ITransitionRequestFilterContracts : ITransitionRequestFilter
    {
        public void Execute(HttpRequestMessage httpRequestMessage)
        {
            Contract.Requires<ArgumentNullException>(httpRequestMessage != null, "httpRequestMessage must not be null.");
        }
    }
}
