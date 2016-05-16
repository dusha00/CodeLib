using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Adapter;
using BuilderPattern;
using Composite;
using Decorator;
using FactoryMethod.MySqlFactory;
using FactoryMethod.OracleFactory;
using FactoryMethod.SqlFactory;
using Prototype;
using SimpleFactory;

namespace ConsoleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式
            //SinglePattern.SinglePattern.singlePattern.Console("12312312");
            //Console.Read();

            //简单工厂模式 
            //var factory = new DataBaseFactory();
            ////var connection = factory.GetConnection("mysql");
            ////var connection = factory.GetConnection("sql");
            //var connection = factory.GetConnection("oracle");
            //connection.ConnectToDataBase();
            //Console.Read();

            //工厂模式
            //var factory = new SqlFactory();
            //var connection = factory.GetConnection();
            //connection.ConnectToDataBase();
            //Console.Read();

            //var factory = new OracleFactory();
            //var connection = factory.GetConnection();
            //connection.ConnectToDataBase();
            //Console.Read();
            
            //抽象工厂
            //var factory=new AbstractFactory.MySqlFactory.MysqlFactory();
            //var connection = factory.GetConnection();
            //var cmd = factory.GetCommond();
            //var result = factory.GetResult();
            //connection.ConnectToDataBase();
            //cmd.GetBaseCommond();
            //result.GetBaseResult();
            //Console.Read();/

            //原型模式
            //var bao=new BaoMa();
            //bao.BuilderSeat();
            //bao.BuilderWheel();
            //var car=bao.GetCar();
            //car.Show();
            //Console.Read();
            //Console.Read();

            //原型模式 
            //var proto=new ConcretePrototype1("190");
            //var cloneProto = proto.Clone();
            //Console.WriteLine(cloneProto.Id);
            //Console.Read();

            ////适配器模式
            //var usbInterface = new PS2ToUSBAdapter();
            //usbInterface.USBReadMsg();
            //Console.ReadKey();

            ////装饰者模式
            //Tank tank=new XiNiuTank();
            //tank=new Missile(tank);
            //tank.Show();
            //tank=new Cannon(tank);
            //tank.Show();
            //Console.ReadKey();

            ////组合模式
            //ComplexGraphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            //complexGraphics.Add(new Line("线段A"));
            //ComplexGraphics CompositeCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
            //CompositeCG.Add(new Circle("圆"));
            //CompositeCG.Add(new Circle("线段B"));
            //complexGraphics.Add(CompositeCG);
            //Line l = new Line("线段C");
            //complexGraphics.Add(l);

            //// 显示复杂图形的画法
            //Console.WriteLine("复杂图形的绘制如下：");
            //Console.WriteLine("---------------------");
            //complexGraphics.Draw();
            //Console.WriteLine("复杂图形绘制完成");
            //Console.WriteLine("---------------------");
            //Console.WriteLine();

            //// 移除一个组件再显示复杂图形的画法
            //complexGraphics.Remove(l);
            //Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
            //Console.WriteLine("---------------------");
            //complexGraphics.Draw();
            //Console.WriteLine("复杂图形绘制完成");
            //Console.WriteLine("---------------------");
            //Console.Read();


        }
    }
}
