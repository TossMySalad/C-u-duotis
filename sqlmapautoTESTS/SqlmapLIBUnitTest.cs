using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using sqlmapautoLIB;

namespace sqlmapautoTESTS
{
    [TestClass]
    public class SqlmapLIBUnitTest
    {
        [TestMethod]
        public void TestGetOptions()
        {
            string mockString = "{\"success\": true,\"options\": { \"direct\": null, \"url\": null, \"logFile\": null}}";
            Dictionary<string, object> expectedResult = new Dictionary<string, object>() {
                                                                                            { "direct", null },
                                                                                            { "url", null },
                                                                                            { "logFile", null}
                                                                                          };
            Dictionary<string, object> realResult;

            var mock = new Mock<ISqlmapSession>();
            mock.Setup(x => x.ExecuteGet(It.IsAny<string>())).Returns(mockString);

            using(SqlmapManager mgr = new SqlmapManager(mock.Object))
                realResult = mgr.GetOptions("url");

            string expected = JsonConvert.SerializeObject(expectedResult);
            string real = JsonConvert.SerializeObject(realResult);
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void TestGetScanStatus()
        {
            string mockString = "{\"success\": true, \"status\": \"running\", \"returncode\": null}";
            SqlmapStatus realStatus;
            SqlmapStatus expectedStatus = new SqlmapStatus();
            expectedStatus.Status = "running";

            var mock = new Mock<ISqlmapSession>();
            mock.Setup(x => x.ExecuteGet(It.IsAny<string>())).Returns(mockString);

            using (SqlmapManager mgr = new SqlmapManager(mock.Object))
                realStatus = mgr.GetScanStatus("url");

            string expected = JsonConvert.SerializeObject(expectedStatus);
            string real = JsonConvert.SerializeObject(realStatus);
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void TestGetLog()
        {
            string mockString = "{\"success\": true, \"log\": [ { \"time\": \"22:06:06\", \"level\": \"INFO\", \"message\": \"the back-end DBMS is MySQL\" }, { \"time\": \"22:06:07\", \"level\": \"INFO\", \"message\": \"fetched data logged to text files under 'Foo'\" } ] }";
            List<SqlmapLogItem> realLogItems;
            List<SqlmapLogItem> expectedLogItems = new List<SqlmapLogItem>();
            SqlmapLogItem i1 = new SqlmapLogItem();
            SqlmapLogItem i2 = new SqlmapLogItem();
            i1.Message = "the back-end DBMS is MySQL";
            i1.Level = "INFO";
            i1.Time = "22:06:06";
            i2.Message = "fetched data logged to text files under 'Foo'";
            i2.Level = "INFO";
            i2.Time = "22:06:07";
            expectedLogItems.Add(i1);
            expectedLogItems.Add(i2);

            var mock = new Mock<ISqlmapSession>();
            mock.Setup(x => x.ExecuteGet(It.IsAny<string>())).Returns(mockString);

            using (SqlmapManager mgr = new SqlmapManager(mock.Object))
                realLogItems = mgr.GetLog("url");

            string expected = JsonConvert.SerializeObject(expectedLogItems);
            string real = JsonConvert.SerializeObject(realLogItems);
            Assert.AreEqual(expected, real);
        }
    }
}
