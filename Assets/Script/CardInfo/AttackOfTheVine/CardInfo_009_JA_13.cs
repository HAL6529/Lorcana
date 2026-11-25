using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_13 : CardInfo
{
    public CardInfo_009_JA_13()
    {
        this.cardNo = "009_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミリアム・メンデルソーン";
        this.cardName2 = "チケットを握りし者";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiegoMachuca;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
