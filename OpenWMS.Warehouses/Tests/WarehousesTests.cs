using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using OpenWMS.Warehouses.Models;

namespace OpenWMS.Warehouses.Tests
{

    [TestFixture]
    public class WarehousesTests
    {
        [Test]
        public void Posso_Controlar_Um_Deposito()
        {
            var warehouse = Warehouse.
                New();

            warehouse.Should().NotBeNull();
        }
    }
}
