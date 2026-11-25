using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_13 : CardInfo
{
    public CardInfo_038_JA_13()
    {
        this.cardNo = "038_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "フルーダー";
        this.cardName2 = "不運な楽師";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
