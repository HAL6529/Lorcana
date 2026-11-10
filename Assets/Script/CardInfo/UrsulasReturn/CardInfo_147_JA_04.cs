using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_04 : CardInfo
{
    public CardInfo_147_JA_04()
    {
        this.cardNo = "147_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒCƒhƒDƒi";
        this.cardName2 = "Žœˆ¤‚Ì•ê";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JakeMurphy;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
