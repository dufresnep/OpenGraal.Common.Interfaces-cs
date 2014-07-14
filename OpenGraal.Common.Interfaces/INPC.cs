using System;
namespace OpenGraal.Common.Interfaces
{
	public interface INPC
	{
		sbyte BlockFlags { get; set; }
		sbyte VisFlags { get; set; }
		int Width { get; set; }
		int Height { get; set; }
		string BodyImage { get; set; }
		string Image { get; set; }
		int Dir { get; set; }
		string GetErrorText();
		void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		Core.CString GetProp(NpcProperties PropId);
		string HeadImage { get; set; }
		int PixelX { get; set; }
		int PixelY { get; set; }
		void SendProp(NpcProperties PropId);
		void SetProps(Core.CString Packet);
		string ShieldImage { get; set; }
		string SwordImage { get; set; }
	}

	public enum NpcProperties
	{
		IMAGE = 0,
		SCRIPT = 1,
		NPCX = 2,
		NPCY = 3,
		NPCPOWER = 4,
		NPCRUPEES = 5,
		ARROWS = 6,
		BOMBS = 7,
		GLOVEPOWER = 8,
		BOMBPOWER = 9,
		SWORDIMG = 10,
		SHIELDIMG = 11,
		GANI = 12,
		VISFLAGS = 13,
		BLOCKFLAGS = 14,
		MESSAGE = 15,
		HURTDXDY = 16,
		NPCID = 17,
		SPRITE = 18,
		COLORS = 19,
		NICKNAME = 20,
		HORSEIMG = 21,
		HEADIMG = 22,
		SAVE0 = 23,
		SAVE1 = 24,
		SAVE2 = 25,
		SAVE3 = 26,
		SAVE4 = 27,
		SAVE5 = 28,
		SAVE6 = 29,
		SAVE7 = 30,
		SAVE8 = 31,
		SAVE9 = 32,
		ALIGNMENT = 33,
		IMAGEPART = 34,
		BODYIMG = 35,
		GATTRIB1 = 36,
		GATTRIB2 = 37,
		GATTRIB3 = 38,
		GATTRIB4 = 39,
		GATTRIB5 = 40,
		GMAPLVLX = 41,
		GMAPLVLY = 42,
		EMPTY43 = 43,
		GATTRIB6 = 44,
		GATTRIB7 = 45,
		GATTRIB8 = 46,
		GATTRIB9 = 47,
		UNKNOWN48 = 48,
		UNKNOWN49 = 49,
		UNKNOWN50 = 50,
		UNKNOWN51 = 51,
		UNKNOWN52 = 52,
		GATTRIB10 = 53,
		GATTRIB11 = 54,
		GATTRIB12 = 55,
		GATTRIB13 = 56,
		GATTRIB14 = 57,
		GATTRIB15 = 58,
		GATTRIB16 = 59,
		GATTRIB17 = 60,
		GATTRIB18 = 61,
		GATTRIB19 = 62,
		GATTRIB20 = 63,
		GATTRIB21 = 64,
		GATTRIB22 = 65,
		GATTRIB23 = 66,
		GATTRIB24 = 67,
		GATTRIB25 = 68,
		GATTRIB26 = 69,
		GATTRIB27 = 70,
		GATTRIB28 = 71,
		GATTRIB29 = 72,
		GATTRIB30 = 73,
		CLASS = 74,
		// NPC-Server class.  Possibly also join scripts.
		PIXELX = 75,
		PIXELY = 76,
	};
}
