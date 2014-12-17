using System;
using PlainElastic.Net.Utils;

namespace PlainElastic.Net.Queries
{
    /// <summary>
    /// An aggregation can be seen as a unit-of-work that builds analytic information over a set of documents.
	/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations.html
    /// </summary>
	public class Aggregations<T> : QueryBase<Aggregations<T>>
    {

        /// <summary>
        /// Allows to specify field aggregations that return the N most frequent terms
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-terms-aggregation.html
        /// </summary>
		public Aggregations<T> Terms(Func<TermsAggregation<T>, TermsAggregation<T>> termsAggregation)
        {
			RegisterJsonPartExpression(termsAggregation);
            return this;
        }

        /// <summary>
		/// Defines a single bucket of all the documents in the current document set context that match a specified filter. Often this will be used to narrow down the current aggregation context to a specific set of documents.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-filter-aggregation.html
        /// </summary>
		public Aggregations<T> Filter(Func<FilterAggregation<T>, FilterAggregation<T>> filterAggregation)
        {
			RegisterJsonPartExpression(filterAggregation);
            return this;
        }

        /// <summary>
		/// A multi-bucket value source based aggregation that enables the user to define a set of ranges - each representing a bucket. During the aggregation process, the values extracted from each document will be checked against each bucket range and "bucket" the relevant/matching document. Note that this aggregration includes the from value and excludes the to value for each range.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-range-aggregation.html
        /// </summary>
		public Aggregations<T> Range(Func<RangeAggregation<T>, RangeAggregation<T>> rangeAggregation)
        {
			RegisterJsonPartExpression(rangeAggregation);
            return this;
        }

        /// <summary>
        /// A multi-value metrics aggregation that computes stats over numeric values extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// The stats that are returned consist of: min, max, sum, count and avg.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-stats-aggregation.html
        /// </summary>
		public Aggregations<T> Stats(Func<StatsAggregation<T>, StatsAggregation<T>> stats)
        {
            RegisterJsonPartExpression(stats);
            return this;
        }

        /// <summary>
        /// A multi-value metrics aggregation that computes stats over numeric values extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// The extended_stats aggregations is an extended version of the stats aggregation, where additional metrics are added such as sum_of_squares, variance and std_deviation.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-extendedstats-aggregation.html
        /// </summary>
		public Aggregations<T> ExtendedStats(Func<ExtendedStatsAggregation<T>, ExtendedStatsAggregation<T>> extendedStats)
        {
			RegisterJsonPartExpression(extendedStats);
            return this;
        }

		/// <summary>
		/// A single-value metrics aggregation that keeps track and returns the minimum value among numeric values extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-min-aggregation.html
		/// </summary>
		public Aggregations<T> Min(Func<MinAggregation<T>, MinAggregation<T>> min)
		{
			RegisterJsonPartExpression(min);
			return this;
		}

		/// <summary>
		/// A single-value metrics aggregation that keeps track and returns the maximum value among the numeric values extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-max-aggregation.html
		/// </summary>
		public Aggregations<T> Max(Func<MaxAggregation<T>, MaxAggregation<T>> max)
		{
			RegisterJsonPartExpression(max);
			return this;
		}

		/// <summary>
		/// A single-value metrics aggregation that sums up numeric values that are extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-sum-aggregation.html
		/// </summary>
		public Aggregations<T> Sum(Func<SumAggregation<T>, SumAggregation<T>> sum)
		{
			RegisterJsonPartExpression(sum);
			return this;
		}

		/// <summary>
		/// A single-value metrics aggregation that computes the average of numeric values that are extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-avg-aggregation.html
		/// </summary>
		public Aggregations<T> Avg(Func<AvgAggregation<T>, AvgAggregation<T>> avg)
		{
			RegisterJsonPartExpression(avg);
			return this;
		}

		/// <summary>
		/// A single-value metrics aggregation that counts the number of values that are extracted from the aggregated documents. These values can be extracted either from specific fields in the documents, or be generated by a provided script. Typically, this aggregator will be used in conjunction with other single-value aggregations. For example, when computing the avg one might be interested in the number of values the average is computed over.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-valuecount-aggregation.html
		/// </summary>
		public Aggregations<T> ValueCount(Func<ValueCountAggregation<T>, ValueCountAggregation<T>> valueCount)
		{
			RegisterJsonPartExpression(valueCount);
			return this;
		}

