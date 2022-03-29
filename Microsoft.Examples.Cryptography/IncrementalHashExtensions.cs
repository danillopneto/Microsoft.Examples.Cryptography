// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
//   Shared under the terms of the Microsoft Public License,
//   https://opensource.org/licenses/MS-PL
//
// ==--==

using System.Security.Cryptography;

namespace Microsoft.Examples.Cryptography
{
    /// <summary>
    /// Provides extension methods to make HashAlgorithm look like .NET Core's
    /// IncrementalHash
    /// </summary>
    internal static class IncrementalHashExtensions
    {
        public static void AppendData(this HashAlgorithm hash, byte[] data) => hash.TransformBlock(data, 0, data.Length, null, 0);

        public static void AppendData(this HashAlgorithm hash,
                                      byte[] data,
                                      int offset,
                                      int length) => hash.TransformBlock(data, offset, length, null, 0);

        public static byte[] GetHashAndReset(this HashAlgorithm hash)
        {
            hash.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
            return hash.Hash;
        }
    }
}
