using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_03 : CardInfo
{
    public CardInfo_114_JA_03()
    {
        this.cardNo = "114_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "マウイ";
        this.cardName2 = "クジラ";
        this.power = 8;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandaraTang;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
