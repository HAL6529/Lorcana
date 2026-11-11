using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_05 : CardInfo
{
    public CardInfo_104_JA_05()
    {
        this.cardNo = "104_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "ぶっ壊し野郎";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
