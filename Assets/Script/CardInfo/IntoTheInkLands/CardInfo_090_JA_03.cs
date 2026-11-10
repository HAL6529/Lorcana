using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_03 : CardInfo
{
    public CardInfo_090_JA_03()
    {
        this.cardNo = "090_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉAÅ[ÉXÉâ";
        this.cardName2 = "ÈxÇµâÆ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
