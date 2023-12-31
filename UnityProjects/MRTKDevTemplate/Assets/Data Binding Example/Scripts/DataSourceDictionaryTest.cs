﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// Disable "missing XML comment" warning for samples. While nice to have, this XML documentation is not required for samples.
#pragma warning disable CS1591

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Data
{
    /// <summary>
    /// Simple test data source that programmatically changes variables in a data source.
    /// </summary>
    /// <remarks>
    /// Using a simple key-value store, it's possible to separate data from view
    /// to simplify the integration of generic view prefabs that are populated from
    /// external information.
    /// </remarks>
    [AddComponentMenu("MRTK/Examples/Data Binding/Data Source Dictionary Test")]
    public class DataSourceDictionaryTest : DataSourceTest
    {
        public override IDataSource AllocateDataSource()
        {
            return new DataSourceDictionary();
        }
    }
}
#pragma warning restore CS1591