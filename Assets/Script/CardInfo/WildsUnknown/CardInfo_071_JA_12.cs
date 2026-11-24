using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_12 : CardInfo
{
    public CardInfo_071_JA_12()
    {
        this.cardNo = "071_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マクガフィンの若君";
        this.cardName2 = "おだやか息子";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
