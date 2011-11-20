using System;

namespace TDDBC横浜 {
	public class 野球選手 {
		public decimal? Calc打率(int 打席数, int 打数, int 安打数) {
			if (打席数 == 0)
				return null;

			if (打数 == 0)
				return 0.0m;

			return Math.Round((decimal)安打数 / 打数, 3, MidpointRounding.AwayFromZero);
			//TODO: 四捨五入方式は AwayFromZero で良いか?
		}

		public string Get表示用打率(int 打席数, int 打数, int 安打数) {
			decimal? 打率データ = this.Calc打率(打席数, 打数, 安打数);
			if (打率データ == null)
				return "----";

			decimal 打率 = 打率データ.Value;
			if (打率 == 1.0m)
				return "1.00";

			return 打率.ToString(".000");
		}
	}
}
