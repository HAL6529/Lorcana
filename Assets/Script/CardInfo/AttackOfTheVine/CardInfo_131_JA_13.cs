using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_131_JA_13 : CardInfo
{
    public CardInfo_131_JA_13()
    {
        this.cardNo = "131_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ピーターパン";
        this.cardName2 = "つるに挑む決闘者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ClioSchaffner;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
