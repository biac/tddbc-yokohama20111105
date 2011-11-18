using System;
using NUnit.Framework;

namespace TDDBC横浜 {
	[TestFixture()]
	public class 野球選手Tests {
		[TestCase(5, 3, 0, 0.0)]
		[TestCase(5, 3, 3, 1.0)]
		[TestCase(5, 9999, 2345, 0.235)]	//0.23452345…が四捨五入で0.235になる
		public void Calc打率Test01(int 打席数, int 打数, int 安打数, decimal 期待値) {
			野球選手 p = new 野球選手();
			decimal 打率 = p.Calc打率(打席数, 打数, 安打数).Value;	// ".Value"を追加
			Assert.AreEqual(期待値, 打率);
		}

		[TestCase(5, 0, 0)]
		public void Calc打率Test02_打数0なら0(int 打席数, int 打数, int 安打数) {
			野球選手 p = new 野球選手();
			Assert.AreEqual(0.0m, p.Calc打率(打席数, 打数, 安打数));
		}

		[TestCase(0, 0, 0, null)]
		public void Calc打率Test03_打席数0ならnull(int 打席数, int 打数, int 安打数, decimal? 期待値) {
			野球選手 p = new 野球選手();
			Assert.AreEqual(期待値, p.Calc打率(打席数, 打数, 安打数));
		}

	}
}
