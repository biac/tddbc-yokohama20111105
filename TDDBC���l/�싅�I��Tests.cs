using System;
using NUnit.Framework;

namespace TDDBC横浜 {
	[TestFixture()]
	public class 野球選手Tests {
		[TestCase(5, 3, 0, 0.0)]
		[TestCase(5, 3, 3, 1.0)]
		public void Calc打率Test01(int 打席数, int 打数, int 安打数, decimal 期待値) {
			野球選手 p = new 野球選手();
			decimal 打率 = p.Calc打率(打席数, 打数, 安打数);
			Assert.AreEqual(期待値, 打率);
		}

		[TestCase(0, 0, 0)]
		public void Calc打率Test02_打率0なら例外(int 打席数, int 打数, int 安打数) {
			野球選手 p = new 野球選手();
			Assert.Throws<DivideByZeroException>(() => p.Calc打率(打席数, 打数, 安打数));
		}
	}
}
