//using System;
//using NUnit.Framework;
//using System.Drawing;
//using API;
//using System.Collections.Generic;

//namespace Tests
//{
//    [TestFixture]
//    public class NUnitTests
//    {
//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "{ Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } }")]
//        public void figureToJsonTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        {
//            Figure f = new Figure(20, 10, 210, 300, "Black", 2, "Rectangle");
//            string act = f.ToJSON();
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "{ Figures: { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } }, { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } } }")]
//        //public void figuresToJsonTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        //{
//        //    Figure f = new Figure(20, 10, 210, 300, "Black", 2, "Rectangle");
//        //    List<Figure> figs = new List<Figure>();
//        //    figs.Add(f);
//        //    figs.Add(f);
//        //    DS_JSON ds = new DS_JSON();
//        //    string act = ds.figsToJson(figs);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "{ Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle }")]
//        public void figureFromJsonTest(int x, int y, int w, int h, string c, int lw, string type, string json)
//        {
//            Figure exp = new Figure(x, y, w, h, c, lw, type);
//            Figure act = new Figure(json, "JSON");
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "{ Figures: { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } }, { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } } }")]
//        //public void figsToJson(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    List<Figure> figs = new List<Figure>();
//        //    figs.Add(f);
//        //    figs.Add(f);
//        //    DS_JSON ds = new DS_JSON();
//        //    string act = ds.figsToJson(figs);
//        //    Assert.AreEqual(exp, act);
//        //}

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "{ Figures: { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } }, { Figure: { x: 20, y: 10, w: 210, h: 300, c: Black, lw: 2, type: Rectangle } } }")]
//        //public void figsFromJson(int x, int y, int w, int h, string c, int lw, string type, string json)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    DS_JSON ds = new DS_JSON();
//        //    List<Figure> exp = new List<Figure>();
//        //    exp.Add(f);
//        //    exp.Add(f);
//        //    List<Figure> act = ds.figsFromJson(json);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "<Figure>\n\t<x>20</x>\n\t<y>10</y>\n\t<w>210</w>\n\t<h>300</h>\n\t<c>Black</c>\n\t<lw>2</lw>\n\t<type>Rectangle</type>\n</Figure>")]
//        public void figureToXMLTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        {
//            Figure f = new Figure(20, 10, 210, 300, "Black", 2, "Rectangle");
//            string act = f.ToXML();
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "<Figures>\n\t<Figure>\n\t\t<x>20</x>\n\t\t<y>10</y>\n\t\t<w>210</w>\n\t\t<h>300</h>\n\t\t<c>Black</c>\n\t\t<lw>2</lw>\n\t\t<type>Rectangle</type>\n\t</Figure>\n</Figures>")]
//        //public void figsToXMLTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    List<Figure> figs = new List<Figure>();
//        //    figs.Add(f);
//        //    DS_XML ds = new DS_XML();
//        //    string act = ds.figsToXML(figs);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "<Figure>\n\t<x>20</x>\n\t<y>10</y>\n\t<w>210</w>\n\t<h>300</h>\n\t<c>Black</c>\n\t<lw>2</lw>\n\t<type>Rectangle</type>\n</Figure>")]
//        public void figureFromXMLTest(int x, int y, int w, int h, string c, int lw, string type, string xml)
//        {
//            Figure exp = new Figure(x, y, w, h, c, lw, type);
//            Figure act = new Figure(xml, "XML");
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "<Figures>\n\t<Figure>\n\t\t<x>20</x>\n\t\t<y>10</y>\n\t\t<w>210</w>\n\t\t<h>300</h>\n\t\t<c>Black</c>\n\t\t<lw>2</lw>\n\t\t<type>Rectangle</type>\n\t</Figure>\n\t<Figure>\n\t\t<x>20</x>\n\t\t<y>10</y>\n\t\t<w>210</w>\n\t\t<h>300</h>\n\t\t<c>Black</c>\n\t\t<lw>2</lw>\n\t\t<type>Rectangle</type>\n\t</Figure>\n</Figures>")]
//        //public void figsFromXMLTest(int x, int y, int w, int h, string c, int lw, string type, string xml)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    DS_XML ds = new DS_XML();
//        //    List<Figure> exp = new List<Figure>();
//        //    exp.Add(f);
//        //    exp.Add(f);
//        //    List<Figure> act = ds.figsFromXML(xml);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x,y,w,h,c,lw,type\n20,10,210,300,Black,2,Rectangle")]
//        public void figToCSVTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        {
//            Figure f = new Figure(20, 10, 210, 300, "Black", 2, "Rectangle");
//            string act = f.ToCSV();
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x,y,w,h,c,lw,type\n20,10,210,300,Black,2,Rectangle\n20,10,210,300,Black,2,Rectangle")]
//        //public void figsToCSVTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    List<Figure> figs = new List<Figure>();
//        //    figs.Add(f);
//        //    figs.Add(f);
//        //    DS_CSV ds = new DS_CSV();
//        //    string act = ds.figsToCSV(figs);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x,y,w,h,c,lw,type\n20,10,210,300,Black,2,Rectangle")]
//        public void figureFromCSVTest(int x, int y, int w, int h, string c, int lw, string type, string csv)
//        {
//            Figure exp = new Figure(x, y, w, h, c, lw, type);
//            Figure act = new Figure(csv, "CSV");
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x,y,w,h,c,lw,type\n20,10,210,300,Black,2,Rectangle\n20,10,210,300,Black,2,Rectangle")]
//        //public void figsFromCSVTest(int x, int y, int w, int h, string c, int lw, string type, string csv)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    DS_CSV ds = new DS_CSV();
//        //    List<Figure> exp = new List<Figure>();
//        //    exp.Add(f);
//        //    exp.Add(f);
//        //    List<Figure> act = ds.figsFromCSV(csv);
//        //    Assert.AreEqual(exp, act);
//        //}

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x: 20\ny: 10\nw: 210\nh: 300\nc: Black\nlw: 2\ntype: Rectangle")]
//        public void figToYamlTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        {
//            Figure f = new Figure(20, 10, 210, 300, "Black", 2, "Rectangle");
//            string act = f.ToYaml();
//            Assert.AreEqual(exp, act);
//        }

