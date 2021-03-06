//-----------------------------------------------------------------------
// <copyright file="OperationProcessorCollection.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/NSwag/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Collections.ObjectModel;
using System.Linq;
using NSwag.SwaggerGeneration.Processors;

namespace NSwag.SwaggerGeneration.WebApi
{
    /// <summary>A collection of operation processors.</summary>
    public class OperationProcessorCollection : Collection<IOperationProcessor>
    {
        /// <summary>Gets an operation processor of the specified type.</summary>
        /// <typeparam name="T">The operation processor type.</typeparam>
        /// <returns>The operation processor.</returns>
        public T Get<T>()
        {
            return (T)this.First(p => p is T);
        }
    }
}