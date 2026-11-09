using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_03 : CardInfo
{
    public CardInfo_171_JA_03()
    {
        this.cardNo = "171_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "‘º’·ƒgƒDƒC";
        this.cardName2 = "ƒ‚ƒgƒDƒkƒC‚ÌŒÖ‚è";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
