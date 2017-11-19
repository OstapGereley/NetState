using System;
using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Impl.Predicates.Int32;

namespace NetState.Core.Impl.DataGenerators.Int32 {

    [MapTo(typeof(NotZeroInt32Predicate))]
    public class NotZeroInt32DataGenerator : DataGeneratorBase<int> {

        private readonly Random _random;

        public NotZeroInt32DataGenerator() {
            _random = new Random(DateTime.Now.Second);
        }

        public override Task<int> NextTrue() {
            while (true) {
                var randomInt32 = _random.Next(int.MinValue, int.MaxValue);
                if (randomInt32 == 0) continue;

                return Task.FromResult(randomInt32);
            }
        }

        public override Task<int> NextFalse() {
            return Task.FromResult(0);
        }

    }

}