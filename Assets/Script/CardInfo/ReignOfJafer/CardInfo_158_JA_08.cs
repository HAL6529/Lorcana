using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_08 : CardInfo
{
    public CardInfo_158_JA_08()
    {
        this.cardNo = "158_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ワサビ";
        this.cardName2 = "いつでも準備万端";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
