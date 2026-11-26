using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_14 : CardInfo
{
    public CardInfo_175_JA_14()
    {
        this.cardNo = "175_JA_14";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "チクタクワニ";
        this.cardName2 = "運河のワニ";
        this.power = 9;
        this.toughness = 9;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
