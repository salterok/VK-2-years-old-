using System;
using System.ComponentModel;

namespace VK
{
	[Flags]
	public enum ProfileFields : uint
	{
		Default = Uid | FirstName | LastName,

		[Description("uid")]
		Uid = 0x01,

		[Description("first_name")]
		FirstName = 0x02,

		[Description("last_name")]
		LastName = 0x04,

		[Description("sex")]
		Sex = 0x08,

		[Description("online")]
		Online = 0x10,

		[Description("bdate")]
		Bdate = 0x20,

		[Description("city")]
		City = 0x40,

		[Description("country")]
		Country = 0x80,

		[Description("photo")]
		Photo = 0x0100,

		[Description("photo_medium")]
		PhotoMedium = 0x0200,

		[Description("photo_medium_rec")]
		PhotoMediumRec = 0x0400,

		[Description("photo_big")]
		PhotoBig = 0x0800,

		[Description("photo_rec")]
		PhotoRec = 0x1000,

		[Description("lists")]
		Lists = 0x2000,

		[Description("screen_name")]
		ScreenName = 0x4000,

		[Description("has_mobile")]
		HasMobile = 0x8000,

		[Description("rate")]
		Rate = 0x010000,

		[Description("contacts")]
		Contacts = 0x020000,

		[Description("education")]
		Education = 0x040000,

		[Description("can_post")]
		CanPost = 0x080000,

		[Description("can_see_all_posts")]
		CanSeeAllPosts = 0x100000,

		[Description("can_write_private_message")]
		CanWritePrivateMessage = 0x200000,

		[Description("activity")]
		Activity = 0x400000,

		[Description("relation")]
		Relation = 0x800000,

		[Description("counters")]
		Counters = 0x01000000,

		[Description("nickname")]
		Nickname = 0x02000000,

		[Description("exports")]
		Exports = 0x04000000,

		[Description("wall_comments")]
		WallComments = 0x08000000
	}
}