using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_03 : CardInfo
{
    public CardInfo_150_JA_03()
    {
        this.cardNo = "150_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "É}ÉäÉAÉìïP";
        this.cardName2 = "ñ≤å©ÇÈÇ®îNç†";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
