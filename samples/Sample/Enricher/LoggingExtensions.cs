using Serilog.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Enricher
{
    public static class LoggingExtensions
    {
        public static Serilog.LoggerConfiguration WithReleaseNumber(
            this LoggerEnrichmentConfiguration enrich)
        {
            if (enrich == null)
                throw new ArgumentNullException(nameof(enrich));

            return enrich.With<ReleaseNumberEnricher>();
        }
    }
}
