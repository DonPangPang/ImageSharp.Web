// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp.Web.Commands;

namespace SixLabors.ImageSharp.Web.Caching
{
    /// <summary>
    /// Creates a case insensitive cache key based on the request host, path and commands.
    /// </summary>
    public class UriAbsoluteLowerInvariantCacheKey : ICacheKey
    {
        /// <inheritdoc/>
        public string Create(HttpContext context, CommandCollection commands)
            => CacheKeyHelper.BuildAbsoluteKey(CacheKeyHelper.CaseHandling.LowerInvariant, context.Request.Host, context.Request.PathBase, context.Request.Path, QueryString.Create(commands));
    }
}
