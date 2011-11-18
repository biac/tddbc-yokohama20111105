using NUnit.Framework;

namespace TDDBC横浜 {
	[TestFixture()]
	public class 野球選手Tests {
		[TestCase()]
		public void Calc打率Test01_安打数0のとき_打率0(){
			//準備
			int 打席数=0;
			int 打数=0;
			int 安打数 = 0;
			decimal 期待値 = 0.0m;

			野球選手 p = new 野球選手();

			//実行
			decimal 打率 = p.Calc打率(打席数, 打数, 安打数);

			//検証
			Assert.AreEqual(期待値, 打率);

			//後始末
			// (無し)
		}
	}
}
