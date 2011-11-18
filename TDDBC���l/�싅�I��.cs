using System;

namespace TDDBC横浜 {
	public class 野球選手 {
		public decimal Calc打率(int 打席数, int 打数, int 安打数) {
			return Math.Round((decimal)安打数 / 打数, 3, MidpointRounding.AwayFromZero);
			//TODO: 四捨五入方式は AwayFromZero で良いか?
		}
	}
}
