using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_14 : CardInfo
{
    public CardInfo_006_JA_14()
    {
        this.cardNo = "006_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミリアム・メンデルソーン";
        this.cardName2 = "きらきらファン";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CaseyJoOcean;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
