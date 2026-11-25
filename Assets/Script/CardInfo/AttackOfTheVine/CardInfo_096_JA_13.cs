using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_096_JA_13 : CardInfo
{
    public CardInfo_096_JA_13()
    {
        this.cardNo = "096_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ケートス";
        this.cardName2 = "恐るべき大蛇";
        this.power = 6;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CelesteJamneck;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
