using System.Collections.Generic;

namespace CineastUnityInterface.CineastAPI {
    public class FilterEngine {


        private Queue<FilterStrategy> strategies = new Queue<FilterStrategy>();

        public void AddFilterStrategy(FilterStrategy strategy) {
            strategies.Enqueue(strategy);
        }

        public void Reset() {
            strategies.Clear();
        }

        public List<MultimediaObject> ApplyFilters(List<MultimediaObject> list) {
            
            List<MultimediaObject> working = new List<MultimediaObject>(list);
            foreach (FilterStrategy strategy in strategies) {
                working = strategy.applyFilter(working);
            }

            return working;
        }

        public int GetFilterCount() {
            return strategies.Count;
        }
    }
}