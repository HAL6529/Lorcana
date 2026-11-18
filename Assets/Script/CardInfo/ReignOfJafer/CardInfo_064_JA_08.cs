using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_08 : CardInfo
{
    public CardInfo_064_JA_08()
    {
        this.cardNo = "064_JA_08";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "モンストロ";
        this.cardName2 = "恐怖のクジラ";
        this.power = 6;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
