using System;
using System.ComponentModel;

namespace RoadFlow.Data.Model
{
	[Serializable]
	public class Dictionary
	{
		[DisplayName("ID")]
		public Guid ID
		{
			get;
			set;
		}

		[DisplayName("上级ID")]
		public Guid ParentID
		{
			get;
			set;
		}

		[DisplayName("标题")]
		public string Title
		{
			get;
			set;
		}

		[DisplayName("唯一代码")]
		public string Code
		{
			get;
			set;
		}

		[DisplayName("值")]
		public string Value
		{
			get;
			set;
		}

		[DisplayName("备注")]
		public string Note
		{
			get;
			set;
		}

		[DisplayName("其它信息")]
		public string Other
		{
			get;
			set;
		}

		[DisplayName("排序")]
		public int Sort
		{
			get;
			set;
		}
	}
}
