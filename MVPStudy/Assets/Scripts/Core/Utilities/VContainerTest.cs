using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core.Utilities
{
    public sealed class Logger
    {
        public void Log(string message) => Debug.Log("[Logger]" + message);
    }

    public sealed class Calulator
    {
        public int Add(int a, int b) => a + b;
    }

    public sealed class HogeClass
    {
        private readonly Logger logger;
        private readonly Calulator calulator;

        [Inject]
        public HogeClass(Logger logger, Calulator calulator)
        {
            this.logger = logger;
            this.calulator = calulator;
        }

        public void LoggerTest()
        {
            logger.Log("LoggerTest");
        }

        public void CalulatorTest(int a, int b)
        {
            int result = calulator.Add(a, b);
            logger.Log($"{a} + {b} = {result}");
        }
    }
}