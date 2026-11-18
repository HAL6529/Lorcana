using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_08 : CardInfo
{
    public CardInfo_061_JA_08()
    {
        this.cardNo = "061_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ピノキオ";
        this.cardName2 = "あや吊り人形";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
