using System;

namespace SimpleLoginAuthorization.Common
{
    /// <summary>
    /// Cache Manager
    /// </summary>
    public interface ICacheManager
    {
        TResult Get<TKey, TResult>(TKey key, Func<AcquireContext<TKey>, TResult> acquire);
        ICache<TKey, TResult> GetCache<TKey, TResult>();
    }

    public class DefaultCacheManager : ICacheManager
    {

        private readonly static ICacheContextAccessor _cacheContextAccessor = new DefaultCacheContextAccessor();
        private readonly static ICacheHolder _cacheHolder = new DefaultCacheHolder(_cacheContextAccessor);

        //public DefaultCacheManager(Type component, ICacheHolder cacheHolder)
        //{
        //    _component = component;
        //    _cacheHolder = cacheHolder;
        //}

        public ICache<TKey, TResult> GetCache<TKey, TResult>()
        {
            return _cacheHolder.GetCache<TKey, TResult>();
        }

        public TResult Get<TKey, TResult>(TKey key, Func<AcquireContext<TKey>, TResult> acquire)
        {
            return GetCache<TKey, TResult>().Get(key, acquire);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class CacheManager
    {

        private static readonly ICacheManager _CacheManager = new DefaultCacheManager();
        private static readonly IRelativeClockMonitor _ClockMonitor = new RelativeMonitorClock();
        private static readonly ISignals _Signals = new Signals();

        public static ICacheManager Container
        {
            get { return _CacheManager; }
        }
        public static IAbsoluteClockMonitor AbsoluteClockMonitor
        {
            get { throw new NotImplementedException(); }
        }
        public static IRelativeClockMonitor RelativeClockMonitor
        {
            get { return _ClockMonitor; }
        }
        public static ISignals Signals
        {
            get { return _Signals; }
        }
    }
}
