using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Timer = System.Timers.Timer;

namespace DirectDebitApi.Helpers
{
    public class BlacklistedTokenCache : IDistributedCache
    {
        private readonly Dictionary<string, string> blacklistedTokens;
        private readonly Dictionary<string, Timer> timers;
        private const int MAX_SIZE = 10000;
        private const int TRIM_SIZE = 1000;

        public BlacklistedTokenCache()
        {
            // define list type into a dictionary
            blacklistedTokens = new Dictionary<string, string>();
            // define expiration timer
            timers = new Dictionary<string, Timer>();
        }

        public int SpaceLeft { get => MAX_SIZE - blacklistedTokens.Count; }

        public Task<byte[]> GetAsync(string key, CancellationToken token = default)
        {
            // check if token exists in the blacklist
            bool found = blacklistedTokens.TryGetValue(key, out string value);
            // return result of token search as a byte array
            byte[] result = found ? Encoding.ASCII.GetBytes(value) : null;

            return Task.FromResult(result);
        }

        public Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default)
        {
            // check if blacklist contains they token key
            if (blacklistedTokens.ContainsKey(key))
                return Task.CompletedTask;

            EnsureSize();
            // convert token value from byte array to string
            string textValue = Encoding.ASCII.GetString(value);
            // add to blacklist
            blacklistedTokens.Add(key, textValue);
            // check the token expiry
            var timespan = options?.AbsoluteExpirationRelativeToNow ?? TimeSpan.FromMinutes(JwtUtil.EXPIRY_IN_MINUTES);
            // set expiry time in the dictionary
            SetEvictionTimeout(key, timespan);

            return Task.CompletedTask;
        }

        private void EnsureSize()
        {
            // check the size of the token key
            int size = blacklistedTokens.Keys.Count;
            if (size < MAX_SIZE)
                return;

            for (int i = 0; i < TRIM_SIZE; i++)
            {
                string key = blacklistedTokens.Keys.ElementAt(i);
                EvictCacheKey(key);
            }
        }

        private void SetEvictionTimeout(string key, TimeSpan timespan)
        {
            // set token timeout and add to dictionary
            var timer = new Timer(timespan.TotalMilliseconds);
            timers.Add(key, timer);

            timer.Elapsed += (sender, e) => EvictCacheKey(key);

            timer.Start();
        }

        private void EvictCacheKey(string key)
        {
            // remove the token key from the blacklist
            blacklistedTokens.Remove(key);

            var timer = timers[key];
            timer.Stop();
            timer.Dispose();
            timers.Remove(key);
        }

        public void BlacklistToken(string key, string value)
        {
            // add the token and key to the blacklist
            blacklistedTokens.Add(key, value);
        }

        public byte[] Get(string key) => throw new NotImplementedException();
        public void Refresh(string key) => throw new NotImplementedException();
        public Task RefreshAsync(string key, CancellationToken token = default) => throw new NotImplementedException();
        public void Remove(string key) => throw new NotImplementedException();
        public Task RemoveAsync(string key, CancellationToken token = default) => throw new NotImplementedException();
        public void Set(string key, byte[] value, DistributedCacheEntryOptions options) => throw new NotImplementedException();
    }
}
