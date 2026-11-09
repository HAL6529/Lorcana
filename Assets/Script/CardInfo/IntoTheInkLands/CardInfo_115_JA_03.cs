using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_03 : CardInfo
{
    public CardInfo_115_JA_03()
    {
        this.cardNo = "115_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "気鋭の学者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MassimilianoNarciso;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
