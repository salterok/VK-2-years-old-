using System;

namespace VK
{
	public struct Attachment
	{
		public AttachmentType type;
		public long ownerId;
		public long mediaId;

		public Attachment(AttachmentType aType, long owner, long media)
		{
			type = aType;
			ownerId = owner;
			mediaId = media;
		}

		public override string ToString()
		{
			return String.Format("{0}{1}_{2}", type.GetDescriptionValue(), ownerId, mediaId);
		}
	}
}