		/// <summary>
		/// A multi-value metrics aggregation that calculates one or more percentiles over numeric values extracted from the aggregated documents. These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-percentile-aggregation.html
		/// </summary>
		public Aggregations<T> Percentiles(Func<PercentilesAggregation<T>, PercentilesAggregation<T>> percentiles)
		{
			RegisterJsonPartExpression(percentiles);
			return this;
		}

		/// <summary>
		/// A single-value metrics aggregation that calculates an approximate count of distinct values. Values can be extracted either from specific fields in the document or generated by a script.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-cardinality-aggregation.html
		/// </summary>
		public Aggregations<T> Cardinality(Func<CardinalityAggregation<T>, CardinalityAggregation<T>> cardinality)
		{
			RegisterJsonPartExpression(cardinality);
			return this;
		}

		/// <summary>
		/// Defines a single bucket of all the documents within the search execution context. This context is defined by the indices and the document types you�re searching on, but is not influenced by the search query itself.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-global-aggregation.html
		/// </summary>
		public Aggregations<T> Global(Func<GlobalAggregation<T>, GlobalAggregation<T>> global)
		{
			RegisterJsonPartExpression(global);
			return this;
		}

		/// <summary>
		/// A field data based single bucket aggregation, that creates a bucket of all documents in the current document set context that are missing a field value (effectively, missing a field or having the configured NULL value set). This aggregator will often be used in conjunction with other field data bucket aggregators (such as ranges) to return information for all the documents that could not be placed in any of the other buckets due to missing field data values.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-missing-aggregation.html
		/// </summary>
		public Aggregations<T> Missing(Func<MissingAggregation<T>, MissingAggregation<T>> missing)
		{
			RegisterJsonPartExpression(missing);
			return this;
		}

		/// <summary>
		/// A special single bucket aggregation that enables aggregating nested documents.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-nested-aggregation.html
		/// </summary>
		public Aggregations<T> Nested(Func<NestedAggregation<T>, NestedAggregation<T>> nested)
		{
			RegisterJsonPartExpression(nested);
			return this;
		}

        /// <summary>
		/// A multi-bucket values source based aggregation that can be applied on numeric values extracted from the documents. It dynamically builds fixed size (a.k.a. interval) buckets over the values. For example, if the documents have a field that holds a price (numeric), we can configure this aggregation to dynamically build buckets with interval 5 (in case of price it may represent $5). When the aggregation executes, the price field of every document will be evaluated and will be rounded down to its closest bucket - for example, if the price is 32 and the bucket size is 5 then the rounding will yield 30 and thus the document will "fall" into the bucket that is associated withe the key 30.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-histogram-aggregation.html
        /// </summary>
		public Aggregations<T> Histogram(Func<HistogramAggregation<T>, HistogramAggregation<T>> histogramAggregation)
        {
			RegisterJsonPartExpression(histogramAggregation);
            return this;
        }

        /// <summary>
		/// A multi-bucket aggregation similar to the histogram except it can only be applied on date values. Since dates are represented in elasticsearch internally as long values, it is possible to use the normal histogram on dates as well, though accuracy will be compromised. The reason for this is in the fact that time based intervals are not fixed (think of leap years and on the number of days in a month). For this reason, we need a special support for time based data. From a functionality perspective, this histogram supports the same features as the normal histogram. The main difference is that the interval can be specified by date/time expressions.
		/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-bucket-datehistogram-aggregation.html
        /// </summary>
		public Aggregations<T> DateHistogram(Func<DateHistogramAggregation<T>, DateHistogramAggregation<T>> dateHistogramAggregation)
        {
			RegisterJsonPartExpression(dateHistogramAggregation);
            return this;
        }

        protected override bool HasRequiredParts()
        {
            return true;
        }

        protected override string ApplyJsonTemplate(string body)
        {
            return "'aggregations': {{ {0} }}".AltQuoteF(body);
        }
    }
}