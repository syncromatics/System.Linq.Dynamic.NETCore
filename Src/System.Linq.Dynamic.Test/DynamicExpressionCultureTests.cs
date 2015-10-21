﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Globalization;

namespace System.Linq.Dynamic.Test
{
    [TestClass]
    public class DynamicExpressionCultureTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-PT");
        }

        [TestMethod]
        public void Parse_DoubleLiteral_ReturnsDoubleExpression()
        {
            var expression = DynamicExpression.Parse(typeof(double), "1.0");
            Assert.AreEqual(typeof(double), expression.Type);
        }

        [TestMethod]
        public void Parse_FloatLiteral_ReturnsFloatExpression()
        {
            var expression = DynamicExpression.Parse(typeof(float), "1.0f");
            Assert.AreEqual(typeof(float), expression.Type);
        }
    }
}
