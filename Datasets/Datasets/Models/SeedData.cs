using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Datasets.Data;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Datasets.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatasetsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DatasetsContext>>()))
            {
                // Look for any movies.
                if (context.Dataset.Any())
                {
                    return;   // DB has been seeded
                }

                context.Dataset.AddRange(
                    new Dataset
                    {
                        Name = "Google Cloud Trace 2019 - Cluster A",
                        Filename = "gc2019_a.csv",
                        Keywords = new List<Keyword>(),
                        Url = "gc2019_a.csv"
                    },

                    new Dataset
                    {
                        Name = "Google Cloud Trace 2019 - Cluster B",
                        Filename = "gc2019_b.csv",
                        Keywords = new List<Keyword>(),

                        //Keywords = new String[] { "Cloud Compunting", "Google", "Workload" },
                        Url = "gc2019_b.csv"
                    },

                    new Dataset
                    {
                        Name = "Google Cloud Trace 2019 - Cluster C",
                        Filename = "gc2019_c.csv",
                        Keywords = new List<Keyword>(),
                        Url = "gc2019_c.csv"
                    },

                    new Dataset
                    {
                        Name = "Google Cloud Trace 2019 - Cluster D",
                        Filename = "gc2019_d.csv",
                        Keywords = new List<Keyword>(),
                        Url = "gc2019_d.csv"
                    }
                ); ; ;
                context.SaveChanges();
            }
        }
    }
}