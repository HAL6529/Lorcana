using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_13 : CardInfo
{
    public CardInfo_016_JA_13()
    {
        this.cardNo = "016_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "メイ・リー";
        this.cardName2 = "コントロール不能";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
