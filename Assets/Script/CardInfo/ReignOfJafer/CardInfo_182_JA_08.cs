using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_08 : CardInfo
{
    public CardInfo_182_JA_08()
    {
        this.cardNo = "182_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ボビー";
        this.cardName2 = "紫のハト";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AdamFenton;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
