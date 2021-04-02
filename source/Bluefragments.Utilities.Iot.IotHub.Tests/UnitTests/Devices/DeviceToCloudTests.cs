﻿using System;
using System.Collections.Generic;
using System.Text;
using Bluefragments.Iot.Devices;
using Xunit;

namespace Dpx.Iot.Infrastructure.Tests.UnitTests.Devices
{
    public class DeviceToCloudTests
    {
        [Fact]
        public void CreateSimulatedDevice_NullDevice_ThrowsInvalidOperationException()
        {
            var devToCloud = new DeviceToCloud();
            Assert.Throws<ArgumentNullException>(() => devToCloud.CreateSimulatedDevice(null!));
        }
    }
}
