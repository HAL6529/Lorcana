using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_13 : CardInfo
{
    public CardInfo_117_JA_13()
    {
        this.cardNo = "117_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "スプラディーヘッド";
        this.cardName2 = "試作品619号";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
