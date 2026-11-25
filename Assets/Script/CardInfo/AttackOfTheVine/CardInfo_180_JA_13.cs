using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_13 : CardInfo
{
    public CardInfo_180_JA_13()
    {
        this.cardNo = "180_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "カエルの守護者";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PatriBalanovsky;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
