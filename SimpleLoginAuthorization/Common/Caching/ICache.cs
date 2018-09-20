﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLoginAuthorization.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface ICache<TKey, TResult>
    {
        TResult Get(TKey key, Func<AcquireContext<TKey>, TResult> acquire);
    }

    public class Cache<TKey, TResult> : ICache<TKey, TResult>
    {
        private readonly ICacheContextAccessor _cacheContextAccessor;
        private readonly ConcurrentDictionary<TKey, CacheEntry> _entries;

        public Cache(ICacheContextAccessor cacheContextAccessor)
        {
            _cacheContextAccessor = cacheContextAccessor;
            _entries = new ConcurrentDictionary<TKey, CacheEntry>();
        }

        public TResult Get(TKey key, Func<AcquireContext<TKey>, TResult> acquire)
        {
            CacheEntry entry = _entries.AddOrUpdate(key,
                // "Add"
                k => AddEntry(k, acquire),
                // "Update"
                (k, currentEntry) => UpdateEntry(currentEntry, k, acquire));

            return entry.Result;
        }

        private CacheEntry AddEntry(TKey k, Func<AcquireContext<TKey>, TResult> acquire)
        {
            CacheEntry entry = CreateEntry(k, acquire);
            PropagateTokens(entry);
            return entry;
        }

        private CacheEntry UpdateEntry(CacheEntry currentEntry, TKey k, Func<AcquireContext<TKey>, TResult> acquire)
        {
            CacheEntry entry = (currentEntry.Tokens.Any(t => !t.IsCurrent)) ? CreateEntry(k, acquire) : currentEntry;
            PropagateTokens(entry);
            return entry;
        }
        //传播令牌
        private void PropagateTokens(CacheEntry entry)
        {
            if (_cacheContextAccessor.Current != null)
            {
                foreach (IVolatileToken token in entry.Tokens)
                    _cacheContextAccessor.Current.Monitor(token);
            }
        }


        private CacheEntry CreateEntry(TKey k, Func<AcquireContext<TKey>, TResult> acquire)
        {
            CacheEntry entry = new CacheEntry();
            AcquireContext<TKey> context = new AcquireContext<TKey>(k, entry.AddToken);

            IAcquireContext parentContext = null;
            try
            {
                // Push context
                parentContext = _cacheContextAccessor.Current;
                _cacheContextAccessor.Current = context;

                entry.Result = acquire(context);
            }
            finally
            {
                // Pop context
                _cacheContextAccessor.Current = parentContext;
            }
            entry.CompactTokens();
            return entry;
        }

        private class CacheEntry
        {
            private IList<IVolatileToken> _tokens;
            public TResult Result { get; set; }
            /// <summary>
            /// 令牌
            /// </summary>
            public IEnumerable<IVolatileToken> Tokens
            {
                get
                {
                    return _tokens ?? Enumerable.Empty<IVolatileToken>();
                }
            }

            public void AddToken(IVolatileToken volatileToken)
            {
                if (_tokens == null)
                {
                    _tokens = new List<IVolatileToken>();
                }

                _tokens.Add(volatileToken);
            }

            public void CompactTokens()
            {
                if (_tokens != null)
                    _tokens = _tokens.Distinct().ToArray();
            }
        }
    }

}
