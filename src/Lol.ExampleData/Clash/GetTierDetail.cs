﻿using Lol.Data.Clash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
	{
		public static List<TierDetailModel> GetTierDetail()
		{
			List<TierDetailModel> source = new()
			{
				new TierDetailModel(0, "격전의신", "CEX", "28:57"),
				new TierDetailModel(1, "평경1짱", "SBM", "28:57"),
				new TierDetailModel(2, "수박먹고싶다", "asd", "28:57"),
				new TierDetailModel(3, "주지훈", "GOD", "28:57"),
				new TierDetailModel(4, "korea", "KOR", "28:57"),
				new TierDetailModel(5, "wOw", "WoW", "28:57"),
				new TierDetailModel(6, "캐치형 기릿", "OTL", "28:57"),
				new TierDetailModel(7, "니가 생각하는 그것", "MH", "28:57"),
				new TierDetailModel(8, "격임버지의 새로운 시도", "LIM", "28:57"),
				new TierDetailModel(9, "하이루", "ENF", "28:57"),
				new TierDetailModel(10, "찡긋찡긋", "WEE", "28:57"),
				new TierDetailModel(11, "존고게이밍", "JGG", "28:57"),
				new TierDetailModel(12, "1티어", "mTE", "28:57"),
				new TierDetailModel(13, "서화", "zcv", "28:57"),
				new TierDetailModel(14, "격전", "OEO", "28:57"),
				new TierDetailModel(15, "치오띠", "WKU", "28:57"),
			};

			return source;
		}
	}
}