//        [Test]
//        [TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "x: 20\ny: 10\nw: 210\nh: 300\nc: Black\nlw: 2\ntype: Rectangle")]
//        public void figureFromYamlTest(int x, int y, int w, int h, string c, int lw, string type, string yaml)
//        {
//            Figure exp = new Figure(x, y, w, h, c, lw, type);
//            Figure act = new Figure(yaml, "Yaml");
//            Assert.AreEqual(exp, act);
//        }

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "figures:\n\t- x: 20\n\t  y: 10\n\t  w: 210\n\t  h: 300\n\t  c: Black\n\t  lw: 2\n\t  type: Rectangle\n\t- x: 20\n\t  y: 10\n\t  w: 210\n\t  h: 300\n\t  c: Black\n\t  lw: 2\n\t  type: Rectangle")]
//        //public void figsToYamlTest(int x, int y, int w, int h, string c, int lw, string type, string exp)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    List<Figure> figs = new List<Figure>();
//        //    figs.Add(f);
//        //    figs.Add(f);
//        //    DS_Yaml ds = new DS_Yaml();
//        //    string act = ds.figsToYaml(figs);
//        //    Assert.AreEqual(exp, act);
//        //}

//        //[Test]
//        //[TestCase(20, 10, 210, 300, "Black", 2, "Rectangle", "figures:\n\t- x: 20\n\t  y: 10\n\t  w: 210\n\t  h: 300\n\t  c: Black\n\t  lw: 2\n\t  type: Rectangle\n\t- x: 20\n\t  y: 10\n\t  w: 210\n\t  h: 300\n\t  c: Black\n\t  lw: 2\n\t  type: Rectangle")]
//        //public void figsFromYamlTest(int x, int y, int w, int h, string c, int lw, string type, string yaml)
//        //{
//        //    Figure f = new Figure(x, y, w, h, c, lw, type);
//        //    DS_Yaml ds = new DS_Yaml();
//        //    List<Figure> exp = new List<Figure>();
//        //    exp.Add(f);
//        //    exp.Add(f);
//        //    List<Figure> act = ds.figsFromYaml(yaml);
//        //    Assert.AreEqual(exp, act);
//        //}
//    }
//}