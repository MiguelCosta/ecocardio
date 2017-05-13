using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EcoCardio.Domain;
using FluentAssertions;

namespace EcoCadrio.Domain.Tests
{
    [TestClass]
    public class ExameTests
    {
        [TestMethod]
        public void CalcMassaVE_NotHasValues_ShouldReturnNull()
        {
            var exame = new Exame();

            var result = exame.CalcMassaVE();

            result.Should().BeNull();
        }

        [TestMethod]
        public void CalcMassaVE_HasValues_ShouldReturnValue()
        {
            var exame = new Exame
            {
                DiametroVETeleadiastole = 49,
                DiametroSepto = 13,
                DiametroParedePosterior = 11
            };

            var result = exame.CalcMassaVE();

            result.Should().BeApproximately(226, 0.5);
        }

        [TestMethod]
        public void CalcMassaVE_HasValues_ShouldReturnValue_2()
        {
            var exame = new Exame
            {
                DiametroVETeleadiastole = 51,
                DiametroSepto = 10,
                DiametroParedePosterior = 9
            };

            var result = exame.CalcMassaVE();

            result.Should().BeApproximately(175, 0.5);
        }
    }
}
