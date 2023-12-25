using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Net;
using System.Security.Principal;
using Xunit;
using Xunit.Sdk;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
             Algorithms.GetFactorial(4);
        }

        [Fact]
        public void CanFormatSeparators()
        {
            string[] lstitems = { "piyush", "pari" };
            Algorithms.FormatSeparators(lstitems);
        }
    }

    
}

