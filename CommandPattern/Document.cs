using System;

namespace CommandPattern
{
	/*
	 在客户程序中，不再依赖于Document的Display()，Undo()，Redo()命令，通过Command对这些命令进行了封装，使用它的一个关键就是抽象的Command类，它定义了一个操作的接口。同时我们也可以看到，本来这三个命令仅仅是三个方法而已，但是通过Command模式却把它们提到了类的层面，这其实是违背了面向对象的原则，但它却优雅的解决了分离命令的请求者和命令的执行者的问题，在使用Command模式的时候，一定要判断好使用它的时机。
	 */
	public class Document
	{
		/// <summary>

		/// 显示操作

		/// </summary>

		public void Display()
		{
			Console.WriteLine("Display");
		}

		/// <summary>

		/// 撤销操作

		/// </summary>

		public void Undo()
		{
			Console.WriteLine("Undo");
		}

		/// <summary>

		/// 恢复操作

		/// </summary>

		public void Redo()
		{
			Console.WriteLine("Redo");
		} 
	}
}