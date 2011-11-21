using System;
using NUnit.Framework;

namespace Tddbc横浜 {
	[TestFixture()]
	[CLSCompliant(false)]
	public class 野球選手Tests {
		[TestCase(5, 3, 0, 0.0)]
		[TestCase(5, 3, 3, 1.0)]
		[TestCase(5, 9999, 2345, 0.235)]	//0.23452345…が四捨五入で0.235になる
		[TestCase(5, 0, 0, 0.0)]
		public void Calc打率Test01(int 打席数, int 打数, int 安打数, decimal 期待値) {
			野球選手 p = new 野球選手();
			decimal 打率 = p.Calc打率(打席数, 打数, 安打数).Value;
			Assert.AreEqual(期待値, 打率);
		}

		[TestCase(0, 0, 0, null)]
		public void Calc打率Test02_打席数0ならNull(int 打席数, int 打数, int 安打数, decimal? 期待値) {
			野球選手 p = new 野球選手();
			Assert.AreEqual(期待値, p.Calc打率(打席数, 打数, 安打数));
		}

		[TestCase(5, 4, 1, ".250")]
		[TestCase(5, 4, 4, "1.00")]
		[TestCase(0, 0, 0, "----")]
		[TestCase(5, -4, 1, "-.250")]	//仕様未定義(ありえない引数)
		[TestCase(5, 4, 45, "11.250")]	//仕様未定義(ありえない引数)
		public void Get表示用打率Test(int 打席数, int 打数, int 安打数, string 期待値) {
			野球選手 p = new 野球選手();
			string 打率 = p.Get表示用打率(打席数, 打数, 安打数);
			Assert.AreEqual(期待値, 打率);
		}

	}
}
