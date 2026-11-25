using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_13 : CardInfo
{
    public CardInfo_149_JA_13()
    {
        this.cardNo = "149_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "エリー･フレドリクセン";
        this.cardName2 = "冒険のパートナー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.YrganeRamon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
