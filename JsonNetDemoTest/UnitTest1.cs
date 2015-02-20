using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MountainWind.JsonNetDemo;
using System.Collections.Generic;

namespace JsonNetDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WriteObjectToFile()
        {
            var obj = new JsonObject();

            Util.SaveToFile<JsonObject>("JsonTest.txt", obj);

        }

        [TestMethod]
        public void ReadObjectFromFile()
        {
            var obj = Util.RestoreFromFile<JsonObject>("JsonTest.txt");

            Assert.AreEqual(obj.Age, 52);
        }

        [TestMethod]
        public void WriteObjectCollectionToFile()
        {
            var objs = new List<JsonObject>();
            objs.Add(new JsonObject());
            objs.Add(new JsonObject());

            Util.SaveToFile<List<JsonObject>>("JsonListText", objs);

        }

        [TestMethod]
        public void ReadObjectCollectionFromFile()
        {
            var objs = Util.RestoreFromFile<List<JsonObject>>("JsonListText");

            Assert.AreEqual(objs.Count, 2);
        }
    }
}
