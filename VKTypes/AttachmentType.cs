using System.ComponentModel;

namespace VK
{
	public enum AttachmentType
	{
		[Description("photo")]
		photo,

		[Description("video")]
		video,

		[Description("audio")]
		audio,

		[Description("doc")]
		doc
	}
}